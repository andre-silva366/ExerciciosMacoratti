namespace ExerciciosColecao;

public class Produto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

}
