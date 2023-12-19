namespace ExerciciosColecao;

public class Aluno
{
    string[] nome = new string[10];

    public string this[int i]
    {
        get
        {
            if(i >= 0 && i <= 9)
            {
                return nome[i];
            }
            return "Erro";
        }
        set
        {
            if (i >= 0 && i <= 9)
            {
                nome[i] = value;
            }
            
        }
    }
      

}
