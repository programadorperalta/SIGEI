
namespace SIGEI.Vista
{
    partial class AgregarEquipoVista
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPeriferico = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbEquipo = new System.Windows.Forms.RadioButton();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNserie = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 435);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Proveedor:";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(581, 450);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 22);
            this.button2.TabIndex = 47;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Garantia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbPeriferico
            // 
            this.rbPeriferico.AutoSize = true;
            this.rbPeriferico.Location = new System.Drawing.Point(189, 96);
            this.rbPeriferico.Name = "rbPeriferico";
            this.rbPeriferico.Size = new System.Drawing.Size(69, 17);
            this.rbPeriferico.TabIndex = 43;
            this.rbPeriferico.TabStop = true;
            this.rbPeriferico.Text = "Periferico";
            this.rbPeriferico.UseVisualStyleBackColor = true;
            this.rbPeriferico.CheckedChanged += new System.EventHandler(this.rbPeriferico_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nuevo:";
            // 
            // rbEquipo
            // 
            this.rbEquipo.AutoSize = true;
            this.rbEquipo.Location = new System.Drawing.Point(189, 73);
            this.rbEquipo.Name = "rbEquipo";
            this.rbEquipo.Size = new System.Drawing.Size(58, 17);
            this.rbEquipo.TabIndex = 41;
            this.rbEquipo.TabStop = true;
            this.rbEquipo.Text = "Equipo";
            this.rbEquipo.UseVisualStyleBackColor = true;
            this.rbEquipo.CheckedChanged += new System.EventHandler(this.rbEquipo_CheckedChanged);
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(683, 450);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 22);
            this.confirmarBoton.TabIndex = 37;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // ivaLabel
            // 
            this.ivaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaLabel.AutoSize = true;
            this.ivaLabel.Location = new System.Drawing.Point(107, 228);
            this.ivaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(45, 13);
            this.ivaLabel.TabIndex = 40;
            this.ivaLabel.Text = "Modelo:";
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(106, 203);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(40, 13);
            this.baseLabel.TabIndex = 39;
            this.baseLabel.Text = "Marca:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(106, 181);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(66, 13);
            this.descripcionLabel.TabIndex = 38;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Location = new System.Drawing.Point(189, 225);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(365, 20);
            this.txtModelo.TabIndex = 36;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Location = new System.Drawing.Point(189, 201);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(365, 20);
            this.txtMarca.TabIndex = 35;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(189, 179);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(365, 20);
            this.txtDescripcion.TabIndex = 33;
            // 
            // txtNserie
            // 
            this.txtNserie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNserie.Location = new System.Drawing.Point(189, 155);
            this.txtNserie.Margin = new System.Windows.Forms.Padding(2);
            this.txtNserie.Name = "txtNserie";
            this.txtNserie.Size = new System.Drawing.Size(365, 20);
            this.txtNserie.TabIndex = 32;
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(106, 158);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(49, 13);
            this.codigoLabel.TabIndex = 34;
            this.codigoLabel.Text = "Nº Serie:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(278, 28);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(233, 17);
            this.tituloLabel.TabIndex = 31;
            this.tituloLabel.Text = "ALTA DE EQUIPO/PERIFERICO";
            // 
            // cbProveedor
            // 
            this.cbProveedor.DisplayMember = "Cuit";
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(189, 427);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(162, 21);
            this.cbProveedor.TabIndex = 51;
            this.cbProveedor.ValueMember = "Cuit";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Fecha de vencimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.dtpFechaVencimiento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(110, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 69);
            this.panel1.TabIndex = 58;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(122, 26);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 60;
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.DisplayMember = "Cuit";
            this.cbDepartamentos.FormattingEnabled = true;
            this.cbDepartamentos.Location = new System.Drawing.Point(189, 387);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(162, 21);
            this.cbDepartamentos.TabIndex = 60;
            this.cbDepartamentos.ValueMember = "Cuit";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Departamentos:";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(481, 450);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 22);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // AgregarEquipoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 493);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cbDepartamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rbPeriferico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEquipo);
            this.Controls.Add(this.confirmarBoton);
            this.Controls.Add(this.ivaLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNserie);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.txtMarca);
            this.Name = "AgregarEquipoVista";
            this.Text = "AgregarEquipoVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPeriferico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbEquipo;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNserie;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.ComboBox cbDepartamentos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificar;
    }
}