using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOAO {
    class Program {
        static void Main(string[] args) {
            Funcionarios f1, f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salario: R$");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salario: R$");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salário Médio =  R$" + media.ToString("F2"));
        }
    }
}
/* Exercicio 1
  class Program {
     static void Main(string[] args) {

         Pessoa p1, p2;
         p1 = new Pessoa();
         p2 = new Pessoa();

         Console.WriteLine("Dados da primeira pessoa:");
         Console.Write("Nome: ");
         p1.Nome = Console.ReadLine();
         Console.WriteLine("Idade: ");
         p1.Idade = int.Parse(Console.ReadLine());

         Console.WriteLine("Dados da seunda pessoa:");
         Console.Write("Nome: ");
         p2.Nome = Console.ReadLine();
         Console.WriteLine("Idade: ");
         p2.Idade = int.Parse(Console.ReadLine());

         if (p1.Idade > p2.Idade) {
             Console.WriteLine("Pessoa mais velha: " + p1.Nome);
         }
         else {
             Console.WriteLine("Pessoa mais velha: " + p2.Nome);
         }
     }
 }
*/
