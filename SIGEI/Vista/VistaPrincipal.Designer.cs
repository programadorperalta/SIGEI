
namespace SIGEI.Vista
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialDeCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBienvenida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.perifericosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoPerifericoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.verHistorialDeCambiosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivosToolStripMenuItem.Text = "Archivo";
            // 
            // verHistorialDeCambiosToolStripMenuItem
            // 
            this.verHistorialDeCambiosToolStripMenuItem.Name = "verHistorialDeCambiosToolStripMenuItem";
            this.verHistorialDeCambiosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.verHistorialDeCambiosToolStripMenuItem.Text = "Ver Historial de Cambios";
            this.verHistorialDeCambiosToolStripMenuItem.Click += new System.EventHandler(this.verHistorialDeCambiosToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposToolStripMenuItem,
            this.perifericosToolStripMenuItem1,
            this.empleadosToolStripMenuItem1,
            this.proveedoresToolStripMenuItem1,
            this.departamentosToolStripMenuItem1,
            this.usuariosToolStripMenuItem1,
            this.equipoPerifericoToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listarToolStripMenuItem.Text = "Operaciones";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtBienvenida
            // 
            this.txtBienvenida.Location = new System.Drawing.Point(682, 4);
            this.txtBienvenida.Name = "txtBienvenida";
            this.txtBienvenida.ReadOnly = true;
            this.txtBienvenida.Size = new System.Drawing.Size(187, 20);
            this.txtBienvenida.TabIndex = 4;
            this.txtBienvenida.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenid@: ";
            // 
            // perifericosToolStripMenuItem1
            // 
            this.perifericosToolStripMenuItem1.Name = "perifericosToolStripMenuItem1";
            this.perifericosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.perifericosToolStripMenuItem1.Text = "Perifericos";
            this.perifericosToolStripMenuItem1.Click += new System.EventHandler(this.perifericosToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // departamentosToolStripMenuItem1
            // 
            this.departamentosToolStripMenuItem1.Name = "departamentosToolStripMenuItem1";
            this.departamentosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.departamentosToolStripMenuItem1.Text = "Departamentos";
            this.departamentosToolStripMenuItem1.Click += new System.EventHandler(this.departamentosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // equipoPerifericoToolStripMenuItem
            // 
            this.equipoPerifericoToolStripMenuItem.Name = "equipoPerifericoToolStripMenuItem";
            this.equipoPerifericoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equipoPerifericoToolStripMenuItem.Text = "Equipo-Periferico";
            this.equipoPerifericoToolStripMenuItem.Click += new System.EventHandler(this.equipoPerifericoToolStripMenuItem_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "VistaPrincipal";
            this.Text = "VistaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistorialDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perifericosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem equipoPerifericoToolStripMenuItem;
    }
}