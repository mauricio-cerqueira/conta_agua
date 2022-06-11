using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_da_Agua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCodigoMedidor_Click(object sender, EventArgs e)
        {
            int medidorr;
            float consumo;

            if (textBoxMedidor.Text == "" || textBox1.Text == "" || textBoxDiaNota.Text == "" || textBoxMesNota.Text == "" || textBoxAnoNota.Text == "") {
                return;

            }


            if (int.TryParse(textBoxMedidor.Text, out medidorr)) {

                if (float.TryParse(textBox1.Text, out consumo)) {
                    resultadocontaagua medidor = GerarConsumo.resultado(medidorr, consumo, textBoxDiaNota.Text, textBoxMesNota.Text, textBoxAnoNota.Text);
                    WindowsManager.resultado.Show();
                    WindowsManager.main.Hide();
                }
            }


        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            WindowsManager.cadastrar.Show();
            WindowsManager.main.Hide();
        }

        private void textBoxMedidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDiaNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMesNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnoNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
