using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    public class Pagamento
    {
        public string? Nome { get; set; }
        public double Sal { get; set; }

        public double Hed { get; set; }

        public double Hen { get; set; }

        public double Nd { get; set; }

        public double Fal { get; set; }

        public double De { get; set; }

        public double Ref { get; set; }

        public double Val { get; set; }

        public string? Pag()
        {
            Console.WriteLine("Digite o nome do funcionário");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário");
            Sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite as horas extras diurnas: ");
            Hed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite as horas extras noturnas: ");
            Hen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de dependentes");
            Nd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o total de faltas em horas: ");
            Fal= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os descontos habituais: ");
            De = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite os gastos com refeições");
            Ref = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o total de vales retirados no mês: ");
            Val = Convert.ToDouble(Console.ReadLine());
            
            
            
            
            return Pag();
        }
    }
}
