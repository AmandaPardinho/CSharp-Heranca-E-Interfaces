using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitario;

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789-00";
pedro.Salario = 2000.0;

Console.WriteLine($"Nome: {pedro.Nome}\nCPF: {pedro.Cpf}\nSalário: {String.Format("{0:0.00}", pedro.Salario)}\nBonificação: {String.Format("{0:0.00}", pedro.GetBonificacao())}");

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321-00";
roberta.Salario = 5000.0;

Console.WriteLine();
Console.WriteLine($"Nome: {roberta.Nome}\nCPF: {roberta.Cpf}\nSalário: {String.Format("{0:0.00}", roberta.Salario)}\nBonificação: {String.Format("{0:0.00}", roberta.GetBonificacao())}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine();
Console.WriteLine($"Total de bonificações: {String.Format("{0:0.00} ", gerenciador.TotalBonificacao)}");

Console.ReadKey();