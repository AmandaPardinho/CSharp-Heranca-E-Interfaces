using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }
        public string Senha { get; set; }
        public string Login { get; set; }
        public double PorcentagemBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double TotalBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Autenticar(string senha, string login)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
