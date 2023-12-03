using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        private int _idade;
        private string _nome;
        public String Nome 
        { 
            get  => _nome.ToUpper();
            
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Nome, não pode estar vazio, por favor insira novamente.");
                }

                _nome = value;
            }
            
        }

        public String Sobrenome { get; set; }
        public String NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade { 
            
         get => _idade;
            
        
        set
        {
            if(value <= 0) 
            {
                throw new ArgumentException("A idade não pode ser zero ou menor.");
            } 

            _idade = value;
            
        }
       
        }

        public void Apresentar() 
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}