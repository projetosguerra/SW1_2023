namespace animais_heranca_polimorfismo;
class Homem:Animal
{
    public override string Fala()
    {
        return base.Fala()+"Oi oi";
    }
}