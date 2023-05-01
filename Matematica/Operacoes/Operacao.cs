using matematica.Basicas;

namespace matematica.Operacoes
{
    public class Operacao
    {
        public Soma SomaNum { get; private set; }
        public Subtracao SubtraiNum { get; private set; }
        public Multiplicacao MultiplicaNum { get; private set; }
        public Divisao DivideNum { get; private set; }

        public Operacao()
        {
            this.SomaNum = new Soma();
            this.SubtraiNum = new Subtracao();
            this.MultiplicaNum = new Multiplicacao();
            this.DivideNum = new Divisao();
        }
    }
}
