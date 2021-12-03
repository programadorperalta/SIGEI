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
    public partial class DepartamentoVista : Form
    {
        private Repositorio _repositorio;
        private Departamento _departamentUpdate;
        private int _codigo;

        public DepartamentoVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            btnModificar.Enabled = false;
        }

        public void MostrarDepartamento(int codigo, Departamento departamento)
        {
            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;
           
            _codigo = codigo;
            txtNombreDepartamento.Text = departamento.Nombre;
        }
        

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (ControlarCampos())
            {
                var departamento = new Departamento()
                {
                    Nombre = txtNombreDepartamento.Text
                };

                var auditoria = new Auditoria()
                {
                    Entidad = "Alta de departamento",
                    FechaAlta = DateTime.Now,
                    Datos = $"{departamento.Nombre}"
                };

                _repositorio.AgregarDepartamento(departamento);
                _repositorio.AgregarAuditoria(auditoria);

                MessageBox.Show($"Se agrego con exito el departamento: {departamento.Nombre}");
                LimpiarCampos();

                this.Dispose();
                var listaDepartamento = new ListarDepartamentosVista();
                listaDepartamento.MdiParent = VistaPrincipal.ActiveForm;
                listaDepartamento.Show();
            }
        }

        private void LimpiarCampos()
        {
            txtNombreDepartamento.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool ControlarCampos()
        {
            if (string.IsNullOrEmpty(txtNombreDepartamento.Text))
            {
                MessageBox.Show("Para continuar debe completar el campo!!");
                return false;
            }

            return true;
        }

        private void txtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            _departamentUpdate = new Departamento()
            {
                Id = _codigo,
                Nombre = txtNombreDepartamento.Text
            };


            _repositorio.ModificarDepartamento(_codigo,_departamentUpdate);


            var auditoria = new Auditoria()
            {
                Entidad = "Modificacion de departamento",
                FechaAlta = DateTime.Now,
                Datos = $"Se modifico el departamento a : {_departamentUpdate.Nombre}"
            };

            _repositorio.AgregarAuditoria(auditoria);


            MessageBox.Show("Se actualizo el registro con exito");
            this.Dispose();
            var listaDepartamento = new ListarDepartamentosVista();
            listaDepartamento.MdiParent = VistaPrincipal.ActiveForm;
            listaDepartamento.Show();
            

        }
    }
}
