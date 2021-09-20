using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AulaEntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = Math.PI * Math.Pow(78, 3);
            Console.WriteLine(a);

            Console.WriteLine("Entre com seu nome completo: ");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split();
            string nome2 = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(nome1);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
