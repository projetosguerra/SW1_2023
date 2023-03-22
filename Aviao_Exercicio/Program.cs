namespace Exercicio_Aviao;
class Program
{
    static void Main(string[] args)
    {
        Aviao nave1 = new Aviao();

        nave1.modelo = "Boeing 274";
        nave1.marca = "Boeing";

        nave1.exibir();
        nave1.acelerar();
        nave1.exibir();
        nave1.subir();
        nave1.exibir();
        
    }
}
