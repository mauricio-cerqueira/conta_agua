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
    public partial class Resultado : Form
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void buttonVolta_Click(object sender, EventArgs e)
        {
            WindowsManager.main.Show();
            WindowsManager.resultado.Hide();
        }
    }
}
