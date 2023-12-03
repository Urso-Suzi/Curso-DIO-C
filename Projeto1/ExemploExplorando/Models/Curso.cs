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
           Console.WriteLine($"{Alunos.Count()} Aluno(os) adicionado(os).");
            
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
            Console.WriteLine($"Alunos do Curso de: {Nome}");
            foreach (Pessoa  aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }


}