using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conta_da_Agua
{
    public static class TelaLogin
    {
        public static bool EfetuaCadastro(string nome, int senha)
        {
            string querry = $"SELECT cod_funcionario FROM FUNCIONARIO where nome = '{nome}' and cod_funcionario = {senha}";

            if (BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                if (cmd.ExecuteScalar() != null)
                {
                    BancoDeDados.funcAtual = int.Parse(cmd.ExecuteScalar().ToString());
                    BancoDeDados.CloseConnection();
                    return true;
                }
                else
                {
                    BancoDeDados.CloseConnection();
                    return false;
                }
            }
            return false;
        }        
    }
}
