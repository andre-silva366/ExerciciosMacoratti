namespace Heranca_Exercicio134;

internal class ContaInvestimento : Conta
{
    const decimal taxa = 0.9m;
    const decimal imposto = 0.1m;

    public ContaInvestimento(int numero, string nome) : base(numero, nome)
    {
        Nome = nome;
        Numero = numero;
    }

    public override void Depositar(decimal valor)
    {
        Saldo += valor + (valor * taxa)/100;
    }

    public override void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine("Conta investimento - O valor a sacar é superior ao saldo...operação negada!");
        }
        else
        {
            Saldo -= valor;
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo da conta investimento: {Saldo:c2}");
    }

}
