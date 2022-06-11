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
        public Resultado(resultadocontaagua resultado)
        {
            string newLine = Environment.NewLine;
            UserInfos user = BancoDeDados.InfoUsuario(resultado.medidor);
            string textToDisplay = $"Nome: {user.nome} {newLine}" +
                $"CPF: {user.cpf} {newLine}" +
                $"Endereço: {user.endereco} {newLine} {newLine}" +
                $"     CORSON {newLine} {newLine}" +
                $"Valor da conta: {resultado.valor}{newLine}" +
                $"Medição feita dia: {resultado.dia}/{resultado.mes}/{resultado.ano}{newLine}" +
                $"Consumo total de {resultado.consumo}m³";

            InitializeComponent();
            textBoxResultado.Text = textToDisplay;
        }

        private void buttonVolta_Click(object sender, EventArgs e)
        {
            WindowsManager.main.Show();
            Hide();
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
