using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conta_da_Agua
{
    class TelaLogin
    {
        public bool EfetuaCadastro(string nome, int senha)
        {
            string querry = $"SELECT nome, cod_funcionario AS 'senha' FROM FUNCIONARIO where nome = '{nome}' and senha = {senha}";

            if (BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader)
            }

        }
        
    }
}
