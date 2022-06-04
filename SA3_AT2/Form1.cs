using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA3_AT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BancoDeDados.DBConnect();

            String[] lista = BancoDeDados.Lista_Estados();
            for (int i = 0; i < lista.Length; i++)
            {
                comboBox_Estados.Items.Add(lista[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox_Cidades.Text = "";
            String[] lista = BancoDeDados.Lista_Cidades(comboBox_Estados.Text);
            for (int i = 0; i < lista.Length; i++)
            {
                comboBox_Cidades.Items.Add(lista[i]);
            }

        }

        private void comboBox_Cidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] lista = BancoDeDados.Lista_Municipios(comboBox_Cidades.Text);
            for (int i = 0; i < lista.Length; i++)
            {
                comboBox_Municipios.Items.Add(lista[i]);
            }
        }
    }
}
