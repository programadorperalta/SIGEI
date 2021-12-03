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
    public partial class AutenticarUsuarioVista : Form
    {
        private Repositorio _repositorio;

        public AutenticarUsuarioVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
          var vistaPrincipal = new VistaPrincipal();
            

            string username = txtUsername.Text;
            string password = txtPass.Text;

            if (_repositorio.ValidarUsuario(username, password))
            {
                var usuario = _repositorio.BuscarUsuario(username, password);
                
                if (usuario != null)
                {

                    MessageBox.Show($"Bienvenid@: {usuario.Empleado.Nombre} - {usuario.Empleado.Legajo}");

                    var auditoria = new Auditoria()
                    {
                        Entidad = "Inicio de sesion",
                        FechaAlta = DateTime.Now,
                        Datos = $"{usuario.Nick}-{usuario.Permiso}"
                    };

                    _repositorio.AgregarAuditoria(auditoria);
                    vistaPrincipal.Visible = true;
                    vistaPrincipal.HablitarOpciones(usuario);
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("No se encuentra el usuario, Por favor intente nuevamente");
                }
            }

        }

        public void LimpiarCampos()
        {
            txtPass.Text ="";
            txtUsername.Text ="";
        }

    }
}
