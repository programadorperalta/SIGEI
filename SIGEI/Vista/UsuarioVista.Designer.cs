
namespace SIGEI.Vista
{
    partial class UsuarioVista
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLegajoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPermisos = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.baseLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(361, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(77, 17);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "USUARIO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtLegajoEmpleado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbPermisos);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.baseLabel);
            this.panel1.Controls.Add(this.descripcionLabel);
            this.panel1.Controls.Add(this.confirmarBoton);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Location = new System.Drawing.Point(72, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 238);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(147, 35);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(192, 20);
            this.txtNombreEmpleado.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre del empleado:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(358, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(147, 11);
            this.txtLegajoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(192, 20);
            this.txtLegajoEmpleado.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Legajo del Empleado:";
            // 
            // cbPermisos
            // 
            this.cbPermisos.FormattingEnabled = true;
            this.cbPermisos.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista"});
            this.cbPermisos.Location = new System.Drawing.Point(84, 159);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(191, 21);
            this.cbPermisos.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(456, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 27);
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
            this.baseLabel.Location = new System.Drawing.Point(20, 162);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(52, 13);
            this.baseLabel.TabIndex = 16;
            this.baseLabel.Text = "Permisos:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(20, 133);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(64, 13);
            this.descripcionLabel.TabIndex = 15;
            this.descripcionLabel.Text = "Contraseña:";
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(571, 197);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 27);
            this.confirmarBoton.TabIndex = 20;
            this.confirmarBoton.Text = "Registrar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.Location = new System.Drawing.Point(84, 130);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(191, 20);
            this.txtContraseña.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(84, 99);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(191, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(20, 106);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(46, 13);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "Usuario:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(23, 197);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 27);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // UsuarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.panel1);
            this.Name = "UsuarioVista";
            this.Text = "UsuarioVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLegajoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.ComboBox cbPermisos;
        private System.Windows.Forms.Button btnModificar;
    }
}