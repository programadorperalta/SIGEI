
namespace SIGEI.Vista
{
    partial class EquipoPerifericoVista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgPerifericosAuxiliar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPerifericos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaAlta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPerifericos = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerifericosAuxiliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerifericos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerifericos)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(418, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(164, 17);
            this.tituloLabel.TabIndex = 7;
            this.tituloLabel.Text = "EQUIPO-PERIFERICO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgPerifericosAuxiliar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgPerifericos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.descripcionLabel);
            this.panel1.Controls.Add(this.confirmarBoton);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtNSerie);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Location = new System.Drawing.Point(29, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 408);
            this.panel1.TabIndex = 6;
            // 
            // dgPerifericosAuxiliar
            // 
            this.dgPerifericosAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerifericosAuxiliar.Location = new System.Drawing.Point(491, 161);
            this.dgPerifericosAuxiliar.Name = "dgPerifericosAuxiliar";
            this.dgPerifericosAuxiliar.Size = new System.Drawing.Size(444, 150);
            this.dgPerifericosAuxiliar.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "PERIFERICOS ACTUALES";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(459, 204);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 28);
            this.button3.TabIndex = 31;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "PERIFERICOS";
            // 
            // dgPerifericos
            // 
            this.dgPerifericos.AllowUserToOrderColumns = true;
            this.dgPerifericos.AutoGenerateColumns = false;
            this.dgPerifericos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPerifericos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.numeroDeSerieDataGridViewTextBoxColumn,
            this.fechaAltaDataGridViewTextBoxColumn,
            this.fechaVencimientoGarantiaDataGridViewTextBoxColumn});
            this.dgPerifericos.DataSource = this.bsPerifericos;
            this.dgPerifericos.Location = new System.Drawing.Point(3, 161);
            this.dgPerifericos.Name = "dgPerifericos";
            this.dgPerifericos.Size = new System.Drawing.Size(444, 150);
            this.dgPerifericos.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fecha de alta:";
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaAlta.Location = new System.Drawing.Point(572, 56);
            this.txtFechaAlta.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.ReadOnly = true;
            this.txtFechaAlta.Size = new System.Drawing.Size(346, 20);
            this.txtFechaAlta.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(574, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 27;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(757, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(16, 63);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(66, 13);
            this.descripcionLabel.TabIndex = 15;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(862, 364);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 32);
            this.confirmarBoton.TabIndex = 20;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(125, 56);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(320, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtNSerie
            // 
            this.txtNSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNSerie.Location = new System.Drawing.Point(125, 32);
            this.txtNSerie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(428, 20);
            this.txtNSerie.TabIndex = 11;
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(16, 35);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(62, 13);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "Nº de serie:";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
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
            // bsPerifericos
            // 
            this.bsPerifericos.DataSource = typeof(SIGEI.Periferico);
            // 
            // EquipoPerifericoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 515);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.panel1);
            this.Name = "EquipoPerifericoVista";
            this.Text = "EquipoPerifericoVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerifericosAuxiliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerifericos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerifericos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgPerifericosAuxiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPerifericos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaAlta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.BindingSource bsPerifericos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoGarantiaDataGridViewTextBoxColumn;
    }
}