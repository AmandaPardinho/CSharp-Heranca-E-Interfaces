using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica.Basicas
{
    public class Multiplicacao
    {
        public double Calcular(double multiplicando, double multiplicador)
        {
            if((multiplicando == 0) || (multiplicador == 0))
            {
                return 0;
            }
            return multiplicador * multiplicando;
        }
    }
}
