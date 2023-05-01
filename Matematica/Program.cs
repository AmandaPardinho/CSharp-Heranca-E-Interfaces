using matematica.Operacoes;

Operacao operacao = new Operacao();

Console.WriteLine($"Total soma: {operacao.SomaNum.Calcular(5, 19)}\nTotal subtração: {operacao.SubtraiNum.Calcular(8, 3)}\nTotal multiplicação: {operacao.MultiplicaNum.Calcular(1, 24)}\nTotal divisão: {operacao.DivideNum.Calcular(48, 6)}");

Console.ReadKey();