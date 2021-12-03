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
        private int _codigo;
        private Empleado _empleadoUpdate;

        public EmpleadoVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            cbDepartamentos.DataSource = _repositorio.ObtenerTodosLosDepartamentos();
            cbEquipos.DataSource = _repositorio.ObtenerTodosLosEquipos();
            cbEquipos.DisplayMember = "Description";
            cbEquipos.Enabled = false;
            btnModificar.Enabled = false;
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

        public void MostrarEmpleado(int codigo, Empleado empleado)
        {
            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;
            txtLegajo.Enabled = false;
            
            
            _codigo = codigo;

            //llenar campos
            txtNombre.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtLegajo.Text = empleado.Legajo.ToString();
            txtDNI.Text = empleado.Dni.ToString();
           
        }



        private void LimpiarCampos()
        {
            string asign = "";
            txtNombre.Text = asign;
            txtApellido.Text = asign;
            txtLegajo.Text = asign;
            txtDNI.Text = asign;
            rbChekEquipo.Checked = false;
            cbEquipos.Enabled = false;
        }

        private void tituloLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmpleadoVista_Load(object sender, EventArgs e)
        {

        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {

            if (ControlarCamposVacios() && rbChekEquipo.Checked)
            {
                cbEquipos.Enabled = true;
                var nombre = txtNombre.Text;
                var apellido = txtApellido.Text;
                var dni = txtDNI.Text;
                var legajo = Int32.Parse(txtLegajo.Text);
                var equipo = cbEquipos.SelectedItem as Equipo;
                var departamento = cbDepartamentos.SelectedItem as Departamento;

                var empleado = new Empleado()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Dni = dni,
                    Legajo = legajo,
                    Departamento = departamento,
                    Equipo = equipo
                };


                var auditoria = new Auditoria()
                {
                    Entidad = "Alta de empleado - Equipo",
                    FechaAlta = DateTime.Now,
                    Datos = $"{empleado.Nombre}-{empleado.Legajo}"
                };

                _repositorio.AgregarEmpleado(empleado);
                _repositorio.AgregarAuditoria(auditoria);
                MessageBox.Show($"Se agrego con exito el empleado: {empleado.Nombre} - {empleado.Dni}");
                LimpiarCampos();

                this.Dispose();
                var listaEmpleados = new ListarEmpleadosVista();
                listaEmpleados.MdiParent = VistaPrincipal.ActiveForm;
                listaEmpleados.Show();


            }

            else if (ControlarCamposVacios() && !rbChekEquipo.Checked)
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
                    Departamento = departamento,
                };

                _repositorio.AgregarEmpleado(empleado);
                MessageBox.Show($"Se agrego con exito el empleado: {empleado.Nombre} - {empleado.Dni}");
                LimpiarCampos();

                this.Dispose();
                var listaEmpleados = new ListarEmpleadosVista();
                listaEmpleados.MdiParent = VistaPrincipal.ActiveForm;
                listaEmpleados.Show();

            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos para continuar!");
            }
        }

        private void EmpleadoVista_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbChekEquipo_CheckedChanged(object sender, EventArgs e)
        {
            cbEquipos.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbChekEquipo.Checked)
            {
                _empleadoUpdate = new Empleado()
                {
                    Id = _codigo,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDNI.Text,
                    Legajo = Int32.Parse(txtLegajo.Text),
                    Departamento = cbDepartamentos.SelectedItem as Departamento,
                    Equipo = cbEquipos.SelectedItem as Equipo
                };
            }
            else
            {
                _empleadoUpdate = new Empleado()
                {
                    Id = _codigo,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDNI.Text,
                    Legajo = Int32.Parse(txtLegajo.Text),
                    Departamento = cbDepartamentos.SelectedItem as Departamento
                };
            }

            _repositorio.ModificarEmpleado(_codigo, _empleadoUpdate);

            var auditoria = new Auditoria()
            {
                Entidad = "Modificacion de empleado",
                FechaAlta = DateTime.Now,
                Datos = $"Se modifico el empleado: {_empleadoUpdate.Legajo}"
            };

            _repositorio.AgregarAuditoria(auditoria);



            MessageBox.Show("Se actualizo el registro con exito");
            this.Dispose();
            var listaEmpleado = new ListarEmpleadosVista();
            listaEmpleado.MdiParent = VistaPrincipal.ActiveForm;
            listaEmpleado.Show();

        }
    }
}
