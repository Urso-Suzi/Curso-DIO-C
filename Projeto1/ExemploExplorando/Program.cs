﻿using ExemploExplorando.Models;
using System.Globalization;




Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila) 
{
        Console.WriteLine(item);
}

fila.Dequeue();
































// new ExemploExcecao().Metodo1();



// try 
// {
// string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
//  catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho não encontrado. {ex.Message}");
// }
//  catch(Exception ex)
// {
//     Console.WriteLine($"ocorreu uma exceção, generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou aqui!");
// }

















// String dataString = "2022-12-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma datas válida");
// }


// Console.WriteLine(data);



// // Console.WriteLine(data.ToShortDateString());
// // Console.WriteLine(data.ToShortTimeString());









// Console.WriteLine(data.ToString("dd/mm/yyyy HH:mm"));
// Console.WriteLine(data.ToString("mm/dd/yyyy"));
// Console.WriteLine(data.ToString("yy-mm-dd"));



















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");


// decimal valorMonetario = 82.40M;

// Console.WriteLine(valorMonetario.ToString("N3"));

// double porcentagem = .3423;

// Console.WriteLine(porcentagem.ToString("P"));


// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));










// string numero1 = "10";
// String numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);




// Pessoa p1 = new Pessoa(nome:"Leonardo", sobrenome:"Buta");

// Pessoa p2 = new Pessoa(nome:"Pedro", sobrenome:"Vinícius");



// Curso CursoDePortugues = new Curso();
// CursoDePortugues.Nome = "Português";
// CursoDePortugues.Alunos = new List<Pessoa>();

// CursoDePortugues.AdicionarAluno(p1);
// CursoDePortugues.AdicionarAluno(p2);
// CursoDePortugues.ListarAlunos();




// Pessoa p1 = new Pessoa();

// p1.Nome = "Pedro";
// p1.Sobrenome = "Vinícius";
// p1.Idade = 23;
// p1.Apresentar();
