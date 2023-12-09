

using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
        string [] nomesJogos = new string [quantidadeJogos];

        // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
       
        for ( int i = 0; i < nomesJogos.Length; i++)
        {
            AdicionarJogo(i, nomesJogos);
        }

        //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
       
       

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

     static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
     {
          Console.WriteLine($"Foi adicionado '{quantidadeJogos}' Jogos: {string.Join(", ", nomes)} ao catalogo.");
     }
    
 }























// using System;

// class Program
// {
//     static void Main()
//     {
//     // Solicita ao usuário os limites inferiores e superiores
//     int limiteInferior = int.Parse(Console.ReadLine());
//     int limiteSuperior = int.Parse(Console.ReadLine());

//     // Variável para acumular a soma dos números pares
//     int somaPares = 0;

//     // TODO: Crie um Loop para percorrer os números no intervalo
//     // Lembre-se: O limiteSuperior deve ser menor ou igual a i;
//     for (int i = limiteInferior; i <= limiteSuperior; i++)
//   {
//       if(i % 2 == 0) 
//       {
//         somaPares += i;  
//       }
//     }
//     // TODO: Implemente o if para verificar se o número é par:
        
    
//     // TODO: Crie o acumulador para a soma dos números pares:
           
    

//     // Exibe o resultado
//     Console.WriteLine($"A soma dos numeros pares de {limiteInferior} a {limiteSuperior} e: {somaPares}");
//     }
// }





















// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");


// Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");





// Console.WriteLine("Percorrendo com For");
// for(int i = 1; i < listaString.Count; i++)
// {
//     Console.WriteLine($"Posição N° {i} - {listaString[i]}");
// }

// Console.WriteLine("Percorrendo com ForEach");
// int contadorForEach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForEach} - {item}");
//     contadorForEach++;
// }





























// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// Console.WriteLine("Percorrendo um array com for");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//      Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
//  }



// int contadorForEach = 0;
// Console.WriteLine("Percorrendo um array com foreach");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForEach} - {valor}");
//     contadorForEach++;
// }