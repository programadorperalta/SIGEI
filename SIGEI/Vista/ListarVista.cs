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
    public partial class ListarVista : Form
    {
        private Repositorio _repositorio;


        public ListarVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            lista.DataSource = _repositorio.ObtenerTodosLosEquipos().Select(e => new Equipo() { 
            Id = e.Id,
            SerielNumber = e.SerielNumber,
            Description = e.Description,
            Model = e.Model,
            Marca = e.Marca,
            FechaAlta = e.FechaAlta,
            FechaVencimientoGarantia = e.FechaVencimientoGarantia,
            Proveedor = e.Proveedor,
            Departamento = e.Departamento
            }).ToList();
            

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaEquipo = new AgregarEquipoVista();
            vistaEquipo.MdiParent = VistaPrincipal.ActiveForm;
            vistaEquipo.Show();
            vistaEquipo.CheckearEquipo();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var equipo = _repositorio.BuscarEquipo1(codigoModificar);
                if (equipo != null)
                {
                    MessageBox.Show($"Se encontro el equipo: {equipo.Description}");

                    this.Dispose();

                    var vistaEquipo = new AgregarEquipoVista();
                    vistaEquipo.MdiParent = VistaPrincipal.ActiveForm;
                    vistaEquipo.Show();
                    vistaEquipo.MostrarEquipo(codigoModificar, equipo);

                }


            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarEquipo(codigoEliminar);

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Equipo",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se elimino el equipo: {(string)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
                };

                _repositorio.AgregarAuditoria(auditoria);

                ActualizarTabla();

            }
            else
            {
                MessageBox.Show("Vuelva a intentar cuando tenga Proveedores cargados o cuando tenga elementos en la lista");
            }
        }

        private void ActualizarTabla()
        {
            this.equipoTableAdapter.Fill(this.sIGEIDBDataSet3.Equipo);
        }

        private void BusquedaText_Click(object sender, EventArgs e)
        {

        }

        private void ListarVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet3.Equipo' Puede moverla o quitarla según sea necesario.
            this.equipoTableAdapter.Fill(this.sIGEIDBDataSet3.Equipo);
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet2.Equipo' Puede moverla o quitarla según sea necesario.
           

        }
    }
}
