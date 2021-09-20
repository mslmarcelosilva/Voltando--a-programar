using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWhile
{
    class AulaWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double n = double.Parse(Console.ReadLine());

            while (n >= 0)
            {
                double raiz = Math.Sqrt(n);
                Console.WriteLine(raiz.ToString("F3"));
                Console.WriteLine("Digite outro número: ");
                n = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo");
        }
    }
}
