namespace Exercicio_Aviao;
class Aviao
{
    public string modelo = "Boeing 274";
    public string marca = "Boeing";
    public int altitude;
    public int velocidade;

    public void acelerar(){
        velocidade ++;
    }
    public void reduzir(){
        velocidade --;
    }
    public void subir(){
        altitude ++;
    }

    public void descer(){
        altitude --;
    }

    public void exibir(){
        Console.WriteLine("Dados do avião: ");
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Velocidade atual: " + velocidade);
        Console.WriteLine("Altitude atual: " + altitude);        
    }
}