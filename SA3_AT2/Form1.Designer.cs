namespace SA3_AT2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Estados = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Cidades = new System.Windows.Forms.ComboBox();
            this.comboBox_Municipios = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estados: ";
            // 
            // comboBox_Estados
            // 
            this.comboBox_Estados.FormattingEnabled = true;
            this.comboBox_Estados.Location = new System.Drawing.Point(53, 13);
            this.comboBox_Estados.Name = "comboBox_Estados";
            this.comboBox_Estados.Size = new System.Drawing.Size(148, 21);
            this.comboBox_Estados.TabIndex = 1;
            this.comboBox_Estados.SelectedIndexChanged += new System.EventHandler(this.comboBox_Estados_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Cidades
            // 
            this.comboBox_Cidades.FormattingEnabled = true;
            this.comboBox_Cidades.Location = new System.Drawing.Point(207, 13);
            this.comboBox_Cidades.Name = "comboBox_Cidades";
            this.comboBox_Cidades.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Cidades.TabIndex = 3;
            this.comboBox_Cidades.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cidades_SelectedIndexChanged);
            // 
            // comboBox_Municipios
            // 
            this.comboBox_Municipios.FormattingEnabled = true;
            this.comboBox_Municipios.Location = new System.Drawing.Point(335, 12);
            this.comboBox_Municipios.Name = "comboBox_Municipios";
            this.comboBox_Municipios.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Municipios.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 170);
            this.Controls.Add(this.comboBox_Municipios);
            this.Controls.Add(this.comboBox_Cidades);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Estados);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Estados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Estados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Cidades;
        private System.Windows.Forms.ComboBox comboBox_Municipios;
    }
}

