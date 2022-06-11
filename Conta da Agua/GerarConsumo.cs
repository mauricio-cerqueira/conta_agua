using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conta_da_Agua
{
    public static class GerarConsumo
    {
        public static resultadocontaagua resultado(int medidor, float consumo, string dia, string mes, string ano) {

            resultadocontaagua conta = new resultadocontaagua(medidor, consumo, dia, mes, ano);
            string querry = $"INSERT INTO `HISTORICO` (`cod_usuario`, `status`, `ValordaConta`, `data`, `consumo`, `cod_funcionario`) VALUES ('1', '0', '300', '{ano}/{mes}/{dia}', '{consumo}', '1')";

            if (BancoDeDados.OpenConnection() == true) {
                MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                cmd.ExecuteNonQuery();
                BancoDeDados.CloseConnection();
                

            }
            return conta;
        }
          
    }
}
