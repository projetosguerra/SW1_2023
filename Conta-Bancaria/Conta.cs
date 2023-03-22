namespace Conta_Bancaria;
class Conta
{
    
    public string? nomeCliente {get;set;}

    public int numeroConta {get; set;}

    public double saldo {get; set;}

    public double limite {get; set;}

    //Método para ajustar o limite

    public void ajustarLimite (double valor){
        this.limite = valor;
    }

    //Método para ralizar um depósito
    public void depositar (double valor){
        this.saldo += valor;
    }

    //Método para realizar um saque
    public void sacar (double valor){
        if (valor <= this.saldo + this.limite) {
            Console.WriteLine("O valor sacado é de: " + saldo);
            this.saldo -= valor;
        }else {
            Console.WriteLine("Você não possui saldo+limite suficiente para esse saque!");
            Console.WriteLine("Saque não realizado");
        }
    }
 
    //Método ConsultaSaldo - retorna um saldo disponível + limite
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}