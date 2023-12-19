using System.Collections;

namespace ExerciciosColecao;

public static class Exercicio06
{
    public static void ProcessaObjetos()
    {
        ArrayList objetos = new ArrayList()
        {
            1,
            "Maria",
            3.45m,
            new Teste(),
            null
        };

        Console.WriteLine("\n6 - Criando método para processar objetos....\n");
        Console.WriteLine("Exibindo valor e tipo do Objeto...\n");
        Console.WriteLine("Valor\tTipo\n");
        for (int i = 0; i < objetos.Count-1; i++)
        {
            Console.WriteLine($"{objetos[i].ToString()}\t{objetos[i].GetType()}");
        }

        Console.ReadKey();
    }
}
