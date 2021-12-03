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
    public partial class ListarEquipoPerifericosVista : Form
    {
        private Repositorio _repositorio;

        public ListarEquipoPerifericosVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
        }

        private void ListarEquipoPerifericosVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet7.EquipoPeriferico' Puede moverla o quitarla según sea necesario.
            this.equipoPerifericoTableAdapter.Fill(this.sIGEIDBDataSet7.EquipoPeriferico);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaEquipoPeriferico = new EquipoPerifericoVista();
            vistaEquipoPeriferico.MdiParent = VistaPrincipal.ActiveForm;
            vistaEquipoPeriferico.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarEquipoPeriferico(codigoEliminar);

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Equipo-Periferico",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se elimino el registro Equipo-Periferico dado de alta el: {(DateTime)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
                };

                _repositorio.AgregarAuditoria(auditoria);



                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Vuelva a intentar cuando tenga Equipos-Perifericos cargados o cuando tenga elementos en la lista");
            }
        }

        private void ActualizarTabla()
        {
            this.equipoPerifericoTableAdapter.Fill(this.sIGEIDBDataSet7.EquipoPeriferico);
        }

        
    }
}
