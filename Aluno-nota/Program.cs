namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        /*
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Pietro Guerra";
        aluno1.nota1 = 8;
        aluno1.nota2 = 5;

        aluno1.mensagem();
        */

        Alunos aluno1 = new Alunos();
        
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: "+ nome);
        Console.Write("Digite sua nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + nota1);
        Console.Write("Digite sua segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi: " + nota2);
        aluno1.nome = nome;
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;
        aluno1.mensagem();
    }
}
