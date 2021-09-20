using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDolar {
    class ConversorDeMoedas {

        public double Dolar;
        public double Quantidade;
        public static double Iof = 0.06;

        public double Imposto() {
            return Dolar * Quantidade * Iof;
        }

        public double Cotacao() {
            return Dolar * Quantidade + Imposto();
        }
    }
}
