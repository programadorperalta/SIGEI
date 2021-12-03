
namespace SIGEI.Vista
{
    partial class DepartamentoVista
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
            this.codigoLabel = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(171, 27);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(235, 17);
            this.tituloLabel.TabIndex = 9;
            this.tituloLabel.Text = "GESTIONAR DEPARTAMENTO ";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(14, 28);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(47, 13);
            this.codigoLabel.TabIndex = 13;
            this.codigoLabel.Text = "Nombre:";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreDepartamento.Location = new System.Drawing.Point(65, 21);
            this.txtNombreDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(188, 20);
            this.txtNombreDepartamento.TabIndex = 12;
            this.txtNombreDepartamento.TextChanged += new System.EventHandler(this.txtNombreDepartamento_TextChanged);
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(427, 54);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 21);
            this.confirmarBoton.TabIndex = 20;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(350, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 22);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.confirmarBoton);
            this.panel1.Controls.Add(this.txtNombreDepartamento);
            this.panel1.Controls.Add(this.codigoLabel);
            this.panel1.Location = new System.Drawing.Point(29, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 77);
            this.panel1.TabIndex = 10;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(17, 54);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 21);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // DepartamentoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloLabel);
            this.Name = "DepartamentoVista";
            this.Text = "DepartamentoVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModificar;
    }
}