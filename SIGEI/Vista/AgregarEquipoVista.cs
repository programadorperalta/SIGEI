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
    public partial class AgregarEquipoVista : Form
    {
        //private Inventario _inventario = new Inventario();
        private string Seleccion { get; set; }

        public AgregarEquipoVista()
        {
            InitializeComponent();
            DeshabilitarCampos(false);
            //cbGarantia.DataSource = _inventario.GetGarantias();
            //cbProveedor.DataSource = _inventario.GetProveedores();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void DeshabilitarCampos(bool bandera)
        {
               
            txtNserie.Enabled = bandera;
            txtDescripcion.Enabled = bandera;
            txtMarca.Enabled = bandera;
            txtModelo.Enabled = bandera;
            cbGarantia.Enabled = bandera;
            cbProveedor.Enabled = bandera;

        }

        private void rbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos(true);
        }

        private void rbPeriferico_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos(true);
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            //Garantia garantia = (Garantia)cbGarantia.SelectedItem;
            //Proveedor proveedor = (Proveedor)cbProveedor.SelectedItem;

            //if (rbEquipo.Checked)
            //{
            //    var equipo = new Equipo(Int32.Parse(txtCodigo.Text), Int32.Parse(txtNserie.Text), txtMarca.Text, txtModelo.Text, txtDescripcion.Text, garantia, proveedor);
            //    _inventario.AgregarEquipoInformatico(equipo);
            //} else if (rbPeriferico.Checked)
            //{
            //    var periferico = new Periferico(Int32.Parse(txtCodigo.Text),txtMarca.Text,txtModelo.Text,txtDescripcion.Text, Int32.Parse(txtNserie.Text),garantia,proveedor);
            //    _inventario.AgregarPeriferico(periferico);
            //    MessageBox.Show(""+_inventario.GetPerifericos());
            //}


            
        }
    }
}
