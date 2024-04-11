namespace Exercício2_Site
{
    internal class Program
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa(); 
            pessoa.Nome = "Carolina";
            pessoa.Idade = 16;
            pessoa.CPF = "123.456.789-00";
            pessoa.Sexo = 'F';
            pessoa.Altura = 1.58;

            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Idade: " + pessoa.Idade);
            Console.WriteLine("Cpf: " + pessoa.CPF);
            Console.WriteLine("Sexo: " + pessoa.Sexo);
            Console.WriteLine("Altura: " + pessoa.Altura);
        }
    }
}