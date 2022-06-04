namespace Conta_da_Agua
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.labelCadastro = new System.Windows.Forms.Label();
            this.textBoxMedidor = new System.Windows.Forms.TextBox();
            this.labelMedidor = new System.Windows.Forms.Label();
            this.buttonCodigoMedidor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiaNota = new System.Windows.Forms.TextBox();
            this.textBoxMesNota = new System.Windows.Forms.TextBox();
            this.textBoxAnoNota = new System.Windows.Forms.TextBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelMes = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.BackColor = System.Drawing.Color.White;
            this.buttonCadastro.Location = new System.Drawing.Point(14, 476);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(112, 24);
            this.buttonCadastro.TabIndex = 0;
            this.buttonCadastro.Text = "Criar";
            this.buttonCadastro.UseVisualStyleBackColor = false;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // labelCadastro
            // 
            this.labelCadastro.AutoSize = true;
            this.labelCadastro.Location = new System.Drawing.Point(31, 460);
            this.labelCadastro.Name = "labelCadastro";
            this.labelCadastro.Size = new System.Drawing.Size(72, 13);
            this.labelCadastro.TabIndex = 1;
            this.labelCadastro.Text = "Novo Usuário";
            // 
            // textBoxMedidor
            // 
            this.textBoxMedidor.Location = new System.Drawing.Point(12, 60);
            this.textBoxMedidor.Name = "textBoxMedidor";
            this.textBoxMedidor.Size = new System.Drawing.Size(136, 20);
            this.textBoxMedidor.TabIndex = 2;
            this.textBoxMedidor.Text = "2";
            // 
            // labelMedidor
            // 
            this.labelMedidor.AutoSize = true;
            this.labelMedidor.Location = new System.Drawing.Point(31, 41);
            this.labelMedidor.Name = "labelMedidor";
            this.labelMedidor.Size = new System.Drawing.Size(95, 13);
            this.labelMedidor.TabIndex = 3;
            this.labelMedidor.Text = "Código do medidor";
            // 
            // buttonCodigoMedidor
            // 
            this.buttonCodigoMedidor.BackColor = System.Drawing.Color.White;
            this.buttonCodigoMedidor.Location = new System.Drawing.Point(12, 102);
            this.buttonCodigoMedidor.Name = "buttonCodigoMedidor";
            this.buttonCodigoMedidor.Size = new System.Drawing.Size(136, 48);
            this.buttonCodigoMedidor.TabIndex = 4;
            this.buttonCodigoMedidor.Text = "Gerar";
            this.buttonCodigoMedidor.UseVisualStyleBackColor = false;
            this.buttonCodigoMedidor.Click += new System.EventHandler(this.buttonCodigoMedidor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Consumo m²";
            // 
            // textBoxDiaNota
            // 
            this.textBoxDiaNota.Location = new System.Drawing.Point(165, 102);
            this.textBoxDiaNota.Name = "textBoxDiaNota";
            this.textBoxDiaNota.Size = new System.Drawing.Size(32, 20);
            this.textBoxDiaNota.TabIndex = 7;
            // 
            // textBoxMesNota
            // 
            this.textBoxMesNota.Location = new System.Drawing.Point(203, 102);
            this.textBoxMesNota.Name = "textBoxMesNota";
            this.textBoxMesNota.Size = new System.Drawing.Size(32, 20);
            this.textBoxMesNota.TabIndex = 8;
            // 
            // textBoxAnoNota
            // 
            this.textBoxAnoNota.Location = new System.Drawing.Point(241, 102);
            this.textBoxAnoNota.Name = "textBoxAnoNota";
            this.textBoxAnoNota.Size = new System.Drawing.Size(63, 20);
            this.textBoxAnoNota.TabIndex = 9;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(162, 86);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(23, 13);
            this.labelDia.TabIndex = 10;
            this.labelDia.Text = "Dia";
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Location = new System.Drawing.Point(200, 86);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(27, 13);
            this.labelMes.TabIndex = 11;
            this.labelMes.Text = "Mes";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(241, 86);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 12;
            this.labelAno.Text = "Ano";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(321, 512);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.textBoxAnoNota);
            this.Controls.Add(this.textBoxMesNota);
            this.Controls.Add(this.textBoxDiaNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCodigoMedidor);
            this.Controls.Add(this.labelMedidor);
            this.Controls.Add(this.textBoxMedidor);
            this.Controls.Add(this.labelCadastro);
            this.Controls.Add(this.buttonCadastro);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Label labelCadastro;
        private System.Windows.Forms.TextBox textBoxMedidor;
        private System.Windows.Forms.Label labelMedidor;
        private System.Windows.Forms.Button buttonCodigoMedidor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDiaNota;
        private System.Windows.Forms.TextBox textBoxMesNota;
        private System.Windows.Forms.TextBox textBoxAnoNota;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.Label labelAno;
    }
}

