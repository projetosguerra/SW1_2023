namespace contrato_heranca;
class ContratoPessoaFisica:Contrato
{
    public string? CPF {get; set;}
    public int Idade {get; set;}

    public override string MostraDados()
    {
        return base.MostraDados() + " -- CPF: " + this.CPF + " -- Idade: " + this.Idade;
    }
}