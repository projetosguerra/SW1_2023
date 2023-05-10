namespace animais_heranca_polimorfismo;
class Animal
{
    public string? Som {get;set;}

    public virtual string Fala(){
        return "Som: ";
    }
}