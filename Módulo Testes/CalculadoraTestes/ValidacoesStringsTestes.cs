using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringsTestes
    {
        private ValidacoesStrings _validacoes;

        public ValidacoesStringsTestes()
        {   
            _validacoes = new ValidacoesStrings();
        }

        [Fact]
         public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string texto = "Olá";

            // Act
            int resultado = _validacoes.ContarCaracteres(texto);

            // Assert

            Assert.Equal(3, resultado);
        }
    }
}