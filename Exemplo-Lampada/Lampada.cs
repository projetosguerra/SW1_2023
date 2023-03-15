namespace exemplo;
class Lampada
{
    public bool ligada; 
    public double potencia;
    public void ligar(){
        ligada = true;
    }
    public void desligar(){
        ligada = false;
    }
    public bool estaLigada(){
        return ligada;
    }
}