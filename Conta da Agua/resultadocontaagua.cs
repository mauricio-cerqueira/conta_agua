using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_da_Agua
{
    public class resultadocontaagua
    {
        public resultadocontaagua(int medidor, float consumo, string dia, string mes, string ano) {
            this.medidor = medidor;
            this.consumo = consumo;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;

        }
        public int medidor;
        public float consumo;
        public string dia;
        public string mes;
        public string ano;
    }
}
