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
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
          
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaAgregarEquipoPeriferico = new AgregarEquipoVista();
            vistaAgregarEquipoPeriferico.MdiParent = this;
            vistaAgregarEquipoPeriferico.Show();
        }

        private void perifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaEmpleados = new EmpleadoVista();
            vistaEmpleados.MdiParent = this;
            vistaEmpleados.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaUsuarios = new UsuarioVista();
            vistaUsuarios.MdiParent = this;
            vistaUsuarios.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaProveedores = new ProveedorVista();
            vistaProveedores.MdiParent = this;
            vistaProveedores.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaDepartamentos = new DepartamentoVista();
            vistaDepartamentos.MdiParent = this;
            vistaDepartamentos.Show();
        }

        public void HablitarOpciones(Usuario usuario)
        {
            txtBienvenida.Text = usuario.Empleado.Nombre;

            if (usuario.Permiso.Equals("Administrador"))
            {
                //TODO:
                equiposPerifericosToolStripMenuItem.Enabled = false;
                equipoEmpleadoToolStripMenuItem.Enabled = false;
                equipoToolStripMenuItem.Enabled = false;
                perifericosToolStripMenuItem.Enabled = false;
                
                


            } else if (usuario.Permiso.Equals("Recepcionista"))
            {
                //TODO: 
                usuariosToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                departamentosToolStripMenuItem.Enabled = false;
                proveedoresToolStripMenuItem.Enabled = false;
                




            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
