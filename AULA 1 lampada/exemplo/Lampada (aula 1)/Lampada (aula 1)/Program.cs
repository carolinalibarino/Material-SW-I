namespace Lampada__aula_1_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //instancia de um objeto:
            Lampada lampada1 = new Lampada();
            Lampada lampada2 = new Lampada();

            //acessando um aributo publico do objeto
            lampada1.Ligada = true;
            lampada1.Potencia = 150;
            lampada1.Cor = "Vermelha";

            lampada2.Ligada = false;
            lampada2.Potencia = 100;
            lampada2.Cor = "Azul";

            //visualizando os valores dos atributos
            Console.WriteLine("Esta é a lâmpada 1");
            Console.WriteLine("A lâmpada está ligada? " +lampada1.Ligada );
            Console.WriteLine("A potencia da lâmpada é: " + lampada1.Potencia );
            Console.WriteLine("A cor da lâmpada é: " + lampada1.Cor);
            Console.WriteLine("*******************************");
            //Console.WriteLine("") - pula linha
            Console.WriteLine("Esta é a lâmpada 2");
            Console.WriteLine("A lâmpada está ligada? " + lampada2.Ligada);
            Console.WriteLine("A potencia da lâmpada é: " + lampada2.Potencia);
            Console.WriteLine("A cor da lâmpada é: " + lampada2.Cor);

        }
    }
}