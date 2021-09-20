using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluno {
    class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.n1 = int.Parse(Console.ReadLine());
            a.n2 = int.Parse(Console.ReadLine());
            a.n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final = " + a.NotaFinal());

            if(a.Avaliacao()) {
                Console.WriteLine("Aprovado");
            }
            else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + a.NotaRestante() + " pontos");
            }




        }
    }
}
