using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_da_Agua
{
    class BancoDeDados
    {
        public static int funcAtual;
        public static MySqlConnection conn;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        //Constructor
        public static void DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private static void Initialize()
        {
            //server = "localhost";
            server = "10.200.116.221";
            //database = "connectcsharptomysql";
            database = "Conta água";
            //uid = "username";
            uid = "admin";
            //password = "password";
            password = "senai";
            string myConnectionString;
            myConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //open connection to database
        public static bool OpenConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }
            return true;
        }
        //Close connection
        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static int GetCodUsuario(int medidor)
        {
            string querry = $"SELECT cod_usuario FROM MEDIDOR where cod_medidor = {medidor}";
            int cod = 0;
            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, conn);
                cod = int.Parse(cmd.ExecuteScalar().ToString());
                CloseConnection();
            }

            return cod;
        }

        public static UserInfos InfoUsuario(int medidor)
        {
            string querry = $"SELECT USUARIO.nome, USUARIO.cpf, USUARIO.endereco, USUARIO.email FROM USUARIO INNER JOIN MEDIDOR ON USUARIO.cod_usuario = MEDIDOR.cod_usuario where cod_medidor = {medidor}";

            if(OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querry, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                UserInfos usuario = new UserInfos(reader["nome"].ToString(), reader["cpf"].ToString(), reader["endereco"].ToString(), reader["email"].ToString());
                CloseConnection();
                return usuario;

            }
            return null;
        }
    }
}
