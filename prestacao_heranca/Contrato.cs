namespace prestacao_heranca;
class Contrato
{
    public string? Nome {get; set;} 
    public string? Email {get; set;}
    public string? Telefone {get; set;}
    public int Prazo {get;set;}

    public virtual string MostraDados(){
        return "Nome: " + this.Nome + " -- Email: " + this.Email + " -- Telefone: " + this.Telefone;
    }

    public virtual double calcularPrestacao(){
        return 1000;
    }
}