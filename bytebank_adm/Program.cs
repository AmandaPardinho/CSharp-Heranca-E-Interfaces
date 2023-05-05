using bytebank_adm.Funcionarios;
using bytebank_adm.Parceria;
using bytebank_adm.SistemaInterno;
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

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("14725836999");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("96314785234");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("258469173-33");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("654987321-00");
    camila.Nome = "Camila Oliveira";
        
    gerenciador.SalarioMaisBonus(camila, 0.3);
    gerenciador.SalarioMaisBonus(igor, 0.1);
    gerenciador.SalarioMaisBonus(paula, 0.5);
    gerenciador.SalarioMaisBonus(ulisses, 0.3);

    Console.WriteLine($"Salário total Camila: {String.Format("{0:0,00}", gerenciador.SalarioMaisBonus(camila, 0.3))}\nSalário total Igor: {String.Format("{0:0,00}", gerenciador.SalarioMaisBonus(igor, 0.1))}\nSalário total Paula: {String.Format("{0:0,00}", gerenciador.SalarioMaisBonus(paula, 0.5))}\nSalário total Ulisses: {String.Format("{0:0,00}", gerenciador.SalarioMaisBonus(ulisses, 0.3))}");
}

CalcularBonificacao();

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("753159426-88");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    ingrid.Login = "ingridNovaes";

    GerenteDeContas ursula = new GerenteDeContas("951357684-22");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "987";
    ursula.Login = "ursulaAlcantara";

    ParceiroComercial caio = new ParceiroComercial();
    //caio.Nome = "Caio";
    caio.Senha = "268";
    caio.Login = "caio";

    sistema.Logar(ingrid, "123", "ingridNovaes");
    sistema.Logar(ursula, "789", "ursulaAlcantara");
    sistema.Logar(caio, "268", "caio");
}

Console.ReadKey();