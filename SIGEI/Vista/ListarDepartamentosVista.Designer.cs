
namespace SIGEI.Vista
{
    partial class ListarDepartamentosVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarDepartamentosVista));
            this.lista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ModificarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EliminarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sIGEIDBDataSet5 = new SIGEI.SIGEIDBDataSet5();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new SIGEI.SIGEIDBDataSet5TableAdapters.DepartamentoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusquedaLabel = new System.Windows.Forms.ToolStripLabel();
            this.BusquedaText = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
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
            this.nombreDataGridViewTextBoxColumn});
            this.lista.DataSource = this.departamentoBindingSource;
            this.lista.Location = new System.Drawing.Point(0, 37);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1030, 445);
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
            this.ModificarButton,
            this.toolStripSeparator2,
            this.EliminarButton,
            this.toolStripSeparator3,
            this.BusquedaLabel,
            this.BusquedaText});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1023, 34);
            this.toolStrip1.TabIndex = 8;
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
            // sIGEIDBDataSet5
            // 
            this.sIGEIDBDataSet5.DataSetName = "SIGEIDBDataSet5";
            this.sIGEIDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.sIGEIDBDataSet5;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
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
            this.BusquedaText.TextChanged += new System.EventHandler(this.BusquedaText_TextChanged);
            // 
            // ListarDepartamentosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 481);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ListarDepartamentosVista";
            this.Text = "ListarDepartamentosVista";
            this.Load += new System.EventHandler(this.ListarDepartamentosVista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sIGEIDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
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
        private SIGEIDBDataSet5 sIGEIDBDataSet5;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private SIGEIDBDataSet5TableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel BusquedaLabel;
        private System.Windows.Forms.ToolStripTextBox BusquedaText;
    }
}