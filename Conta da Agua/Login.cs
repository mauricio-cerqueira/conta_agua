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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {
            int senha;
            if (int.TryParse(LoginSenha.Text, out senha))
            {
                if (TelaLogin.EfetuaCadastro(LoginNome.Text, senha))
                {
                    WindowsManager.main.Show();
                    Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
