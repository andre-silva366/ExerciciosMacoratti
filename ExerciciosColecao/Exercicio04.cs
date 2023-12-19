using System.Collections;

namespace ExerciciosColecao;

public  class Exercicio04 
{
    public static ArrayList arrayPessoas = new ArrayList();
    

    public static void AdicionarPessoas()
    {
        Console.WriteLine($"a - Realizando a criação da classe Pessoa...\n");
        Console.WriteLine($"b - Criando um ArrayList com os dados a seguir...");
        for ( int i=0;arrayPessoas.Count < 3;i++ )
        {            
            Console.Write($"\nDigite o nome da {i+1}° pessoa: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite a idade da {i+1}° pessoa: ");
            int idade = int.Parse(Console.ReadLine());
            Pessoa p = new Pessoa(nome,idade);
            arrayPessoas.Add(p) ;
        }
        Console.WriteLine();
        Console.WriteLine("\nc - Exibindo o nome e idade das pessoas:\n");
        ExibirLista(arrayPessoas);

    }

    public static void ExibirLista(ArrayList p)
    {
        for (int i=0; i<p.Count;i++)
        {
            Console.WriteLine(p[i]);
        }
        
    }

    public static void IncluindoDuasPessoas()
    {
        Console.WriteLine("\nd - Adicionando mais 2 pessoas e exibindo a lista:\n");
        Pessoa p = new Pessoa(nome: "Jaime", idade: 20);
        Pessoa p1 = new Pessoa(nome: "Tânia",idade: 18);
        arrayPessoas.Add (p);
        arrayPessoas.Add(p1);
        ExibirLista(arrayPessoas);
        RemovendoUltimo();
    }

    public static void RemovendoUltimo()
    {
        Console.WriteLine("\ne - Removendo o último elemento e exibindo a lista. \n");
        arrayPessoas.RemoveAt(arrayPessoas.Count-1);
        ExibirLista(arrayPessoas);
        Console.ReadKey();
    }

}
