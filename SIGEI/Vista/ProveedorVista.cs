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

        public ProveedorVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
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

                _repositorio.AgregarProveedor(proveedor);
                MessageBox.Show($"Se agrego con exito el proveedor {proveedor.Nombre}");
                LimpiarCampos(); 
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
