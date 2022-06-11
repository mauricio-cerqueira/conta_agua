namespace Conta_da_Agua
{
    partial class Resultado
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
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonVolta = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(13, 63);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(361, 453);
            this.textBoxResultado.TabIndex = 0;
            this.textBoxResultado.TextChanged += new System.EventHandler(this.textBoxResultado_TextChanged);
            // 
            // buttonVolta
            // 
            this.buttonVolta.Location = new System.Drawing.Point(13, 585);
            this.buttonVolta.Name = "buttonVolta";
            this.buttonVolta.Size = new System.Drawing.Size(169, 43);
            this.buttonVolta.TabIndex = 1;
            this.buttonVolta.Text = "Retornar";
            this.buttonVolta.UseVisualStyleBackColor = true;
            this.buttonVolta.Click += new System.EventHandler(this.buttonVolta_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Location = new System.Drawing.Point(205, 585);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(169, 43);
            this.buttonEmail.TabIndex = 2;
            this.buttonEmail.Text = "Enviar";
            this.buttonEmail.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 640);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.buttonVolta);
            this.Controls.Add(this.textBoxResultado);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonVolta;
        private System.Windows.Forms.Button buttonEmail;
    }
}