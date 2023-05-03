using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789-00", 2000.0);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine($"Nome: {pedro.Nome}\nCPF: {pedro.Cpf}\nSalário: {String.Format("{0:0.00}", pedro.Salario)}\nBonificação: {String.Format("{0:0.00}", pedro.GetBonificacao())}\nPrêmio semestral: {String.Format("{0:0.00}", pedro.PremioSemestral())}");

//Diretor roberta = new Diretor("987654321-00", 5000.0);
//roberta.Nome = "Roberta Silva";

//Console.WriteLine();
//Console.WriteLine($"Nome: {roberta.Nome}\nCPF: {roberta.Cpf}\nSalário: {String.Format("{0:0.00}", roberta.Salario)}\nBonificação: {String.Format("{0:0.00}", roberta.GetBonificacao())}\nPrêmio semestral: {String.Format("{0:0.00}", roberta.PremioSemestral())}");

//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine();
//Console.WriteLine($"Total de bonificações: {String.Format("{0:0.00} ", gerenciador.TotalBonificacao)}\nTotal de funcionários: {Funcionario.TotalFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo valor do salário do Pedro: {String.Format("{0:0,00}", pedro.Salario)}\nNovo valor do salário da Roberta: {String.Format("{0:0,00}", roberta.Salario)}");
#endregion

void CalcularBonificacao(){
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("14725836999");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("96314785234");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("258469173-33");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("654987321-00");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine($"Total de bonificação: {String.Format("{0:0.00}", gerenciador.TotalBonificacao)}");

    Console.ReadKey();
}

CalcularBonificacao();