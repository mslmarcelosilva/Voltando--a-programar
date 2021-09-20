using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseTreino {
    class Program {
        static void Main(string[] args) {

            Retangulo r = new Retangulo();

            Console.WriteLine("Dígite a largura e altura do retângulo: ");
            Console.WriteLine("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Area: " + r.Area());
            Console.WriteLine("Perimetro: " + r.Perimetro());
            Console.WriteLine("Diagonal: " + r.Diagonal());
        }
    }
}
