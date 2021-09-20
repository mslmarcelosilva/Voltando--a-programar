using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasse {
    class Program {
        static void Main(string[] args) {

            Produto prod = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.WriteLine("Preco: ");
            prod.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados do produto: " + prod);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            prod.AdicionarProdutos(qtde);
            Console.WriteLine("Dados atualizads: " + prod);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos ao estoque: ");
            qtde = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(qtde);
            Console.WriteLine("Dados atualizads: " + prod);

        }
    }
}
