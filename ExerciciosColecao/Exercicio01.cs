namespace ExerciciosColecao;

static class Exercicio01
{
    public static string Fruta { get; set; } = string.Empty;
    static string[] frutas = {"Maça","Banana","Laranja","Uva","Manga","Pêra","Abacate","Mamão","Pêssego","Amora" };

    public static void A()
    {
        // Usando o for
        Console.WriteLine("\nExercicios 01");
        Console.WriteLine("\na - Exibindo o nome e quantidade dos itens usando o for:\n");
        for(int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine($"{frutas[i]}");
        }
        Console.WriteLine($"Quantidade de itens: {frutas.Length}");
        
        // Usando o foreach
        Console.WriteLine("\na - Exibindo o nome e quantidade dos itens usando o foreach:\n");
        int soma = 0;
        foreach (var item in frutas)
        {
            Console.WriteLine(item);
            soma ++;
        }
        Console.WriteLine($"Quantidade de itens: {soma}");
        Fim();
    }

    public static void B()
    {
        Console.WriteLine("\nExercicios 01");
        Console.WriteLine("\nb - Exibindo o nome da segunda e da penúltima fruta:\n");
        Console.WriteLine($"Segunda: {frutas[1]}");
        Console.WriteLine($"Penultima: {frutas[8]}");
        Fim();
    }

    public static void C()
    {
        Console.WriteLine("\nExercicios 01");
        Console.WriteLine("\nc - Alterando o nome da terceira fruta para Kiwi e da última para Caqui e exibindo no console:\n");
        frutas[2] = "Kiwi";
        frutas[9] = "Caqui";
        for(int i = 0;i < frutas.Length;i++)
        {
            Console.WriteLine($"{frutas[i]}");
        }
        Fim();
    }

    public static void D()
    {
        Console.WriteLine("\nExercicios 01");
        Console.WriteLine("\nd - Ordenando a coleção de frutas em ordem ascendente\n");
        var frutas1 = frutas.ToList().Order();
        foreach (var item in frutas1)
        {
            Console.WriteLine(item);
        }
        Fim();
    }

    public static void E()
    {
        Console.WriteLine("\nExercicios 01");
        Console.WriteLine("\ne - Ordenando a coleção de frutas em ordem inversa\n");
        var frutas1 = frutas.ToList().OrderDescending();
        foreach (var item in frutas1)
        {
            Console.WriteLine(item);
        }
        Fim();
    }

    public static void Fim()
    {
        Console.WriteLine("\nPressione [enter] para ver o próximo exercício!");
        Console.ReadKey();
        Console.Clear();
    }
}
