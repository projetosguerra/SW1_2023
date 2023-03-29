namespace exemplo_acessor;
class Produto
{

    private string? Nome {get;set;}

    private double Preco {get;set;}


    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome );
        Console.WriteLine("Preco: " + this.Preco );
    }

    public void AlteraPreco(double preco){
        if (preco >= 0) {
            this.Preco = preco;
        }else {
            Console.WriteLine("O preço está indisponível");
        }
    }

    public void AlteraNome(string nome){
        this.Nome = nome;
    }
    
}