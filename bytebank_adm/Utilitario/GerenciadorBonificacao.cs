using bytebank_adm.Funcionarios;
using bytebank_adm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.Utilitario
{
    public class GerenciadorBonificacao: IBonificacao
    {
        public double PorcentagemBonus { get; set; }

        public double SalarioMaisBonus(Funcionario funcionario, double porcentagemBonus)
        {
            double TotalSalario = funcionario.Salario + (funcionario.Salario * porcentagemBonus);
            return TotalSalario;
        }
    }
}
