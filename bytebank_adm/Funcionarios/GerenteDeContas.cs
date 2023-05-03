using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000) 
        {        
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override double PremioSemestral()
        {
            return this.Salario * 0.3;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
