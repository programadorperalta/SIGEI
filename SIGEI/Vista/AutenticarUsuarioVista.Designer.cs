
namespace SIGEI.Vista
{
    partial class AutenticarUsuarioVista
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
            this.button1 = new System.Windows.Forms.Button();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(198, 35);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(179, 17);
            this.tituloLabel.TabIndex = 18;
            this.tituloLabel.Text = "AUTENTICAR USUARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.descripcionLabel);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Location = new System.Drawing.Point(120, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 135);
            this.panel1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.descripcionLabel.Size = new System.Drawing.Size(33, 13);
            this.descripcionLabel.TabIndex = 15;
            this.descripcionLabel.Text = "Pass:";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Contraseña", true));
            this.txtPass.Location = new System.Drawing.Point(125, 57);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 12;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Nick", true));
            this.txtUsername.Location = new System.Drawing.Point(125, 32);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(153, 20);
            this.txtUsername.TabIndex = 11;
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
            this.codigoLabel.Size = new System.Drawing.Size(32, 13);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "User:";
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataSource = typeof(SIGEI.Usuario);
            // 
            // AutenticarUsuarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 269);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.panel1);
            this.Name = "AutenticarUsuarioVista";
            this.Text = "AutenticarUsuarioVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.BindingSource bsUsuario;
    }
}