namespace animais_heranca_polimorfismo;
class Gato:Animal
{
    public override string Fala()
    {
        return base.Fala()+"Miau";
    }
}