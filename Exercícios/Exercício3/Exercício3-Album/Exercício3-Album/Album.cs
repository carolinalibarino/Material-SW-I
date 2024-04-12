using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3_Album
{
    internal class Album
    {
        public double NumeroFotos { get; set; }
        public double FotosPagina { get; set; }
        public double Restante { get; set; }

        public double Div {  get; set; }

        public string NumeroDePaginas()
        {

            Console.WriteLine("Digite quantas fotos você vai usar");
            NumeroFotos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite quantas fotos por página você quer");
            FotosPagina = Convert.ToDouble(Console.ReadLine());

            Restante = NumeroFotos % FotosPagina;
            Div = (NumeroFotos / FotosPagina) - 0.5;

            if (Restante == 1)
            {
                return "Você pode colocar " + Div + " e vai sobrar " + Restante + " fotos";
            }
            else
            {
                return "Você pode colocar " + NumeroFotos / FotosPagina + " fotos por página";
            }
        }
    }
}
