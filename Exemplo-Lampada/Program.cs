namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Lampada lamp1 = new Lampada();
        Lampada lamp2 = new Lampada();
        lamp1.ligar();

        Console.WriteLine("A lampada1 está ligada? " + lamp1.estaLigada());
        Console.WriteLine("A lampada2 está ligada? " + lamp2.estaLigada());
    }
}
