using Alura.DesignPatterns.App.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pratica.XUnitTest
{
    public class ConservadorRende
    {
        [Fact]
        public void RetornaValorInvestidoDadoUmaContaBancaria()
        {
            // Arrange
            var conta = new Conta(1000.0);
            var estrategia = new Conservador(conta);

            // Act
            var rendimento = estrategia.CalcularRendimento(100);

            // Assert
            rendimento.Should().Be(8.0);
        }

    }
}
