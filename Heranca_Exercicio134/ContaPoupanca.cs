namespace Heranca_Exercicio134;

internal class ContaPoupanca : Conta
{
    const decimal juros = 0.5m;

    public ContaPoupanca(int numero, string nome ) : base(numero,nome)
    {
        Nome = nome;
        Numero = numero;
        
    }

    public override void Sacar(decimal valor)
    {
        if(valor > Saldo)
        {
            Console.WriteLine("Conta poupança - O valor a sacar é superior ao saldo...operação negada!");
        }
        else
        {
            Saldo -= valor;
        }
    }

    public override void Depositar(decimal valor)
    {
        Saldo += valor + (valor*juros)/100;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo da conta poupança: {Saldo:c2}");
    }
}
