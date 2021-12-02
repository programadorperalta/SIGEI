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
    public partial class EmpleadoVista : Form
    {
        private Repositorio _repositorio;

        public EmpleadoVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            cbDepartamentos.DataSource = _repositorio.ObtenerTodosLosDepartamentos();
        }

        private bool ControlarCamposVacios()
        {
            bool bandera = true;
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtLegajo.Text) || cbDepartamentos.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor para continuar debe colocar todos los datos del Empleado y seleccionar el Departamento al que pertenece!");

                return bandera = false;
            }

            return bandera;
        }


        private void LimpiarCampos()
        {
            string asign = "";
            txtNombre.Text = asign;
            txtApellido.Text = asign;
            txtLegajo.Text = asign;
            txtDNI.Text = asign;
        }

        private void tituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoVista_Load(object sender, EventArgs e)
        {

        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (ControlarCamposVacios())
            {
                var nombre = txtNombre.Text;
                var apellido = txtApellido.Text;
                var dni = txtDNI.Text;
                var legajo = Int32.Parse(txtLegajo.Text);
                var departamento = cbDepartamentos.SelectedItem as Departamento;

                var empleado = new Empleado()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    Legajo = legajo,
                    Departamento = departamento
                };

                _repositorio.AgregarEmpleado(empleado);
                MessageBox.Show($"Se agrego con exito el empleado: {empleado.Nombre} - {empleado.Dni}");
                LimpiarCampos();
            }
        }

        private void EmpleadoVista_Load_1(object sender, EventArgs e)
        {

        }
    }
}
