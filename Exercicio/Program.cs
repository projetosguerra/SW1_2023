namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        //Criar uma instância (objeto) a patir de uma Classe
        Exemplo exe01 = new Exemplo();

        exe01.mostramsg();

        exe01.pegaNome("Pietro");

        Console.WriteLine(exe01.mensagem());

        Console.WriteLine("O resultado da soma é: " + exe01.somar(10,20));
    }
}
