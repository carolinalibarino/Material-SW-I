using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        private float saldo_limite;

        private string? Num_Conta { get; set; }
        private float Saldo { get; set; }
        private float Limite { get; set; }


        public float consulta_saldo()
        {
            return Saldo;
        }


        public void deposito(float valor_deposito)
        {
            Saldo += valor_deposito;
            Console.WriteLine("Seu saldo é de R$" + consulta_saldo());
        }


        public void sacar (float valor_saque)
        {
            if(valor_saque > saldo_limite)
            {
                Console.WriteLine("Seu saldo não é suficiente");
            }

            else{
                Saldo -= valor_saque;
                Console.WriteLine("Seu saldo é de R$" + consulta_saldo());
            }

        }

        public void ajustar_limite(float valor_limite)
        {
            Limite = valor_limite;
            Console.WriteLine("Seu limite é de R$" + Limite);
            saldo_limite = Limite + Saldo;
            Console.WriteLine("Seu saldo+limite é de R$" + saldo_limite);

        }

    }
}

