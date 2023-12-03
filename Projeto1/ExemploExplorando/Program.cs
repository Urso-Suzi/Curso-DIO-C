using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");

Pessoa p2 = new Pessoa(nome:"Pedro", sobrenome:"Vinícius");




Curso CursoDePortugues = new Curso();
CursoDePortugues.Nome = "Português";
CursoDePortugues.Alunos = new List<Pessoa>();

CursoDePortugues.AdicionarAluno(p1);
CursoDePortugues.AdicionarAluno(p2);
CursoDePortugues.ObterQuantidadeDeAlunosMatriculados();
CursoDePortugues.ListarAlunos();





























// Pessoa p1 = new Pessoa();

// p1.Nome = "Pedro";
// p1.Sobrenome = "Vinícius";
// p1.Idade = 23;
// p1.Apresentar();
