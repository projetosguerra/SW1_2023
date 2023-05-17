namespace contrato_heranca;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Pietro ";
        cf.Email = "pietroelg@gmail.com ";
        cf.Telefone = "957202090 ";
        cf.CPF = "439.872.058-81 ";
        cf.Idade = 16 ;

        cj.Nome = "Eduardo ";
        cj.Email = "ampliato@gmail.com ";
        cj.Telefone = "991642090 ";
        cj.CNPJ = "928364801 ";
        cj.IE = "983648281002 ";
        cj.NomeEmpresa = "Ampliato";

        Console.WriteLine("Quer ver seus dados como uma pessoa física? " + cf.MostraDados());
        Console.WriteLine("Quer ver seus dados como uma pessoa juridica? " + cj.MostraDados());
    }
}







//"Nome: " + cf.Nome + " -- Email: " + cf.Email + " -- Telefone: " + cf.Telefone + " -- CPF: " + cf.CPF + " -- Idade: " + cf