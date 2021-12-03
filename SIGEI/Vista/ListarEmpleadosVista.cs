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
    public partial class ListarEmpleadosVista : Form
    {
        private Repositorio _repositorio;

        public ListarEmpleadosVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            bsEmpleado.DataSource = _repositorio.ObtenerTodosLosEmpleados();
            
        }

        private void ListarEmpleadosVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.sIGEIDBDataSet.Empleado);

        }

        public void ActualizarTabla()
        {
            this.empleadoTableAdapter.Fill(this.sIGEIDBDataSet.Empleado);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaEmpleado = new EmpleadoVista();
            vistaEmpleado.MdiParent = VistaPrincipal.ActiveForm;
            vistaEmpleado.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarEmpleado(codigoEliminar);
                

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Empleado",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se eliminó el Empleado: {(string)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
                };
                _repositorio.AgregarAuditoria(auditoria);

                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Vuelva a intentar cuando tenga Empleados cargados o cuando tenga elementos en la lista");
            }
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
          
            if (lista.RowCount != 0)
            {
      
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var empleado = _repositorio.BuscarEmpleado2(codigoModificar);

                if (empleado != null)
                {
                    MessageBox.Show($"Se encontro el empleado {empleado.Nombre} - {empleado.Legajo}");

                    this.Dispose();
                    var vistaEmpleado = new EmpleadoVista();
                    vistaEmpleado.MdiParent = VistaPrincipal.ActiveForm;
                    vistaEmpleado.Show();
                    vistaEmpleado.MostrarEmpleado(codigoModificar, empleado);

                }


            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }
    }
}
