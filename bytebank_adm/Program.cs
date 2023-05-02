using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitario;

Funcionario pedro = new Funcionario("123456789-00", 2000.0);
pedro.Nome = "Pedro Malazartes";

Console.WriteLine($"Nome: {pedro.Nome}\nCPF: {pedro.Cpf}\nSalário: {String.Format("{0:0.00}", pedro.Salario)}\nBonificação: {String.Format("{0:0.00}", pedro.GetBonificacao())}\nPrêmio semestral: {String.Format("{0:0.00}", pedro.PremioSemestral())}");

Diretor roberta = new Diretor("987654321-00", 5000.0);
roberta.Nome = "Roberta Silva";

Console.WriteLine();
Console.WriteLine($"Nome: {roberta.Nome}\nCPF: {roberta.Cpf}\nSalário: {String.Format("{0:0.00}", roberta.Salario)}\nBonificação: {String.Format("{0:0.00}", roberta.GetBonificacao())}\nPrêmio semestral: {String.Format("{0:0.00}", roberta.PremioSemestral())}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine();
Console.WriteLine($"Total de bonificações: {String.Format("{0:0.00} ", gerenciador.TotalBonificacao)}\nTotal de funcionários: {Funcionario.TotalFuncionarios}");

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine($"Novo valor do salário do Pedro: {String.Format("{0:0,00}", pedro.Salario)}\nNovo valor do salário da Roberta: {String.Format("{0:0,00}", roberta.Salario)}");

Console.ReadKey();