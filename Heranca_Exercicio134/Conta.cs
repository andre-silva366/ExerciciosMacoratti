namespace Heranca_Exercicio134;

internal class Conta
{
    private int numero;
    private string nome = default!;
    private decimal saldo = 0m;

    public Conta(int numero, string nome)
    {
        Numero = numero;
        Nome = nome;
       
    }

    public int Numero
    {
        get { return numero; }
        set { numero = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public decimal Saldo
    {
        get { return saldo; }
        set { saldo = value; } 
    }

    public virtual void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(decimal valor)
    {
        Saldo -= valor;
    }

    
}
