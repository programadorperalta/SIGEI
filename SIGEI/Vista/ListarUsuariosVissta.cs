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
    public partial class ListarUsuariosVissta : Form
    {
        private Repositorio _repositorio;

        public ListarUsuariosVissta()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
        }

        private void ListarUsuariosVissta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIGEIDBDataSet6.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.sIGEIDBDataSet6.Usuario);

        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            var vistaUsuario = new UsuarioVista();
            vistaUsuario.MdiParent = VistaPrincipal.ActiveForm;
            vistaUsuario.Show();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoEliminar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                _repositorio.EliminarUsuario(codigoEliminar);

                var auditoria = new Auditoria()
                {
                    Entidad = "Baja de Usuario",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se elimino el usuario: {(string)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[1].Value}"
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
            this.usuarioTableAdapter.Fill(this.sIGEIDBDataSet6.Usuario);
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            if (lista.RowCount != 0)
            {
                int codigoModificar = (int)lista.Rows[lista.SelectedCells[0].RowIndex].Cells[0].Value;
                var usuario = _repositorio.BuscarUsuario(codigoModificar);
                if (usuario != null)
                {
                    MessageBox.Show($"Se encontro el usuario: {usuario.Nick}");

                    this.Dispose();
                    var vistaUsuario = new UsuarioVista();
                    vistaUsuario.MdiParent = VistaPrincipal.ActiveForm;
                    vistaUsuario.Show();
                    vistaUsuario.MostrarUsuario(codigoModificar, usuario);

                }


            }
            else
            {
                MessageBox.Show("Para continuar debe seleccionar por lo menos un registro");
            }
        }
    }
}
