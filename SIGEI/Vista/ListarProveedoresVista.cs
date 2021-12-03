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
    public partial class ListarProveedoresVista : Form
    {
        private Repositorio _repositorio;

        public ListarProveedoresVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
        }

        private void ListarProveedoresVista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet4.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.sIGEIDBDataSet4.Proveedor);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaProveedor = new ProveedorVista();
            vistaProveedor.MdiParent = VistaPrincipal.ActiveForm;
            vistaProveedor.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarProveedor(codigoEliminar);

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Proveedor",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se elimino el proveedor: {(string)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
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
            this.proveedorTableAdapter.Fill(this.sIGEIDBDataSet4.Proveedor);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {

                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var proveedor = _repositorio.BuscarProveedor(codigoModificar);

                if (proveedor != null)
                {
                    MessageBox.Show($"Se encontro el empleado {proveedor.Nombre} - {proveedor.RazonSocial}");

                    this.Dispose();

                    var vistaProveedor = new ProveedorVista();
                    vistaProveedor.MdiParent = VistaPrincipal.ActiveForm;
                    vistaProveedor.Show();
                    vistaProveedor.MostrarProveedor(codigoModificar, proveedor);

                }


            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }
    }
}
