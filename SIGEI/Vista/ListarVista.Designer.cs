
namespace SIGEI.Vista
{
    partial class ListarVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarVista));
            this.lista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BusquedaLabel = new System.Windows.Forms.ToolStripLabel();
            this.BusquedaText = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIGEIDBDataSet3 = new SIGEI.SIGEIDBDataSet3();
            this.equipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoTableAdapter = new SIGEI.SIGEIDBDataSet3TableAdapters.EquipoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serielNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.AllowUserToOrderColumns = true;
            this.lista.AutoGenerateColumns = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.serielNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn});
            this.lista.DataSource = this.equipoBindingSource;
            this.lista.Location = new System.Drawing.Point(0, 34);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1013, 415);
            this.lista.TabIndex = 3;
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
            this.toolStrip1.Size = new System.Drawing.Size(1013, 34);
            this.toolStrip1.TabIndex = 2;
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
            this.BusquedaText.Name = "BusquedaText";
            this.BusquedaText.Size = new System.Drawing.Size(338, 34);
            this.BusquedaText.Click += new System.EventHandler(this.BusquedaText_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 485;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 485;
            // 
            // sIGEIDBDataSet3
            // 
            this.sIGEIDBDataSet3.DataSetName = "SIGEIDBDataSet3";
            this.sIGEIDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoBindingSource
            // 
            this.equipoBindingSource.DataMember = "Equipo";
            this.equipoBindingSource.DataSource = this.sIGEIDBDataSet3;
            // 
            // equipoTableAdapter
            // 
            this.equipoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serielNumberDataGridViewTextBoxColumn
            // 
            this.serielNumberDataGridViewTextBoxColumn.DataPropertyName = "SerielNumber";
            this.serielNumberDataGridViewTextBoxColumn.HeaderText = "SerielNumber";
            this.serielNumberDataGridViewTextBoxColumn.Name = "serielNumberDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // fechaVencimientoGarantiaDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimientoGarantia";
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn.HeaderText = "FechaVencimientoGarantia";
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn.Name = "fechaVencimientoGarantiaDataGridViewTextBoxColumn";
            // 
            // ListarVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 450);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListarVista";
            this.Text = "ListarVista";
            this.Load += new System.EventHandler(this.ListarVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel BusquedaLabel;
        private System.Windows.Forms.ToolStripTextBox BusquedaText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private SIGEIDBDataSet3 sIGEIDBDataSet3;
        private System.Windows.Forms.BindingSource equipoBindingSource;
        private SIGEIDBDataSet3TableAdapters.EquipoTableAdapter equipoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serielNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoGarantiaDataGridViewTextBoxColumn;
    }
}