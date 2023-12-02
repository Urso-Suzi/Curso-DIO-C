



List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");


Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($" Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");





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