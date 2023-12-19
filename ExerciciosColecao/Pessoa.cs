namespace ExerciciosColecao;

public class Pessoa
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa()
    {
        
    }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public void ExibirNomeIdade()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
}
