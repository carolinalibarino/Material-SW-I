namespace Lampada__aula_1_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //instancia de um objeto:
            Lampada lamp1 = new Lampada();

            //Chamado o método para ligar a lamp1
            lamp1.ligar();

            //Chamando o método para verificar se lamp1 está ligada
            Console.WriteLine("A lâmpada está ligada? " + lamp1.estaligada());


            lamp1.desligada();
            Console.WriteLine("A lampada esta ligada?" + lamp1.estaligada());


            //testando

            lamp1.getPotencia = 100;
            lamp1.getCor = "Azul";

            Console.WriteLine("A potencia da lâmpada é: " + lamp1.getPotencia);
            Console.WriteLine("A cor da lâmpada é: " + lamp1.getCor);

        }

    }
}