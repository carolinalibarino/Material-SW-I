using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    internal class Aviao
    {
     
        public string? Compania { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }
        public int Altura { get; set; }






        public void Acelerar(int kmh)
        {
            Velocidade += kmh;

        }

        public void Desacelerar(int kmh)
        {
            if (kmh >= 0)
            {
                Velocidade -= kmh;
            }

            else
            {
                Velocidade = 0;
            }

        }
        public void Subir(int pes)
        {

            Altura += pes;

        }

        public void Descer(int pes)
        {
            if (pes >= 0)
            {
                Altura -= pes;
            }

            else
            {
                Altura = 0;
            }
        }



    }
}


