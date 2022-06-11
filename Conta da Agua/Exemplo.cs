using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Conta_da_Agua
{
    class Exemplo
    {
        private static MySqlConnection conn;
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
            server = "10.200.119.115";
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
                //conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //open connection to database
        private static bool OpenConnection()
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
            return false;
        }


        //Close connection
        private static bool CloseConnection()
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

        //Insert statement
        public static void Insert_Pessoa(string nome, string sobrenome)
        {
            string query = "INSERT INTO Pessoa (nome, sobrenome) VALUES('" + nome + "','" + sobrenome + "')";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Update statement
        public static void Update_Sobrenome(string nome, string sobrenome)
        {
            string query = "UPDATE Pessoa SET sobrenome='" + sobrenome + "' WHERE nome='" + nome + "'";

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = conn;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        //Delete statement
        public static void Delete(string nome, string sobrenome)
        {
            string query = "DELETE FROM Pessoa WHERE nome='" + nome + "' AND sobrenome='" + sobrenome + "'";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        //Select statement
        public static string[,] Lista_Pessoas()
        {
            string query = "SELECT * FROM Pessoa";

            //Create a list to store the result
            //string[,] list = new string[BancoDeDados.Count_Pessoa(), 3];

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                /*for (int i = 0; i < list.Length; i++)
                {
                    if (dataReader.Read())
                    {
                        //list[i, 0] = dataReader[0] + "";
                       // list[i, 1] = dataReader[1] + "";
                        //list[i, 2] = dataReader[2] + "";
                    }
                }
                */
                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                //return new string[];
            }
            else
            {
                //return list;
            }
            return null;
        }

        public static List<string>[] Busca_Pessoa()
        {
            string query = "SELECT * FROM Pessoa";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id_pessoa"] + "");
                    list[1].Add(dataReader["nome"] + "");
                    list[2].Add(dataReader["sobrenome"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public static int Count_Pessoa()
        {
            string query = "SELECT Count(*) FROM Pessoa";
            int Count = -1;

            //Open Connection
            if (OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //ExecuteScalar will return one value
                Count = Int32.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public static int GetId(string nome, string sobrenome)
        {
            string query = $"SELECT id_pessoa FROM Pessoa where nome = '{nome}' and sobrenome = '{sobrenome}'";
            int id_Pessoa = -1;

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Execute command
                id_Pessoa = Int32.Parse(cmd.ExecuteScalar().ToString());

                //close connection
                CloseConnection();
            }
            return id_Pessoa;
        }

        public static void Insert_Funcionario(string nome, string sobrenome, float salario)
        {
            //ncoDeDados.Insert_Pessoa(nome, sobrenome);
            int id = GetId(nome, sobrenome);
            string query = $"INSERT INTO Funcionario (Salario, id_pessoa) VALUES({salario}, {id})";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public static int GetMatricula(string nome, string sobrenome)
        {
            string query = $"SELECT matricula FROM Funcionario INNER JOIN Pessoa on Funcionario.id_pessoa = Pessoa.id_pessoa where nome = '{nome}' and sobrenome = '{sobrenome}'";
            int matricula = -1;

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                matricula = int.Parse(cmd.ExecuteScalar().ToString());

                CloseConnection();
            }

            return matricula;
        }

        public static void AtualizaSalario(int matricula, float salario)
        {
            string query = $"UPDATE Funcionario SET salario = {salario} where matricula = {matricula}";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.ExecuteScalar();

                CloseConnection();
            }
        }

        public static int GetFuncionarios()
        {
            string query = $"SELECT COUNT(*) FROM Funcionario";

            int count = -1;
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                count = int.Parse(cmd.ExecuteScalar().ToString());

                CloseConnection();
            }

            return count;
        }
        public static List<string> ListarFuncionarios()
        {
            string query = "SELECT nome, salario from Pessoa INNER JOIN Funcionario on Pessoa.id_pessoa = Funcionario.id_pessoa order by salario desc";
            List<string> funcs = new List<string>();
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    funcs.Add("Nome: " + dataReader["nome"] + "    Salario: " + dataReader["salario"]);
                }
                dataReader.Close();
                CloseConnection();
            }
            return funcs;
        }
        public static float SomaSalarios()
        {
            float resultado = -1;
            string query = "SELECT SUM(salario) FROM Funcionario";
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);

                resultado = float.Parse(cmd.ExecuteScalar().ToString());

                CloseConnection();
            }


            return resultado;
        }
    }
}
