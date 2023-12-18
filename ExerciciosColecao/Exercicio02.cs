namespace ExerciciosColecao;

static class Exercicio02
{
    public static int n = 0;
    public static int[] arrayInteiros = new int[n];

    public static void ArrayInteiros()
    {
        Console.Write("\na - Informe o número de valores do Array: ");
        n = int.Parse(Console.ReadLine());
        arrayInteiros = new int[n];
        Console.WriteLine($"\nb - Declarado e iniciado array com {n} números...");
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            arrayInteiros[i] = random.Next(0,100);
        }

        string palavraChave = string.Empty;

        do
        {
            Console.Write("\nc - Digite um número a ser procurado no array: ");
            int numero = int.Parse(Console.ReadLine());
            bool Existe = false;

            foreach (var item in arrayInteiros)
            {
                if (item == numero)
                {
                    Existe = true;
                    break;
                }

            }

            Console.WriteLine($"\nd - Verificando se o {numero} existe ou não no array...");

            if (Existe)
            {
                Console.WriteLine($"\nO número {numero} existe no array.");
            }
            else
            {
                Console.WriteLine($"\nO número {numero} não existe no array.");
            }

            Console.WriteLine("\ne - Digite fim para sair ou qualquer tecla para continuar...");
            palavraChave = Console.ReadLine();
            Console.Clear();
        }
        while (palavraChave != "fim");
        Exercicio01.Fim();
    }
}
