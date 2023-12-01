

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;


//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int [] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



Console.WriteLine("Percorrendo um array com for");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
 }



// int contadorForEach = 0;
// Console.WriteLine("Percorrendo um array com foreach");
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForEach} - {valor}");
//     contadorForEach++;
// }