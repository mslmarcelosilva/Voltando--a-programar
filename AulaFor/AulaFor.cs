using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaFor
{
    class AulaFor
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai dígitar?:");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1;  i<=n ; i++)
            {
                Console.WriteLine("Digite um número");
                int n1 = int.Parse(Console.ReadLine());
                soma += n1;   
            }
            Console.WriteLine("Resultado da soma: "+ soma);
        }
    }
}
