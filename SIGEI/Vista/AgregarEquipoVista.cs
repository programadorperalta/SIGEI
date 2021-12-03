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
    public partial class AgregarEquipoVista : Form
    {

        private Repositorio _repositorio;
        private int _codigo;
        private Periferico _perifericoUpdate;
        private Equipo _equipoUpdate;

        public AgregarEquipoVista()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            cbProveedor.DataSource = _repositorio.ObtenerTodosLosProveedores();
            cbProveedor.DisplayMember = "Nombre";
            cbDepartamentos.DataSource = _repositorio.ObtenerTodosLosDepartamentos();
            cbDepartamentos.DisplayMember = "Nombre";
            btnModificar.Enabled = false;
            DeshabilitarCampos(false);
        }


        public void MostrarPeriferico(int codigo, Periferico periferico)
        {
            rbPeriferico.Checked = true;
            rbEquipo.Enabled = false;

            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;

            _codigo = codigo;
            //llenar campos 

            txtNserie.Text = periferico.NumeroDeSerie;
            txtDescripcion.Text = periferico.Descripcion;
            txtMarca.Text = periferico.Marca;
            txtModelo.Text = periferico.Modelo;
            dtpFechaVencimiento.Value = periferico.FechaVencimientoGarantia;
            
        }

        public void MostrarEquipo(int codigo, Equipo equipo)
        {

            rbPeriferico.Checked = false;
            rbEquipo.Enabled = true;

            btnModificar.Enabled = true;
            confirmarBoton.Enabled = false;

            _codigo = codigo;
            //llenar campos 

            txtNserie.Text = equipo.SerielNumber;
            txtDescripcion.Text = equipo.Description;
            txtMarca.Text = equipo.Marca;
            txtModelo.Text = equipo.Model;
            dtpFechaVencimiento.Value = equipo.FechaVencimientoGarantia;

        }



        public void CheckearPeriferico()
        {
            rbPeriferico.Checked = true;
            rbEquipo.Enabled = false;
        }

        public void CheckearEquipo()
        {
            rbEquipo.Checked = true;
            rbPeriferico.Enabled = false;
        }

        private bool CheckearCampos()
        {
            
            var respuesta = string.IsNullOrEmpty(txtDescripcion.Text) &&
            string.IsNullOrEmpty(txtMarca.Text) &&
            string.IsNullOrEmpty(txtModelo.Text) &&
            string.IsNullOrEmpty(txtNserie.Text) &&
            cbProveedor.SelectedIndex > -1 &&
            dtpFechaVencimiento.Value != null;


            return !respuesta;
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
            dtpFechaVencimiento.Enabled = bandera;
            cbProveedor.Enabled = bandera;
            cbDepartamentos.Enabled = bandera;

        }

        private void rbEquipo_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos(true);
            rbPeriferico.Checked = false;
            
        }

        private void rbPeriferico_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarCampos(true);
            rbEquipo.Checked = false;
            cbDepartamentos.Enabled = false;
        }

        private void confirmarBoton_Click(object sender, EventArgs e)
        {
            if (rbEquipo.Checked)
            {
                //Equipo
                if (CheckearCampos())
                {
                    var equipo = new Equipo()
                    {
                        SerielNumber = txtNserie.Text,
                        Description = txtDescripcion.Text,
                        Marca = txtMarca.Text,
                        Model = txtModelo.Text,
                        FechaVencimientoGarantia = dtpFechaVencimiento.Value,
                        Departamento = cbDepartamentos.SelectedItem as Departamento,
                        Proveedor = cbProveedor.SelectedItem as Proveedor,
                        FechaAlta = DateTime.Now


                    };

                    var auditoria = new Auditoria()
                    {
                        Entidad = "Alta de Equipo",
                        FechaAlta = DateTime.Now,
                        Datos = $"{equipo.SerielNumber}-{equipo.FechaVencimientoGarantia}"
                    };

                    _repositorio.AgregarEquipo(equipo);

                    _repositorio.AgregarAuditoria(auditoria);
                    MessageBox.Show($"Se agrego exitosamente el equipo: {equipo.Description}");
                    LimpiarCampos();
                    DeshabilitarCampos(false);
                    this.Dispose();
                    var listarPerifericos = new ListarPerifericosVista();
                    listarPerifericos.MdiParent = VistaPrincipal.ActiveForm;
                    listarPerifericos.Show();

                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos para continuar");
                }

            }
            else if (rbPeriferico.Checked)
            {
                //Periferico

                if (CheckearCampos())
                {
                    var periferico = new Periferico()
                    {
                        NumeroDeSerie = txtNserie.Text,
                        Descripcion = txtDescripcion.Text,
                        Marca = txtMarca.Text,
                        Modelo = txtModelo.Text,
                        FechaVencimientoGarantia = dtpFechaVencimiento.Value,
                        Proveedor = cbProveedor.SelectedItem as Proveedor,
                        FechaAlta = DateTime.Now
                    };

                    var auditoria = new Auditoria()
                    {
                        Entidad = "Alta de Periferico",
                        FechaAlta = DateTime.Now,
                        Datos = $"{periferico.Descripcion}-{periferico.FechaVencimientoGarantia}"
                    };

                    _repositorio.AgregarAuditoria(auditoria);


                    _repositorio.AgregarPeriferico(periferico);
                    MessageBox.Show($"Se agrego exitosamente el equipo: {periferico.Descripcion}");
                    LimpiarCampos();
                    DeshabilitarCampos(false);

                    this.Dispose();

                    var listarPerifericos = new ListarPerifericosVista();
                    listarPerifericos.MdiParent = VistaPrincipal.ActiveForm;
                    listarPerifericos.Show();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos para continuar");
                }
            }
            else
            {
                //mensaje 
                MessageBox.Show("Debe seleccionar el tipo para continuar :D");
                
            }
        }

        private void LimpiarCampos()
        {
            string bandera = "";
            rbEquipo.Checked = false;
            rbPeriferico.Checked = false;
            txtNserie.Text = bandera;
            txtDescripcion.Text = bandera;
            txtMarca.Text = bandera;
            txtModelo.Text = bandera;
            dtpFechaVencimiento.Value = DateTime.Now;
            cbProveedor.SelectedIndex = -1;
            cbDepartamentos.SelectedIndex = -1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rbPeriferico.Checked)
            {
                _perifericoUpdate = new Periferico()
                {
                    Id = _codigo,
                    Descripcion = txtDescripcion.Text,
                    NumeroDeSerie = txtNserie.Text,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    FechaAlta = DateTime.Now,
                    FechaVencimientoGarantia = dtpFechaVencimiento.Value,
                    Proveedor = cbProveedor.SelectedItem as Proveedor
                };

                _repositorio.ModificarPeriferico(_codigo, _perifericoUpdate);

                var auditoria = new Auditoria()
                {
                    Entidad = "Modificacion de Periferico",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se modifico el periferico: {_perifericoUpdate.Descripcion}"
                };

                _repositorio.AgregarAuditoria(auditoria);




                MessageBox.Show("Se actualizo el registro con exito");
                this.Dispose();
                var listaPerifericos= new ListarPerifericosVista();
                listaPerifericos.MdiParent = VistaPrincipal.ActiveForm;
                listaPerifericos.Show();


            }
            else
            {
                _equipoUpdate = new Equipo()
                {
                    Id = _codigo,
                    Description = txtDescripcion.Text,
                    SerielNumber = txtNserie.Text,
                    Marca = txtMarca.Text,
                    Model = txtModelo.Text,
                    FechaAlta = DateTime.Now,
                    FechaVencimientoGarantia = dtpFechaVencimiento.Value,
                    Proveedor = cbProveedor.SelectedItem as Proveedor,
                    Departamento = cbDepartamentos.SelectedItem as Departamento
                };

                _repositorio.ModificarEquipo(_codigo, _equipoUpdate);


                var auditoria = new Auditoria()
                {
                    Entidad = "Modificacion de Equipo",
                    FechaAlta = DateTime.Now,
                    Datos = $"Se modifico el equipo: {_equipoUpdate.Description}"
                };

                _repositorio.AgregarAuditoria(auditoria);


                MessageBox.Show("Se actualizo el registro con exito");
                this.Dispose();

                var listaEquipos = new ListarVista();
                listaEquipos.MdiParent = VistaPrincipal.ActiveForm;
                listaEquipos.Show();



            }




        }
    }
}
