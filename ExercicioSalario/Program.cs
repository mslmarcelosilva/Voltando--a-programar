using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSalario {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine());
            f.AumentarSalario(porc);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);

        }
    }
}
