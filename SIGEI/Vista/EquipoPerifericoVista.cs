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
    public partial class EquipoPerifericoVista : Form
    {
        private Repositorio _repositorio;
        private Equipo _equipo = null;

        private List<Periferico> listaAuxiliar = new List<Periferico>();
        private List<Periferico> listaAuxiliar2 = new List<Periferico>();

        public EquipoPerifericoVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            dgPerifericos.Enabled = false;
            dgPerifericos.DataSource = _repositorio.ObtenerTodosLosPerifericos();

            
        }


        private bool CheckearCamposEquipo()
        {
            return !string.IsNullOrEmpty(txtNSerie.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckearCamposEquipo())
            {
                dgPerifericos.Enabled = true;
                _equipo = _repositorio.BuscarEquipo(txtNSerie.Text);

                if (_equipo!=null)
                {
                    MessageBox.Show($"Se encontro el equipo: {_equipo.SerielNumber} - {_equipo.Description}");
                    txtDescripcion.Text = _equipo.Description;
                    txtFechaAlta.Text = _equipo.FechaAlta.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro el empleado intente nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgPerifericosAuxiliar.DataSource = new DataGridView();

            listaAuxiliar.Add((Periferico)dgPerifericos.CurrentRow.DataBoundItem);
            listaAuxiliar2.AddRange(listaAuxiliar);

            dgPerifericosAuxiliar.DataSource = listaAuxiliar2;
            listaAuxiliar.Clear();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (listaAuxiliar2.Count>0)
            {
                foreach (Periferico p in listaAuxiliar2)
                {
                    var equipoPerifericos = new EquipoPeriferico()
                    {
                        Equipo = _equipo,
                        FechaAlta = DateTime.Now,
                        Periferico = p
                    };

                    var auditoria = new Auditoria()
                    {
                        Entidad = "Alta de equipo-Periferico",
                        FechaAlta = DateTime.Now,
                        Datos = $"{equipoPerifericos.Equipo.SerielNumber}-{equipoPerifericos.Periferico.Descripcion}"
                    };

                    _repositorio.AgregarEquipoPerifericos(equipoPerifericos);

                    _repositorio.AgregarAuditoria(auditoria);

                }
                MessageBox.Show("Se agrego con exito el registro!");
                LimpiarCampos();
                this.Dispose();
                var listarEquiposPerifericos = new ListarEquipoPerifericosVista();
                listarEquiposPerifericos.MdiParent = VistaPrincipal.ActiveForm;
                listarEquiposPerifericos.Show();
            }
            else
            {
                MessageBox.Show("Para continuar es necesario que seleccione al menos un periferico de la lista");
            }
        }

        private void LimpiarCampos()
        {
            txtNSerie.Text = "";
            txtDescripcion.Text = "";
            txtFechaAlta.Text = "";
            dgPerifericosAuxiliar.DataSource = new DataGridView();
           
        }

        private void btnEliminarLista_Click(object sender, EventArgs e)
        {
            dgPerifericosAuxiliar.Rows.Remove(dgPerifericosAuxiliar.CurrentRow);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
