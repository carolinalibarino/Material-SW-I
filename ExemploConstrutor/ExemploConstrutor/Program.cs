namespace ExemploConstrutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo construtor de uma classe");

            Cliente xyz = new Cliente("Carolina", 1234);

            //xyz.Nome = "Carolina";
            //xyz.Email = "carollibarino2@gmail.com";
            //xyz.Senha = 1234;

            xyz.MostraDados();
        }
    }
}