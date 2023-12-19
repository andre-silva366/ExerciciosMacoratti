namespace ExerciciosColecao;

static class Exercicio03
{
    public static float[,] notas = new float[2, 5];

    public static void InserirNotas()
    {
        int i,j;
        float soma = 0;
        float media = 0;
        Console.WriteLine($"\nInserindo nota aos alunos.");
        for( i = 0;i <2;i++)
        {
            soma = 0;
            for(j=0; j < 5; j++)
            {
                Console.Write($"\nInsira a nota do aluno {j+1} do grupo {i+1}: ");
                notas[i,j] = float.Parse(Console.ReadLine());
                soma += notas[i,j];
            }

            Console.WriteLine($"\nA média do grupo {i+1} é {(soma/5).ToString("f2")}");
        }
        
        Exercicio01.Fim();
    }
    
}
