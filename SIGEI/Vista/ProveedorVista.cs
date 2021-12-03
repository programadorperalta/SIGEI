using SIGEI.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGEI.Vista
{
    public partial class ProveedorVista : Form
    {
        private Repositorio _repositorio;
        private int _codigo;
        private Proveedor _proveedorUpdate;


        public ProveedorVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            btnModificar.Enabled = false;
        }

        private bool ControlarCamposVacios()
        {
            bool bandera = true; 
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRazonSocial.Text) || string.IsNullOrEmpty(txtCuit.Text))
            {
                MessageBox.Show("Por favor para continuar debe colocar todos los datos del proveedor!");

                return bandera = false;
            }

            return bandera; 
        }

        public void MostrarProveedor(int codigo, Proveedor proveedor)
        {
            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;

            _codigo = codigo;
            //llenar campos 
            txtCuit.Text = proveedor.Cuit;
            txtNombre.Text = proveedor.Nombre;
            txtRazonSocial.Text = proveedor.RazonSocial;

        }


        private void LimpiarCampos()
        {
            string asign = "";
            txtCuit.Text = asign;
            txtNombre.Text = asign;
            txtRazonSocial.Text = asign;
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (ControlarCamposVacios())
            {
                var nombre = txtNombre.Text;
                var razonsocial = txtRazonSocial.Text;
                var cuit = txtCuit.Text;

                var proveedor = new Proveedor()
                {
                    Nombre = nombre,
                    RazonSocial = razonsocial,
                    Cuit = cuit
                };

                var auditoria = new Auditoria()
                {
                    Entidad = "Alta de proveedor",
                    FechaAlta = DateTime.Now,
                    Datos = $"{proveedor.Nombre}-{proveedor.Cuit}"
                };

                _repositorio.AgregarProveedor(proveedor);
                _repositorio.AgregarAuditoria(auditoria);


                MessageBox.Show($"Se agrego con exito el proveedor {proveedor.Nombre}");
                LimpiarCampos();

                this.Dispose();
                var listaProveedores = new ListarProveedoresVista();
                listaProveedores.MdiParent = VistaPrincipal.ActiveForm;
                listaProveedores.Show();


            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _proveedorUpdate = new Proveedor()
            {
                Id = _codigo,
                Nombre = txtNombre.Text,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCuit.Text
            };

            _repositorio.ModificarProveedor(_codigo, _proveedorUpdate);


            var auditoria = new Auditoria()
            {
                Entidad = "Modificacion de Proveedor",
                FechaAlta = DateTime.Now,
                Datos = $"Se modifico el proveedor: {_proveedorUpdate.Nombre}"
            };

            _repositorio.AgregarAuditoria(auditoria);


            MessageBox.Show("Se actualizo el registro con exito");
            this.Dispose();

            var listaproveedores = new ListarProveedoresVista();
            listaproveedores.MdiParent = VistaPrincipal.ActiveForm;
            listaproveedores.Show();

        }
    }
}
