namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Pietro Guerra";
        aluno1.nota1 = 8;
        aluno1.nota2 = 5;

        aluno1.mensagem();
    }
}
