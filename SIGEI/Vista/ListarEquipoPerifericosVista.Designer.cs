
namespace SIGEI.Vista
{
    partial class ListarEquipoPerifericosVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarEquipoPerifericosVista));
            this.lista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sIGEIDBDataSet7 = new SIGEI.SIGEIDBDataSet7();
            this.equipoPerifericoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipoPerifericoTableAdapter = new SIGEI.SIGEIDBDataSet7TableAdapters.EquipoPerifericoTableAdapter();
            this.BusquedaText = new System.Windows.Forms.ToolStripTextBox();
            this.BusquedaLabel = new System.Windows.Forms.ToolStripLabel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perifericoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoPerifericoBindingSource)).BeginInit();
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
            this.fechaAltaDataGridViewTextBoxColumn,
            this.equipoIdDataGridViewTextBoxColumn,
            this.perifericoIdDataGridViewTextBoxColumn});
            this.lista.DataSource = this.equipoPerifericoBindingSource;
            this.lista.Location = new System.Drawing.Point(2, 37);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1030, 419);
            this.lista.TabIndex = 9;
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
            this.EliminarButton,
            this.toolStripSeparator3,
            this.BusquedaLabel,
            this.BusquedaText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 38);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarButton
            // 
            this.AgregarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(24, 35);
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // EliminarButton
            // 
            this.EliminarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(24, 35);
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // sIGEIDBDataSet7
            // 
            this.sIGEIDBDataSet7.DataSetName = "SIGEIDBDataSet7";
            this.sIGEIDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipoPerifericoBindingSource
            // 
            this.equipoPerifericoBindingSource.DataMember = "EquipoPeriferico";
            this.equipoPerifericoBindingSource.DataSource = this.sIGEIDBDataSet7;
            // 
            // equipoPerifericoTableAdapter
            // 
            this.equipoPerifericoTableAdapter.ClearBeforeFill = true;
            // 
            // BusquedaText
            // 
            this.BusquedaText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BusquedaText.Name = "BusquedaText";
            this.BusquedaText.Size = new System.Drawing.Size(338, 38);
            // 
            // BusquedaLabel
            // 
            this.BusquedaLabel.Name = "BusquedaLabel";
            this.BusquedaLabel.Size = new System.Drawing.Size(48, 35);
            this.BusquedaLabel.Text = "Buscar: ";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // equipoIdDataGridViewTextBoxColumn
            // 
            this.equipoIdDataGridViewTextBoxColumn.DataPropertyName = "Equipo_Id";
            this.equipoIdDataGridViewTextBoxColumn.HeaderText = "Equipo_Id";
            this.equipoIdDataGridViewTextBoxColumn.Name = "equipoIdDataGridViewTextBoxColumn";
            // 
            // perifericoIdDataGridViewTextBoxColumn
            // 
            this.perifericoIdDataGridViewTextBoxColumn.DataPropertyName = "Periferico_Id";
            this.perifericoIdDataGridViewTextBoxColumn.HeaderText = "Periferico_Id";
            this.perifericoIdDataGridViewTextBoxColumn.Name = "perifericoIdDataGridViewTextBoxColumn";
            // 
            // ListarEquipoPerifericosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 478);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListarEquipoPerifericosVista";
            this.Text = "ListarEquipoPerifericosVista";
            this.Load += new System.EventHandler(this.ListarEquipoPerifericosVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipoPerifericoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton EliminarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private SIGEIDBDataSet7 sIGEIDBDataSet7;
        private System.Windows.Forms.BindingSource equipoPerifericoBindingSource;
        private SIGEIDBDataSet7TableAdapters.EquipoPerifericoTableAdapter equipoPerifericoTableAdapter;
        private System.Windows.Forms.ToolStripLabel BusquedaLabel;
        private System.Windows.Forms.ToolStripTextBox BusquedaText;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perifericoIdDataGridViewTextBoxColumn;
    }
}