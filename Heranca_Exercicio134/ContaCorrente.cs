namespace Heranca_Exercicio134;

internal class ContaCorrente : Conta
{
    public ContaCorrente(int numero,string nome):base(numero,nome)
    {
        Nome = nome;
        Numero = numero;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo da conta corrente: {Saldo:c2}");
    }
}
