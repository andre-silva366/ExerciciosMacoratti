using Heranca_Exercicio134;

Console.WriteLine("Atribuindo valores para as contas: corrente, poupança e investimento...");

ContaCorrente contaCorrente = new(100, "André");
ContaPoupanca contaPoupanca = new(101, "André");
ContaInvestimento contaInvestimento = new(102, "André");

Console.WriteLine("\nFazendo um depósito de 1000 para cada tipo de conta e exibindo:");
contaCorrente.Depositar(1000m);
contaPoupanca.Depositar(1000m);
contaInvestimento.Depositar(1000m);
ExibirSaldoContas(contaCorrente, contaPoupanca, contaInvestimento);

Console.WriteLine("\nFazendo um saque de 100 em cada tipo de conta e exibindo:");
contaCorrente.Sacar(100m);
contaPoupanca.Sacar(100m);
contaInvestimento.Sacar(100m);
ExibirSaldoContas(contaCorrente, contaPoupanca, contaInvestimento);

Console.WriteLine("\nFazendo um saque de 2000 para cada tipo de conta e exibindo:");
Console.WriteLine();
contaCorrente.Sacar(2000m);
contaPoupanca.Sacar(2000m);
contaInvestimento.Sacar(2000m);

ExibirSaldoContas(contaCorrente, contaPoupanca, contaInvestimento);

Console.ReadKey();

static void ExibirSaldoContas(ContaCorrente contaCorrente, ContaPoupanca contaPoupanca, ContaInvestimento contaInvestimento)
{
    Console.WriteLine();
    contaCorrente.ExibirSaldo();
    contaPoupanca.ExibirSaldo();
    contaInvestimento.ExibirSaldo();
}