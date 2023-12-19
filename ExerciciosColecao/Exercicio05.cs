namespace ExerciciosColecao;

public static class Exercicio05
{
    static List<Produto> produtos = new List<Produto>();

    public static void CriandoLista()
    {
        Console.WriteLine("\nCriando a lista de produtos...");
        produtos = new List<Produto> 
        { 
            new Produto("Clips",3.95m),
            new Produto("Caneta",5.99m),
            new Produto("Lápis",4.15m),
            new Produto("Estojo",6.99m),
            new Produto("Caderno",7.55m)
            
        };
    }

    public static void ExibirRelacao()
    {
        decimal somaTotal = 0m;
        decimal media = 0m;
        Console.WriteLine("\n1 - Exibindo a relação de produtos:\n");
        foreach (var produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}\tPreço: {produto.Preco}");
            somaTotal += produto.Preco;
        }
        media = somaTotal / produtos.Count;
        Console.WriteLine($"\nExibindo a soma total dos preços dos produtos:");
        Console.WriteLine($"Soma total = {somaTotal.ToString("f2")}");
        Console.WriteLine($"\nExibindo a média dos preços...");
        Console.WriteLine($"Média dos preços = {media.ToString("f2")}");
        Console.WriteLine($"\nExibindo a quantidade de produtos:");
        Console.WriteLine($"Quantidade de produtos = {produtos.Count}");
        Console.WriteLine($"\n2 - Incluindo mais um produto na lista...\n");
        produtos.Add(new Produto("Mochila",22.44m));
        Console.WriteLine("Exibindo a lista...\n");
        ListarProdutos(produtos);
        
    }

    public static void ListarProdutos(List<Produto> p)
    {
        foreach(var produto in p)
        {
            Console.WriteLine($"Nome: {produto.Nome}\tPreço = {produto.Preco}");
        }

        OrdenaralistaPeloNome(produtos);
    }

    public static void OrdenaralistaPeloNome(List<Produto> p )
    {
        var listaOrdenada = p.OrderBy(x => x.Nome).ToList();
        Console.WriteLine("\n3 - Ordenando lista pelo nome e exibindo...\n");
        foreach (var produto in listaOrdenada)
        {
            Console.WriteLine($"Nome: {produto.Nome}\tPreço: {produto.Preco}");
        }
        
    }

    public static void PrecoMenorQueCinco()
    {
        Console.WriteLine("\n4 - Exibindo produtos com preço menor que 5,00\n");
        var listaPrecoMenorQueCinco = produtos.Where(x => x.Preco < 5.00m).ToList();
        foreach (var item in listaPrecoMenorQueCinco)
        {
            Console.WriteLine($"Nome: {item.Nome}\tPreço: {item.Preco}");
        }
    }

    public static void LocalizarProduto(string nome)
    {
        Console.WriteLine($"\n5 - Exibindo produto com nome Estojo:\n");
        foreach (var produto in produtos)
        {
            if(produto.Nome == nome)
            {
                Console.WriteLine($"Nome: {produto.Nome}\tPreço: {produto.Preco}");
            }
            
        }
        Console.ReadKey();
    }
}
