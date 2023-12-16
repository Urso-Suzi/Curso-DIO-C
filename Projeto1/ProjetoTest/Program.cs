using System;

class Personagem
{
    public string Nome { get; set; }
    public int Mana { get; set; }

    public Personagem(string nome, int mana)
    {
        Nome = nome;
        Mana = mana;
    }
}

class Subclasse : Personagem
{
    public int dano_base { get; set; }

    public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
    {
        dano_base = danoBase;
    }

    public void calcular_dano()
    {
        Console.WriteLine(Nome + " atacou e causou " + dano_base * Mana + " de dano!");
    }
}

class Program
{
    static void Main()
    {
       
       string nome = Console.ReadLine();
       int mana = int.Parse(Console.ReadLine());
       int dano = int.Parse(Console.ReadLine());
    
       Subclasse sub1 = new Subclasse(nome = nome, mana = mana, dano = dano);
       sub1.calcular_dano();
    }
}































// using System;

// class Personagem
// {
//     public string Nome { get; set; }
//     public string Raca { get; set; }
//     public string Classe { get; set; }
//     public int Nivel { get; set; } = 1;
//     public int Vida { get; set; } = 10;

//     public Personagem(string nome, string raca, string classe)
//     {
//         Nome = nome;
//         Raca = raca;
//         Classe = classe;
//     }

//     public void exibir_status()
//     {
//         Console.WriteLine("Status:");
//         Console.WriteLine($"Nome:{Nome}");
//         Console.WriteLine($"Raça:{Raca}");
//         Console.WriteLine($"Classe:{Classe}");
//         Console.WriteLine($"Nível:{Nivel}");
//         Console.WriteLine($"Vida:{Vida}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string nome = Console.ReadLine();
//         string raca = Console.ReadLine();
//         string classe = Console.ReadLine();


//         Personagem p1 = new Personagem(nome = nome, raca = raca, classe = classe);

//         p1.exibir_status();
//     }
// }





































// using System;
// using System.Security.Cryptography.X509Certificates;

// class Jogador
// {
//     public string Nome { get; set; }
//     public string Nacionalidade { get; set; }
//     public int Idade { get; set; }
//     public string Posicao { get; set; }

//     public void  novo()
//     {
//         Console.WriteLine("Jogador criado!");
//         Console.WriteLine($"{Nome}");
//         Console.WriteLine($"{Nacionalidade}");
//         Console.WriteLine($"{Idade}");
//         Console.WriteLine($"Posição: {Posicao}");
        
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Jogador j1 = new Jogador();
//         j1.Nome = Console.ReadLine();
//         j1.Nacionalidade = Console.ReadLine();
//         j1.Idade = int.Parse(Console.ReadLine());
//         j1.Posicao = Console.ReadLine();

//         j1.novo();
//     }
// }

































using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
         string[] texto = Console.ReadLine().Split(" ");
         int n1 = int.Parse(texto[0]), n2 = int.Parse(texto[1]);
        string texto2 = Console.ReadLine();
        char[] vel = texto2.ToCharArray();
        
         Robo r1 = new Robo(n1, n2);
        

       foreach(char items in vel)
        {   
            string letra = items.ToString();
           
        
             if(letra == "A")
             {
                r1.Acelerar();
            }
               else if (letra =="D")
            {
             r1.Desacelerar();
            }

            
           
        }
        
         Console.WriteLine(r1.VelocidadeAtual);
    }
}


























// using System;

// class Robo
// {
//     public int VelocidadeAtual { get; set; } = 0;
//     public int VelocidadeMaxima { get; }
//     public int VelocidadeMinima { get; }

//     public Robo(int vmin, int vmax)
//     {
//         VelocidadeMinima = vmin;
//         VelocidadeMaxima = vmax;
//         VelocidadeAtual = vmin;
//     }

//     public void Acelerar()
//     {
//         if (VelocidadeAtual < VelocidadeMaxima)
//         {
//             VelocidadeAtual++;
//         }
//     }

//     public void Desacelerar()
//     {
//         if (VelocidadeAtual > VelocidadeMinima)
//         {
//             VelocidadeAtual--;
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         string[] texto = Console.ReadLine().Split(" ");
//         int n1 = int.Parse(texto[0]), n2 = int.Parse(texto[1]);
//         string entrada = Console.ReadLine();
//         var vel = entrada.ToList();
        
//         Robo r1 = new Robo(n1, n2);
        
//         foreach(var items in vel)
//         {
//            string letra = items.ToString();
           
//            if(letra == "A")
//            {
//               r1.Acelerar();
//            }
//            else if (letra =="D")
//            {
//              r1.Desacelerar();
//            }
           
//         }
        
//         Console.WriteLine(r1.VelocidadeAtual);
//     }
// }




























// using System;


// class Pessoa
// {
 
//     public string nome {get; set; }
//     public int idade {get; set; }

//     public Pessoa(string n, int i)
//     {
//         nome = n;
//         idade = i;
//     }
//     public void  GetNome()
//     {

//         Console.WriteLine(nome);
//     }

//     public void GetIdade()
//     {
//         Console.WriteLine(idade);
//     }
// }
// class Program
// {
//     static void Main()
//     {
        
//         string  nome = Console.ReadLine();
//         int Idade = int.Parse(Console.ReadLine());

//         Pessoa p1 = new Pessoa(nome, Idade);

//         Console.WriteLine($"Nome:{p1.nome}, Idade:{p1.idade}");

//     }
// }











// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastras cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case"1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case"2":
//             Console.WriteLine("Busca de cliente");
//             break;
//         case"3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case"4":
//             Console.WriteLine("Encerrar");
//             //Environment.Exit(0);
//             exibirMenu = false;
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }

// }

// Console.WriteLine("O programa fechou");















// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total de soma dos números digitados é {soma}");





























// int numero = 5;
// int contador = 0;



// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}º Execução:{numero} x {contador} = {numero * contador}");
//     contador++;
// }








// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }















/*
//Calculadora calc = new Calculadora();
// calc.Somar(3, 5);
// calc.Subtrair(3, 5);
// calc.Dividir(4, 2);
// calc.Multiplicar(3, 5);
// calc.Potencia(3, 3);
// calc.Coseno(30);
// calc.Seno(30);
// calc.Tangente(30);
//calc.RaizQuadrada(9);
*/


/*
bool eMaiorDeIdade = true;
bool PossuiAutorizacaoDoResponsavel = false;

if (eMaiorDeIdade || PossuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Entrada não liberada");
}
*/

/*
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine().ToLower();

// switch (letra)
// {
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//       Console.WriteLine("É uma Vogal");
//       break;
//    default:
//       Console.WriteLine("Não é uma Vogal");
//       break;
// }

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("É uma vogal");
// }
// else
// {
//     Console.WriteLine("Não é vogal");
// }
*/

/*
 Pessoa p = new Pessoa();

 p.Nome = "Ricardo";
 p.Idade = 21;
 p.Cidade = "Fortaleza";
 p.Apresentar();

 Pessoa p1 = new Pessoa();
 p1.Nome = "Jeovan";
 p1.Idade = 45;
 p1.Cidade = "São Paulo";
 Console.WriteLine(p1.Nome);

 string apresentacao = "Olá, Seja bem Vindo";

 int quantidade = 1;

 double altura = 1.50;

 decimal preco = 1.50M;

 bool condicao = true;

 Console.WriteLine(apresentacao);
 Console.WriteLine("Valor da variável quantidade: " + quantidade);
 Console.WriteLine("Valor da variável altura: " + altura);
 Console.WriteLine("Valor da variável preco: " + preco.ToString());
 Console.WriteLine("Valor da variável condicao: " + condicao);


DateTime dataAtual = DateTime.Now.AddDays(2);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

/*

 int a = 10;
 int b = 20;

int c = a + b;

c += 5; / c = c + 5;

 Console.WriteLine(c);

 c -= 5;

 Console.WriteLine(c);



 Cast ou Casting, converter string para inteiro

string cinco = "5";
int a = Convert.ToInt32(null);

int a = int.Parse(null);

Console.WriteLine(a);

int inteiro = 5;

string a = inteiro.ToString();
 Console.WriteLine(a);


 double a = 5;
 int b = Convert.ToInt32(a);


 long a = long.MaxValue;

int b = Convert.ToInt32(a);

 Console.WriteLine(b);
/*

// // double a =  2 / 4 + (5 - 1);

// // Console.WriteLine(a);


// // string a = "23 -";

// // int b = 0;

// // int.TryParse(a, out b);

// // Console.WriteLine(b);
// // Console.WriteLine("Conversão realizada com sucesso.");





// // int quantidadeEmEstoque = 3;

// // int quantidadeCompra = 0;

// // bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;


// // Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// // Console.WriteLine($"Quantidade da compra: {quantidadeCompra}");
// // Console.WriteLine($"É possível realizar a compra ? {possivelVenda}");



// // if (quantidadeCompra == 0) 
// // {
// //     Console.WriteLine($"Venda inválida, quantidade de compra é: {quantidadeCompra}");
// // }
// // else if (possivelVenda)
// // {
// //     Console.WriteLine("Venda realizada");
// // }
// // else
// // {
// //    Console.WriteLine("Desculpe. Não temos a quantidade desejada.");
// // }
*/