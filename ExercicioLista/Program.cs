using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionários serão cadastrados? ");
            int controle = int.Parse(Console.ReadLine());

            List < Funcionario > lista = new List<Funcionario>();

            for (int i = 1; i <= controle; i++) {
                Console.WriteLine("Funcionário #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add (new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o id do funionário que receberá o aumento: ");
            int LocalizarId = int.Parse(Console.ReadLine());

            Funcionario emp = lista.Find(x => x.Id == LocalizarId);
            if(emp != null) {

                Console.Write("Entre com o percentual: ");
                double porcentagem = double.Parse(Console.ReadLine());
                emp.IncrementoSalario(porcentagem);
            }
            else {
                Console.WriteLine("Não existe esse id!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada dos funcionários");
            foreach (Funcionario objeto in lista) {
                Console.WriteLine(objeto);
            }

        }
    }
}
