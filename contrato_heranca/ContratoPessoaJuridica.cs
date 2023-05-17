namespace contrato_heranca;
class ContratoPessoaJuridica:Contrato
{
    public string? CNPJ {get; set;}
    public string? IE {get; set;}
    public string? NomeEmpresa {get; set;}

    public override string MostraDados()
    {
        return base.MostraDados() + " -- CNPJ: " + this.CNPJ + " -- IE: " + this.IE + " -- NomeEmpresa: " + this.NomeEmpresa;
    }
}