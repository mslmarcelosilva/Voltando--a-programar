using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSemOAO {
    class ExercicioSemOAO {
        static void Main(string[] args) {

            /*Com orientado a objeto*/
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Dígite as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Dígite as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areax = x.Area();
            double areay = y.Area();

            Console.WriteLine("Área X: " + areax);
            Console.WriteLine("Área Y: " + areay);

            if (areax > areay) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }

        }

    }

    /* Sem OAO
    class ExercicioSemOAO
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com as medidas separadas por espaço do trinângulo x: ");
            string[] x = Console.ReadLine().Split(' ');
            double x1 = double.Parse(x[0]);
            double x2 = double.Parse(x[1]);
            double x3 = double.Parse(x[2]);

            Console.Write("Entre com as medidas separadas por espaço do trinângulo y: ");
            string[] y = Console.ReadLine().Split(' ');
            double y1 = double.Parse(y[0]);
            double y2 = double.Parse(y[1]);
            double y3 = double.Parse(y[2]);

            double p = (x1 + x2 + x3) / 2;
            double areax = Math.Sqrt(p * (p - x1) * (p - x2) * (p - x3));

            double py = (y1 + y2 + y3) / 2;
            double areay = Math.Sqrt(py * (py - y1) * (py - y2) * (py - y3));

            Console.WriteLine("Área de X = " + areax.ToString("F4"));
            Console.WriteLine("Área de Y = " + areay.ToString("F4"));

            if (p > py)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
    */
}
