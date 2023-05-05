using bytebank_adm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public interface IBonificacao
    {
        public double PorcentagemBonus { get; set; }

        public double SalarioMaisBonus(Funcionario funcionario, double porcentagemBonus);
    }
}
