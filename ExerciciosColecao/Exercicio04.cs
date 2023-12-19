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
            Pessoa p = new Pessoa();
            Console.Write($"\nDigite o nome da {i+1}° pessoa: ");
            p.Nome = Console.ReadLine();
            
            Console.Write($"Digite a idade da {i+1}° pessoa: ");
            p.Idade = int.Parse(Console.ReadLine());
            arrayPessoas.Add(p) ;
        }
        Console.WriteLine();
        ExibirLista(arrayPessoas);

    }

    public static void ExibirLista(ArrayList p)
    {
        
        for (int i=0; i<p.Count;i++)
        {
            Console.WriteLine(p[i]);
        }

        Exercicio01.Fim();
    }

}
