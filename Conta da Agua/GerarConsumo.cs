using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Conta_da_Agua
{
    public static class GerarConsumo
    {
        public static resultadocontaagua resultado(int medidor, float consumo, string dia, string mes, string ano) {

            resultadocontaagua conta = new resultadocontaagua(medidor, consumo, dia, mes, ano);
            int codUsuario = BancoDeDados.GetCodUsuario(medidor);
            conta.valor = ValorContaAgua(consumo);
            string querry = $"INSERT INTO HISTORICO(`cod_usuario`, `status`, `ValordaConta`, `data`, `consumo`, `cod_funcionario`) VALUES ('{codUsuario}' , '0', '{conta.valor.ToString(CultureInfo.CreateSpecificCulture("en-US"))}', '{ano}/{mes}/{dia}' , '{consumo}', '{BancoDeDados.funcAtual}');";

            if (BancoDeDados.OpenConnection() == true) {

                    MySqlCommand cmd = new MySqlCommand(querry, BancoDeDados.conn);
                    cmd.ExecuteNonQuery();
                    BancoDeDados.CloseConnection();

            }
            return conta;
        }

        private static float ValorContaAgua(float consumo)
        {
            double resultado = Math.Round(consumo * 3.789 + 9.73 + 4.86, 2);
            return (float)resultado;
        }
          
    }
}
