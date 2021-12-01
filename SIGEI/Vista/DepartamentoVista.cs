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
        //private Inventario _inventario = new Inventario();
        public DepartamentoVista()
        {
            InitializeComponent();
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (ControlarCampos())
            {
                //var departamento = new Departamento(Int32.Parse(txtIDepartamento.Text),txtNombreDepartamento.Text);
                //_inventario.AgregarDepartamento(departamento);
                //MessageBox.Show(""+_inventario.GetDepartamentos());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private bool ControlarCampos()
        {
            if (string.IsNullOrEmpty(txtIDepartamento.Text) || string.IsNullOrEmpty(txtNombreDepartamento.Text))
            {
                MessageBox.Show("Para continuar debe completar todos los campos!!");
                return false;
            }

            return true;
        }
    }
}
