﻿using System;
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
    public partial class AutenticarUsuarioVista : Form
    {

        public AutenticarUsuarioVista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var inventario = new Inventario();
            var vistaPrincipal = new VistaPrincipal();

            string username = txtUsername.Text;
            string password = txtPass.Text;

            //if (inventario.ValidarUsuario(username,password))
            //{
            //    var usuario = inventario.BuscarUsuario(username, password); //obtengo el usuario con sus credenciales
            //    if (usuario!=null)
            //    {   
                    
            //        MessageBox.Show("Se ha iniciado la sesion con exito");
            //        vistaPrincipal.Visible = true;
            //        LimpiarCampos();
                    
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encuentra el usuario, Por favor intente nuevamente");
            //    }
            //}
          
        }

        public void LimpiarCampos()
        {
            txtPass.Text ="";
            txtUsername.Text ="";
        }

    }
}
