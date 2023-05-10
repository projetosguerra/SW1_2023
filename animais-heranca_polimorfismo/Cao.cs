namespace animais_heranca_polimorfismo;
class Cao:Animal
{
    public override string Fala()
    {
        return base.Fala()+"Au au";
    }
}