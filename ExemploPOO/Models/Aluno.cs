using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public Double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Ola, mue nome é {Nome} tenho {Idade} de idade e sou um aluno nota: {Nota}");
        }
    }
}