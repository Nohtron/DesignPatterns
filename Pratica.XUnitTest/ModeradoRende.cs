using Alura.DesignPatterns.App.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pratica.XUnitTest
{
    public class ModeradoRende
    {

        [Fact]
        public void RetornaValorInvestidoDadoUmaContaBancariaComUmachanceDeBaixoRetorno()
        {
            // Arrange
            var conta = new Conta(1000.0);
            var estrategia = new Moderado(conta);

            // Act
            var rendimento = estrategia.CalcularRendimento(40);

            // Assert
            rendimento.Should().Be(7.0);
        }

        [Fact]
        public void RetornaValorInvestidoDadoUmaContaBancariaComUmachanceDeAltoRetorno()
        {
            // Arrange
            var conta = new Conta(1000.0);
            var estrategia = new Moderado(conta);

            // Act
            var rendimento = estrategia.CalcularRendimento(60);

            // Assert
            rendimento.Should().Be(25.0);
        }

    }
}
