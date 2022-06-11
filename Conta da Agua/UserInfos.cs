using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_da_Agua
{
    public class UserInfos
    {
        public string nome;
        public string cpf;
        public string endereco;
        public string email;

        public UserInfos(string nome, string cpf, string endereco, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.email = email;
        }
    }
}
