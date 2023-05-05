using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class Auxiliar: Funcionario
    {
        public Auxiliar(string cpf): base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
        
    }
}
