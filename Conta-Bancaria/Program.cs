namespace Conta_Bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta Bancária - Etec MCM");
        Conta conta = new Conta();

        /*conta.nomeCliente = "Pietro Guerra";
        conta.numeroConta = 321;
        conta.limite = 1500;
        conta.saldo = 5000;

        Console.WriteLine("Olá, " + conta.nomeCliente + ", seu saldo é de: " + conta.saldo);
        Console.WriteLine("Seu limite de saque é de: " + conta.limite);
        Console.WriteLine("O número da sua conta é: " + conta.numeroConta);*/

        conta.nomeCliente = "Pietro Guera";
        conta.ajustarLimite(800);
        conta.depositar(200);
        conta.sacar(300);

        //Vamos chamar o método ConsultaSaldo e receber em uma variável local chamada saldo e valor disponível em saldo desse cliente
        double saldo = conta.ConsultaSaldo();
        
        //Agora para visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
