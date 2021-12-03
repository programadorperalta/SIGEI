
namespace SIGEI.Vista
{
    partial class ListarPerifericosVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarPerifericosVista));
            this.lista = new System.Windows.Forms.DataGridView();
            this.sIGEIDBDataSet1 = new SIGEI.SIGEIDBDataSet1();
            this.perifericoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perifericoTableAdapter = new SIGEI.SIGEIDBDataSet1TableAdapters.PerifericoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BusquedaLabel = new System.Windows.Forms.ToolStripLabel();
            this.BusquedaText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bsPeriferico = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perifericoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeriferico)).BeginInit();
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
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.numeroDeSerieDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn,
            this.Proveedor_Id});
            this.lista.DataSource = this.perifericoBindingSource;
            this.lista.Location = new System.Drawing.Point(0, 37);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1027, 415);
            this.lista.TabIndex = 5;
            // 
            // sIGEIDBDataSet1
            // 
            this.sIGEIDBDataSet1.DataSetName = "SIGEIDBDataSet1";
            this.sIGEIDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perifericoBindingSource
            // 
            this.perifericoBindingSource.DataMember = "Periferico";
            this.perifericoBindingSource.DataSource = this.sIGEIDBDataSet1;
            // 
            // perifericoTableAdapter
            // 
            this.perifericoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // numeroDeSerieDataGridViewTextBoxColumn
            // 
            this.numeroDeSerieDataGridViewTextBoxColumn.DataPropertyName = "NumeroDeSerie";
            this.numeroDeSerieDataGridViewTextBoxColumn.HeaderText = "NumeroDeSerie";
            this.numeroDeSerieDataGridViewTextBoxColumn.Name = "numeroDeSerieDataGridViewTextBoxColumn";
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
            // Proveedor_Id
            // 
            this.Proveedor_Id.DataPropertyName = "Proveedor_Id";
            this.Proveedor_Id.HeaderText = "Proveedor_Id";
            this.Proveedor_Id.Name = "Proveedor_Id";
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
            this.toolStrip1.Size = new System.Drawing.Size(1026, 34);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bsPeriferico
            // 
            this.bsPeriferico.DataSource = typeof(SIGEI.Periferico);
            // 
            // ListarPerifericosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 416);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListarPerifericosVista";
            this.Text = "ListarPerifericosVista";
            this.Load += new System.EventHandler(this.ListarPerifericosVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perifericoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPeriferico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.BindingSource bsPeriferico;
        private SIGEIDBDataSet1 sIGEIDBDataSet1;
        private System.Windows.Forms.BindingSource perifericoBindingSource;
        private SIGEIDBDataSet1TableAdapters.PerifericoTableAdapter perifericoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoGarantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor_Id;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ModificarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel BusquedaLabel;
        private System.Windows.Forms.ToolStripTextBox BusquedaText;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}