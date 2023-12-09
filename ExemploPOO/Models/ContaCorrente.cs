using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente (int numeroConta, decimal saldoInical)
        {
            NumeroConta = numeroConta;
            saldo = saldoInical;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar (decimal valor)
        {

            if (saldo >= valor )
            {
            saldo -= valor;
            Console.WriteLine($"Saque de {valor}, realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"O valor desejado: {valor} é meior que o saldo disponível.");
            }
        }

        public void ExibidSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}");
        }

        public void Depositar(decimal deposito)
        {
            saldo += deposito;
            Console.WriteLine($"Foi realizado um deposito de {deposito}, e o seu saldo aumentou!");
        }
    }
}