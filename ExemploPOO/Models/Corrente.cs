using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Foi adicionado o valor de {valor}, a sua conta");
        }
    }
}