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
                equiposToolStripMenuItem.Enabled = false;
                perifericosToolStripMenuItem1.Enabled = false;
                equipoPerifericoToolStripMenuItem.Enabled = false;
                
                


            } else if (usuario.Permiso.Equals("Recepcionista"))
            {
                //TODO: 
                empleadosToolStripMenuItem1.Enabled = false;
                proveedoresToolStripMenuItem1.Enabled = false;
                departamentosToolStripMenuItem1.Enabled = false;
                usuariosToolStripMenuItem1.Enabled = false;

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void equiposPerifericosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaEquipoPeriferico = new EquipoPerifericoVista();
            vistaEquipoPeriferico.MdiParent = this;
            vistaEquipoPeriferico.Show();
        }

        private void verHistorialDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vistaHistorialDeCambios = new HistorialCambiosVista();
            vistaHistorialDeCambios.MdiParent = this;
            vistaHistorialDeCambios.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoEquipos = new ListarVista();
            listadoEquipos.MdiParent = this;
            listadoEquipos.Show();
        }

        private void perifericosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listadoPerifericos = new ListarPerifericosVista();
            listadoPerifericos.MdiParent = this;
            listadoPerifericos.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listadoEmpleados = new ListarEmpleadosVista();
            listadoEmpleados.MdiParent = this;
            listadoEmpleados.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listadoProveedores = new ListarProveedoresVista();
            listadoProveedores.MdiParent = this;
            listadoProveedores.Show();
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listadoDepartamentos = new ListarDepartamentosVista();
            listadoDepartamentos.MdiParent = this;
            listadoDepartamentos.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var listadoUsuarios = new ListarUsuariosVissta();
            listadoUsuarios.MdiParent = this;
            listadoUsuarios.Show();
        }

        private void equipoPerifericoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listadoEquiposPerifericos = new ListarEquipoPerifericosVista();
            listadoEquiposPerifericos.MdiParent = this;
            listadoEquiposPerifericos.Show();
        }
    }
}
