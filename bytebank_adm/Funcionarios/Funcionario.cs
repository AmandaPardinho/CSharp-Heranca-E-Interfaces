using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }

        //A palavra "virtual" demonstra que um método pode ser reescrito
        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public virtual double PremioSemestral()
        {
            return this.Salario * 0.2;
        }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
