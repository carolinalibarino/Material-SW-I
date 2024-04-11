using System;

namespace Aviao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aviao Aviao = new Aviao();

            Aviao.Compania = "Azul";
            Aviao.Modelo = "Airbus A330";
            Aviao.Acelerar(40);
            Aviao.Cima(12500);

            Console.WriteLine("Senhores passageiros, muito obrigada por escolher a compania " + Aviao.Compania +
                ", estamos voando no avião " + Aviao.Modelo + ". Nosso avião esta a " + Aviao.Altura +
                " metros, em uma velocidade de " + Aviao.Velocidade + " km/h");
            Console.WriteLine("Uma otima viagem a todos!");

        }

    }

}
