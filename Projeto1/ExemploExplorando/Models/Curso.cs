using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public String Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

           Console.WriteLine($"Aluno: {Alunos.Last().NomeCompleto} adicionado.");
            
        }

        public void ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
             Console.WriteLine($"Total de alunos: {quantidade}");
        }

        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
            
        }


        public void ListarAlunos() 
        {
            Console.WriteLine($"Total de Alunos do Curso de: {Nome} : {Alunos.Count}");
            
            for (int count = 0; count < Alunos.Count; count++)
            {
                
                //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }


}