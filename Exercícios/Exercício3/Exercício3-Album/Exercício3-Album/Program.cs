namespace Exercício3_Album
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando número de fotos por página");
            Console.WriteLine("");

            Album album = new Album();

            Console.WriteLine(album.NumeroDePaginas());

        }
    }
}