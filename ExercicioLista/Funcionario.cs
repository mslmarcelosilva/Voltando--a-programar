﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista {
    class Funcionario {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncrementoSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString() {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2"); ;
        }
    }
}
