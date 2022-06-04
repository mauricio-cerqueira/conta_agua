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
            WindowsManager.resultado.Show();
            WindowsManager.main.Hide();
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            WindowsManager.cadastrar.Show();
            WindowsManager.main.Hide();
        }
    }
}
