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
    public partial class ListarPerifericosVista : Form
    {
        private Repositorio _repositorio;
        public ListarPerifericosVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            bsPeriferico.DataSource = _repositorio.ObtenerTodosLosPerifericos();
        }

        private void ListarPerifericosVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet1.Periferico' Puede moverla o quitarla según sea necesario.
            this.perifericoTableAdapter.Fill(this.sIGEIDBDataSet1.Periferico);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaPeriferico = new AgregarEquipoVista();
            vistaPeriferico.MdiParent = VistaPrincipal.ActiveForm;
            vistaPeriferico.Show();
            vistaPeriferico.CheckearPeriferico();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarPeriferico(codigoEliminar);


                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Periferico",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se elimino el periferico: {(string)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[3].Value}"
                };

                _repositorio.AgregarAuditoria(auditoria);



                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Vuelva a intentar cuando tenga Perifericos cargados o cuando tenga elementos en la lista");
            }
        }

        private void ActualizarTabla()
        {
            this.perifericoTableAdapter.Fill(this.sIGEIDBDataSet1.Periferico);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var periferico = _repositorio.BuscarPeriferico(codigoModificar);
                if (periferico != null)
                {
                    MessageBox.Show($"Se encontro el departamento {periferico.Descripcion}");

                    this.Dispose();
                    var vistaPeriferico = new AgregarEquipoVista();
                    vistaPeriferico.MdiParent = VistaPrincipal.ActiveForm;
                    vistaPeriferico.Show();
                    vistaPeriferico.MostrarPeriferico(codigoModificar,periferico);

                }


            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }
    }
}
