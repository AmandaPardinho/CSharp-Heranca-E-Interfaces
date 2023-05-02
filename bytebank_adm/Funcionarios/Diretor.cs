using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class Diretor: Funcionario
    {
        //A palavra "override" mostra que esse método irá sobrescrever o método da superclasse que estiver definido como "virtual"
        public override double GetBonificacao()
        {
            //Palavra "base" => palavra reservada que permite acessar implementações e propriedades existentes na superclasse
            return this.Salario + base.GetBonificacao();
        }

        public override double PremioSemestral()
        {
            return this.Salario + base.PremioSemestral();
        }

        public Diretor(string cpf,double salario):base(cpf, salario)
        {
            
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
