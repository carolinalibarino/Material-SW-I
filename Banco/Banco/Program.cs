namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANCO MCM");

            Conta conta = new Conta();
            Console.WriteLine("Seu saldo inicial é de R$" + conta.consulta_saldo());

            conta.deposito(500);

            //Console.WriteLine("Seu novo saldo é de: R$" + conta.consulta_saldo());

            //conta.sacar(1000);

            conta.ajustar_limite(500);


        }
    }
}