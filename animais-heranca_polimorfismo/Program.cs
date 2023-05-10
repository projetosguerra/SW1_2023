namespace animais_heranca_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Homem pietro = new Homem();
        Cao luna = new Cao();
        Gato mel = new Gato();


        Console.WriteLine("Chamei o homem e ele disse: " + pietro.Fala());
        Console.WriteLine("Chamei o Cão e ele fez: " + luna.Fala());
        Console.WriteLine("Chamei o Gato e ele fez: " + mel.Fala());
    }
}
