
namespace SIGEI.Vista
{
    partial class HistorialCambiosVista
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAuditoria = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(413, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(188, 17);
            this.tituloLabel.TabIndex = 19;
            this.tituloLabel.Text = "HISTORIAL DE CAMBIOS";
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.AutoGenerateColumns = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.entidadDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.datosDataGridViewTextBoxColumn});
            this.lista.DataSource = this.bsAuditoria;
            this.lista.Location = new System.Drawing.Point(0, 71);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(1024, 320);
            this.lista.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(59, 38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(265, 20);
            this.txtFiltro.TabIndex = 22;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtro:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // entidadDataGridViewTextBoxColumn
            // 
            this.entidadDataGridViewTextBoxColumn.DataPropertyName = "Entidad";
            this.entidadDataGridViewTextBoxColumn.HeaderText = "Entidad";
            this.entidadDataGridViewTextBoxColumn.Name = "entidadDataGridViewTextBoxColumn";
            // 
            // fechaAltaDataGridViewTextBoxColumn
            // 
            this.fechaAltaDataGridViewTextBoxColumn.DataPropertyName = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.HeaderText = "FechaAlta";
            this.fechaAltaDataGridViewTextBoxColumn.Name = "fechaAltaDataGridViewTextBoxColumn";
            // 
            // datosDataGridViewTextBoxColumn
            // 
            this.datosDataGridViewTextBoxColumn.DataPropertyName = "Datos";
            this.datosDataGridViewTextBoxColumn.HeaderText = "Datos";
            this.datosDataGridViewTextBoxColumn.Name = "datosDataGridViewTextBoxColumn";
            // 
            // bsAuditoria
            // 
            this.bsAuditoria.DataSource = typeof(SIGEI.Auditoria);
            // 
            // HistorialCambiosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.tituloLabel);
            this.Name = "HistorialCambiosVista";
            this.Text = "HistorialCambiosVista";
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsAuditoria;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
    }
}