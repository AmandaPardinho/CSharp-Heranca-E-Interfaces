using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    /* Classe abstrata =>
     * - Não permite a criação de objetos a partir dela
     * - Permite a criação de métodos abstratos => toda classe que herdar a classe abstrata Funcionario, terá a obrigação de implementar estes métodos.
     * - Continua permitindo a criação de um método construtor
     */
    public abstract class Funcionario
    {
        private double bonusSalario;

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set; }
        

        //A palavra "virtual" demonstra que um método pode ser reescrito

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf;
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();
    }
}
