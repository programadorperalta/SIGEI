
namespace SIGEI.Vista
{
    partial class ListarUsuariosVissta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarUsuariosVissta));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BusquedaLabel = new System.Windows.Forms.ToolStripLabel();
            this.BusquedaText = new System.Windows.Forms.ToolStripTextBox();
            this.lista = new System.Windows.Forms.DataGridView();
            this.sIGEIDBDataSet6 = new SIGEI.SIGEIDBDataSet6();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new SIGEI.SIGEIDBDataSet6TableAdapters.UsuarioTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarButton,
            this.toolStripSeparator1,
            this.ModificarButton,
            this.toolStripSeparator2,
            this.EliminarButton,
            this.toolStripSeparator3,
            this.BusquedaLabel,
            this.BusquedaText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 34);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarButton
            // 
            this.AgregarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(24, 31);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // ModificarButton
            // 
            this.ModificarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModificarButton.Image = ((System.Drawing.Image)(resources.GetObject("ModificarButton.Image")));
            this.ModificarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(24, 31);
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // EliminarButton
            // 
            this.EliminarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(24, 31);
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // BusquedaLabel
            // 
            this.BusquedaLabel.Name = "BusquedaLabel";
            this.BusquedaLabel.Size = new System.Drawing.Size(48, 31);
            this.BusquedaLabel.Text = "Buscar: ";
            // 
            // BusquedaText
            // 
            this.BusquedaText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BusquedaText.Name = "BusquedaText";
            this.BusquedaText.Size = new System.Drawing.Size(338, 34);
            // 
            // lista
            // 
            this.lista.AllowUserToOrderColumns = true;
            this.lista.AutoGenerateColumns = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nickDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.permisoDataGridViewTextBoxColumn,
            this.empleadoIdDataGridViewTextBoxColumn});
            this.lista.DataSource = this.usuarioBindingSource;
            this.lista.Location = new System.Drawing.Point(2, 37);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1030, 459);
            this.lista.TabIndex = 8;
            // 
            // sIGEIDBDataSet6
            // 
            this.sIGEIDBDataSet6.DataSetName = "SIGEIDBDataSet6";
            this.sIGEIDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.sIGEIDBDataSet6;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nickDataGridViewTextBoxColumn
            // 
            this.nickDataGridViewTextBoxColumn.DataPropertyName = "Nick";
            this.nickDataGridViewTextBoxColumn.HeaderText = "Nick";
            this.nickDataGridViewTextBoxColumn.Name = "nickDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // permisoDataGridViewTextBoxColumn
            // 
            this.permisoDataGridViewTextBoxColumn.DataPropertyName = "Permiso";
            this.permisoDataGridViewTextBoxColumn.HeaderText = "Permiso";
            this.permisoDataGridViewTextBoxColumn.Name = "permisoDataGridViewTextBoxColumn";
            // 
            // empleadoIdDataGridViewTextBoxColumn
            // 
            this.empleadoIdDataGridViewTextBoxColumn.DataPropertyName = "Empleado_Id";
            this.empleadoIdDataGridViewTextBoxColumn.HeaderText = "Empleado_Id";
            this.empleadoIdDataGridViewTextBoxColumn.Name = "empleadoIdDataGridViewTextBoxColumn";
            // 
            // ListarUsuariosVissta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 477);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListarUsuariosVissta";
            this.Text = "ListarUsuariosVissta";
            this.Load += new System.EventHandler(this.ListarUsuariosVissta_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel BusquedaLabel;
        private System.Windows.Forms.ToolStripTextBox BusquedaText;
        private System.Windows.Forms.DataGridView lista;
        private SIGEIDBDataSet6 sIGEIDBDataSet6;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private SIGEIDBDataSet6TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoIdDataGridViewTextBoxColumn;
    }
}