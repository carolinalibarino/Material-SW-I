namespace Exercício1_Área
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcula áre quadrado e retângulo");

            Area area= new Area();

            Console.WriteLine(area.Calcular());

            Console.WriteLine(area.Dados());    
        }
    }
}