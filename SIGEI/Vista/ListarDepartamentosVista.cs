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
    public partial class ListarDepartamentosVista : Form
    {
        private Repositorio _repositorio;

        public ListarDepartamentosVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
        }

        private void ListarDepartamentosVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet5.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.sIGEIDBDataSet5.Departamento);

        }

        public void ActualizarTabla()
        {
            this.departamentoTableAdapter.Fill(this.sIGEIDBDataSet5.Departamento);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaDepartamento = new DepartamentoVista();
            vistaDepartamento.MdiParent = VistaPrincipal.ActiveForm;
            vistaDepartamento.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarDepartamento(codigoEliminar);

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de departamento",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se eliminó el departamento: {(string) lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
                };
                _repositorio.AgregarAuditoria(auditoria);
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Vuelva a intentar cuando tenga departamentos cargados o cuando tenga elementos en la lista");
            }
        }

        private void BusquedaText_TextChanged(object sender, EventArgs e)
        {
            //TODO: 
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var departamento = _repositorio.BuscarDepartamento(codigoModificar);
                if (departamento!=null)
                {
                    MessageBox.Show($"Se encontro el departamento {departamento.Nombre}");

                    this.Dispose();
                    var vistaDepartamento = new DepartamentoVista();
                    vistaDepartamento.MdiParent = VistaPrincipal.ActiveForm;
                    vistaDepartamento.Show();
                    vistaDepartamento.MostrarDepartamento(codigoModificar,departamento);
                    
                }

                
            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }
    }
}
