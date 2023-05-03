using bytebank_adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public string Login { get; set; }

        public abstract bool Autenticar(string senha, string login);

        public Autenticavel(string cpf, double salario): base(cpf, salario)
        {
        }
    }
}
