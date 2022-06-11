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
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void buttonCadastrarUsuario_Click(object sender, EventArgs e)
        {
            int medidor;
            if (textBoxNome.Text == "" || textBoxMedidor.Text == "" || textBoxEndereco.Text == "" || textBoxEmail.Text == "" || textBoxCpf.Text == "")
                return;
            if(int.TryParse(textBoxMedidor.Text, out medidor))
            {
                Cadastro.CadastroUsuario(textBoxNome.Text, textBoxCpf.Text, textBoxEndereco.Text, textBoxEmail.Text, medidor);
                WindowsManager.main.Show();
                WindowsManager.cadastrar.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
