namespace Conta_da_Agua
{
    partial class Login
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
            this.LoginNome = new System.Windows.Forms.TextBox();
            this.LoginSenha = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.ButtonEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginNome
            // 
            this.LoginNome.Location = new System.Drawing.Point(107, 227);
            this.LoginNome.Name = "LoginNome";
            this.LoginNome.Size = new System.Drawing.Size(301, 20);
            this.LoginNome.TabIndex = 0;
            // 
            // LoginSenha
            // 
            this.LoginSenha.Location = new System.Drawing.Point(107, 308);
            this.LoginSenha.Name = "LoginSenha";
            this.LoginSenha.Size = new System.Drawing.Size(301, 20);
            this.LoginSenha.TabIndex = 1;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(107, 208);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(110, 289);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            // 
            // ButtonEntrar
            // 
            this.ButtonEntrar.Location = new System.Drawing.Point(255, 355);
            this.ButtonEntrar.Name = "ButtonEntrar";
            this.ButtonEntrar.Size = new System.Drawing.Size(153, 59);
            this.ButtonEntrar.TabIndex = 4;
            this.ButtonEntrar.Text = "Entrar";
            this.ButtonEntrar.UseVisualStyleBackColor = true;
            this.ButtonEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(525, 527);
            this.Controls.Add(this.ButtonEntrar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.LoginSenha);
            this.Controls.Add(this.LoginNome);
            this.Name = "Login";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginNome;
        private System.Windows.Forms.TextBox LoginSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Button ButtonEntrar;
    }
}