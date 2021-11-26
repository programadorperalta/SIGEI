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
    }
}
