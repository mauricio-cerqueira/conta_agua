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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CadastroNome = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CadastroCpf = new System.Windows.Forms.Label();
            this.CadastroEndereco = new System.Windows.Forms.Label();
            this.CadastroEmail = new System.Windows.Forms.Label();
            this.CadastroMedidor = new System.Windows.Forms.Label();
            this.buttonCadastrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 200);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(275, 20);
            this.textBox4.TabIndex = 3;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 459);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 5;
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
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.CadastroNome);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label CadastroNome;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label CadastroCpf;
        private System.Windows.Forms.Label CadastroEndereco;
        private System.Windows.Forms.Label CadastroEmail;
        private System.Windows.Forms.Label CadastroMedidor;
        private System.Windows.Forms.Button buttonCadastrarUsuario;
    }
}