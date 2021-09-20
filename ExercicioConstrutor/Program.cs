using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutor {
    class Program {
        static void Main(string[] args) {

            ContaBancaria c1 = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string pergunta = Console.ReadLine();
            double deposito;
            if(pergunta == "s" || pergunta == "S") {
                Console.Write("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());
                c1 = new ContaBancaria(conta, nome, deposito);
            }
            else {
                c1 = new ContaBancaria(conta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            c1.IncrementaDeposito(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            c1.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(c1);
            Console.WriteLine();

        }
    }
}
