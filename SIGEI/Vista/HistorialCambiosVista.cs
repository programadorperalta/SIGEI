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
    public partial class HistorialCambiosVista : Form
    {
        private Repositorio _repositorio;

        public HistorialCambiosVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            bsAuditoria.DataSource = _repositorio.ObtenerTodasLasAuditorias();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltro.Text))
            {
                bsAuditoria.DataSource = _repositorio.ObtenerTodasLasAuditorias();
            }
            else
            {
                bsAuditoria.DataSource = _repositorio.FiltrarListaAuditorias(txtFiltro.Text);
            }

        }
    }
}
