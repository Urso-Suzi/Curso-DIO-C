using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudo_C_.Models
{
    public class Pessoa
    {   
        public string Nome  { get; set; } = string.Empty;
        public int Idade { get; set; } 

        public string Cidade { get; set; } = string.Empty;

        public void Apresentar() 
        {
            Console.WriteLine($"Olá meu nome é {Nome} \ne tenho {Idade} anos, e sou de {Cidade}");
        }
    }
}