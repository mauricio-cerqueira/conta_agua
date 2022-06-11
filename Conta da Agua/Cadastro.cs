using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient

namespace Conta_da_Agua
{
    class Cadastro
    {
        public void Cadastro(string nome)
        {
            string querry = $"INSERT INTO USUARIO(NOME, ENDERECO, CPF) value ({nome}, idade)";
            if(BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                cmd.ExecuteNonQuery();
                BancoDeDados.CloseConnection();
            }

        }
    }
}
