using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conta_da_Agua
{
    public static class Cadastro
    {
        public static void CadastroUsuario(string nome, string cpf, string endereco, string email, int medidor)
        {
            string querry = $"INSERT INTO USUARIO(nome, cpf, endereco, email) value ('{nome}', '{cpf}', '{endereco}', '{email}')";
            if (BancoDeDados.OpenConnection() == true)
            {
                if (CheckMedidor(medidor) == true)
                {
                    MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                    cmd.ExecuteNonQuery();
                    int lastUser = GetLastId();
                    NovoMedidor(medidor, endereco, lastUser);
                    BancoDeDados.CloseConnection();
                }

            }
        }

        static bool CheckMedidor(int numMedidor)
        {
             string querry = $"SELECT cod_medidor FROM MEDIDOR where cod_medidor = {numMedidor}";
             if(BancoDeDados.OpenConnection() == true)
             {
                  MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                  if(cmd.ExecuteScalar() == null)
                  {
                        return true;
                  }
                  else
                  {
                        return false;
                  }
             }
             else
             {
                   return false;
             }

        }

        static int GetLastId()
        {
            string querry = $"SELECT cod_usuario FROM USUARIO order by cod_usuario desc";
            int id = 0;
            if(BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
            return id;
        }
        
        public static void NovoMedidor(int codigoMedidor, string endereco, int codigoUsuario)
        {
            string querry = $"INSERT INTO MEDIDOR(cod_medidor, endereco, cod_usuario) value({codigoMedidor}, '{endereco}', {codigoUsuario})";
            if(BancoDeDados.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                cmd.ExecuteNonQuery();
                BancoDeDados.CloseConnection();
            }
        }
       
    }
}
