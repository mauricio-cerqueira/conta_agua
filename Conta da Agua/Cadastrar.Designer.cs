namespace Conta_da_Agua
{
    partial class Cadastrar
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.CadastroNome = new System.Windows.Forms.Label();
            this.textBoxMedidor = new System.Windows.Forms.TextBox();
            this.CadastroCpf = new System.Windows.Forms.Label();
            this.CadastroEndereco = new System.Windows.Forms.Label();
            this.CadastroEmail = new System.Windows.Forms.Label();
            this.CadastroMedidor = new System.Windows.Forms.Label();
            this.buttonCadastrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 114);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(275, 20);
            this.textBoxNome.TabIndex = 0;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(12, 200);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(275, 20);
            this.textBoxCpf.TabIndex = 1;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 283);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(275, 20);
            this.textBoxEndereco.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 368);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(275, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // CadastroNome
            // 
            this.CadastroNome.AutoSize = true;
            this.CadastroNome.Location = new System.Drawing.Point(13, 95);
            this.CadastroNome.Name = "CadastroNome";
            this.CadastroNome.Size = new System.Drawing.Size(35, 13);
            this.CadastroNome.TabIndex = 4;
            this.CadastroNome.Text = "Nome";
            // 
            // textBoxMedidor
            // 
            this.textBoxMedidor.Location = new System.Drawing.Point(12, 459);
            this.textBoxMedidor.Name = "textBoxMedidor";
            this.textBoxMedidor.Size = new System.Drawing.Size(275, 20);
            this.textBoxMedidor.TabIndex = 5;
            // 
            // CadastroCpf
            // 
            this.CadastroCpf.AutoSize = true;
            this.CadastroCpf.Location = new System.Drawing.Point(13, 184);
            this.CadastroCpf.Name = "CadastroCpf";
            this.CadastroCpf.Size = new System.Drawing.Size(27, 13);
            this.CadastroCpf.TabIndex = 6;
            this.CadastroCpf.Text = "CPF";
            // 
            // CadastroEndereco
            // 
            this.CadastroEndereco.AutoSize = true;
            this.CadastroEndereco.Location = new System.Drawing.Point(13, 267);
            this.CadastroEndereco.Name = "CadastroEndereco";
            this.CadastroEndereco.Size = new System.Drawing.Size(53, 13);
            this.CadastroEndereco.TabIndex = 7;
            this.CadastroEndereco.Text = "Endereço";
            // 
            // CadastroEmail
            // 
            this.CadastroEmail.AutoSize = true;
            this.CadastroEmail.Location = new System.Drawing.Point(13, 352);
            this.CadastroEmail.Name = "CadastroEmail";
            this.CadastroEmail.Size = new System.Drawing.Size(32, 13);
            this.CadastroEmail.TabIndex = 8;
            this.CadastroEmail.Text = "Email";
            // 
            // CadastroMedidor
            // 
            this.CadastroMedidor.AutoSize = true;
            this.CadastroMedidor.Location = new System.Drawing.Point(13, 443);
            this.CadastroMedidor.Name = "CadastroMedidor";
            this.CadastroMedidor.Size = new System.Drawing.Size(60, 13);
            this.CadastroMedidor.TabIndex = 9;
            this.CadastroMedidor.Text = "Nº Medidor";
            // 
            // buttonCadastrarUsuario
            // 
            this.buttonCadastrarUsuario.Location = new System.Drawing.Point(260, 521);
            this.buttonCadastrarUsuario.Name = "buttonCadastrarUsuario";
            this.buttonCadastrarUsuario.Size = new System.Drawing.Size(135, 59);
            this.buttonCadastrarUsuario.TabIndex = 10;
            this.buttonCadastrarUsuario.Text = "Cadastrar";
            this.buttonCadastrarUsuario.UseVisualStyleBackColor = true;
            this.buttonCadastrarUsuario.Click += new System.EventHandler(this.buttonCadastrarUsuario_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 592);
            this.Controls.Add(this.buttonCadastrarUsuario);
            this.Controls.Add(this.CadastroMedidor);
            this.Controls.Add(this.CadastroEmail);
            this.Controls.Add(this.CadastroEndereco);
            this.Controls.Add(this.CadastroCpf);
            this.Controls.Add(this.textBoxMedidor);
            this.Controls.Add(this.CadastroNome);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label CadastroNome;
        private System.Windows.Forms.TextBox textBoxMedidor;
        private System.Windows.Forms.Label CadastroCpf;
        private System.Windows.Forms.Label CadastroEndereco;
        private System.Windows.Forms.Label CadastroEmail;
        private System.Windows.Forms.Label CadastroMedidor;
        private System.Windows.Forms.Button buttonCadastrarUsuario;
    }
}