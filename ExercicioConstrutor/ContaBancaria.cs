using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConstrutor {
    class ContaBancaria {

        private double Taxa = -5;

        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Deposito { get; set; }

        public ContaBancaria() { }

        public ContaBancaria(int conta, string nome) {
            Conta = conta;
            Nome = nome;
        }

        public ContaBancaria(int conta, string nome, double deposito) : this(conta, nome) {
            IncrementaDeposito(deposito);
        }

        public void IncrementaDeposito(double aumento) {
            Deposito += aumento;
        }

        public void Saque(double saque) {
            Deposito -= saque - Taxa;
        }

        public override string ToString() {
            return "Conta "
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Deposito.ToString("F2");
        }
    }
}


