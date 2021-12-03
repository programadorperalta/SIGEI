
namespace SIGEI.Vista
{
    partial class EmpleadoVista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbChekEquipo = new System.Windows.Forms.RadioButton();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDepartamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.baseLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.rbChekEquipo);
            this.panel1.Controls.Add(this.cbEquipos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbDepartamentos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLegajo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.baseLabel);
            this.panel1.Controls.Add(this.descripcionLabel);
            this.panel1.Controls.Add(this.confirmarBoton);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Location = new System.Drawing.Point(36, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 319);
            this.panel1.TabIndex = 14;
            // 
            // rbChekEquipo
            // 
            this.rbChekEquipo.AutoSize = true;
            this.rbChekEquipo.Location = new System.Drawing.Point(19, 191);
            this.rbChekEquipo.Name = "rbChekEquipo";
            this.rbChekEquipo.Size = new System.Drawing.Size(227, 17);
            this.rbChekEquipo.TabIndex = 33;
            this.rbChekEquipo.TabStop = true;
            this.rbChekEquipo.Text = "¿Desea agregarle un Equipo al Empleado?";
            this.rbChekEquipo.UseVisualStyleBackColor = true;
            this.rbChekEquipo.CheckedChanged += new System.EventHandler(this.rbChekEquipo_CheckedChanged);
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Items.AddRange(new object[] {
            ""});
            this.cbEquipos.Location = new System.Drawing.Point(125, 225);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(209, 21);
            this.cbEquipos.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Equipo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.DisplayMember = "Nombre";
            this.cbDepartamentos.FormattingEnabled = true;
            this.cbDepartamentos.Location = new System.Drawing.Point(125, 151);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(121, 21);
            this.cbDepartamentos.TabIndex = 26;
            this.cbDepartamentos.ValueMember = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Departamento:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLegajo.Location = new System.Drawing.Point(125, 117);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(554, 20);
            this.txtLegajo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Legajo:";
            // 
            // txtDNI
            // 
            this.txtDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDNI.Location = new System.Drawing.Point(125, 86);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(554, 20);
            this.txtDNI.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(551, 264);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(16, 93);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(29, 13);
            this.baseLabel.TabIndex = 16;
            this.baseLabel.Text = "DNI:";
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
            this.descripcionLabel.Size = new System.Drawing.Size(47, 13);
            this.descripcionLabel.TabIndex = 15;
            this.descripcionLabel.Text = "Apellido:";
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(653, 263);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 30);
            this.confirmarBoton.TabIndex = 20;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(125, 57);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(554, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(125, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(554, 20);
            this.txtNombre.TabIndex = 11;
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
            this.codigoLabel.Size = new System.Drawing.Size(47, 13);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "Nombre:";
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(372, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(92, 17);
            this.tituloLabel.TabIndex = 13;
            this.tituloLabel.Text = "EMPLEADO";
            this.tituloLabel.Click += new System.EventHandler(this.tituloLabel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(448, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 26);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // EmpleadoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(829, 373);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloLabel);
            this.Name = "EmpleadoVista";
            this.Text = "EmpleadoVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.RadioButton rbChekEquipo;
        private System.Windows.Forms.Button btnModificar;
    }
}