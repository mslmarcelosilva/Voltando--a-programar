using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar {
    class Program {
        static void Main(string[] args) {

            ConversorDeMoedas c = new ConversorDeMoedas();

            Console.WriteLine("Qual é a cotação do dolar?");
            c.Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dolares você vai comprar?");
            c.Quantidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor a ser pago em reais = R$" + c.Cotacao().ToString("F2"));
        }
    }
}
