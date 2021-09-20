using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAluno {
    class Aluno {
        public string Nome;
        public int n1, n2, n3;

        public int NotaFinal() {
            return n1 + n2 + n3;
        }

        public bool Avaliacao() {
            if(NotaFinal() >= 60) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotaRestante() {
            if(Avaliacao()) {
                return 0.0;
            }
            else {
                return 60 - NotaFinal();
            }
        }
    }
}
