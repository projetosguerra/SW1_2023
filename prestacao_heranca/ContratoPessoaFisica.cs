namespace prestacao_heranca;
class ContratoPessoaFisica:Contrato
{
    public string? CPF {get; set;}
    public int Idade {get; set;}

    public override string MostraDados()
    {
        return base.MostraDados() + " -- CPF: " + this.CPF + " -- Idade: " + this.Idade;
    }

    public override double calcularPrestacao()
    {
        if (Idade <= 30) {

            return ((base.calcularPrestacao()/Prazo)+1);

        } else if (Idade <= 40) {

            return ((base.calcularPrestacao()/Prazo)+2);

        } else if (Idade <= 50) {

            return ((base.calcularPrestacao()/Prazo)+3);

        } else {

            return ((base.calcularPrestacao()/Prazo)+4);

        }
        
    }
}