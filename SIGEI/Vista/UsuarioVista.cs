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
    public partial class UsuarioVista : Form
    {
        private Repositorio _repositorio;
        private Empleado _empleado = null;
        private int _codigo;
        private Usuario _usuarioUpdate;

        public UsuarioVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            btnModificar.Enabled = false;
            DeshabilitarCampos(false);

        }
        public void MostrarUsuario(int codigo, Usuario usuario)
        {
            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;
            txtLegajoEmpleado.Enabled = false;
            txtNombreEmpleado.Enabled = false;
            

            _codigo = codigo;
            //llenar campos 
            txtLegajoEmpleado.Text = usuario.Empleado.Legajo.ToString();
            txtNombreEmpleado.Text = usuario.Empleado.Nombre.ToString();
            txtUsuario.Text = usuario.Nick;
            txtContraseña.Text = usuario.Contraseña;
        }



        private void DeshabilitarCampos(bool estado)
        {
            txtUsuario.Enabled = estado;
            txtContraseña.Enabled = estado;
            cbPermisos.Enabled = estado;
        }
        
        private bool CheckearCamposEmpleado()
        {
            return !string.IsNullOrEmpty(txtLegajoEmpleado.Text);
        }

        private bool CheckearCamposUsuario()
        {
            return !string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContraseña.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //validar empleado 
            if (CheckearCamposEmpleado())
            {
                 _empleado = _repositorio.BuscarEmpleado(Int32.Parse(txtLegajoEmpleado.Text));

                if (_empleado!= null)
                {
                    MessageBox.Show($"Se encontro el empleado: {_empleado.Nombre} {_empleado.Apellido}");
                    txtNombreEmpleado.Text = _empleado.Nombre;
                    DeshabilitarCampos(true);
                }
                else
                {
                    MessageBox.Show("No se encontro el empleado intente nuevamente");
                }

            }
            else
            {
                MessageBox.Show("Para continuar debe completar el legajo del empleado");
            }


        }


        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            //registrar usuario 
            if (CheckearCamposUsuario())
            {
                var usuario = new Usuario()
                {
                    Nick = txtUsuario.Text,
                    Contraseña = txtContraseña.Text,
                    Permiso = cbPermisos.SelectedItem.ToString(),
                    Empleado = _empleado
                };

                var auditoria = new Auditoria()
                {
                    Entidad = "Alta de usuario",
                    FechaAlta = DateTime.Now,
                    Datos = $"{usuario.Nick}-{usuario.Permiso}"
                };

                _repositorio.AgregarUsuario(usuario);

                _repositorio.AgregarAuditoria(auditoria);

                MessageBox.Show($"Se agrego con exito el usuario:{usuario.Nick}");
                LimpiarCampos();

                this.Dispose();
                var listarUsuarios = new ListarUsuariosVissta();
                listarUsuarios.MdiParent = VistaPrincipal.ActiveForm;
                listarUsuarios.Show();

            }
            else
            {
                MessageBox.Show("Para continuar debe completar todos los campos");
            }


        }

        private void LimpiarCampos()
        {
            txtLegajoEmpleado.Text = "";
            txtUsuario.Text = "";
            txtNombreEmpleado.Text = "";
            txtContraseña.Text = "";
            cbPermisos.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            _usuarioUpdate = new Usuario()
            {
                Id = _codigo,
                Nick = txtUsuario.Text,
                Contraseña = txtContraseña.Text,
                Permiso = cbPermisos.SelectedItem.ToString()
            };

            _repositorio.ModificarUsuario(_codigo, _usuarioUpdate);


            var auditoria = new Auditoria()
            {
                Entidad = "Modificacion de Usuario",
                FechaAlta = DateTime.Now,
                Datos = $"Se modifico el usuario: {_usuarioUpdate.Nick}"
            };

            _repositorio.AgregarAuditoria(auditoria);








            MessageBox.Show("Se actualizo el registro con exito");
            this.Dispose();

            var listaUsuarios = new ListarUsuariosVissta();
            listaUsuarios.MdiParent = VistaPrincipal.ActiveForm;
            listaUsuarios.Show();


        }
    }
}
