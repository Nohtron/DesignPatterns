using Alura.DesignPatterns.App.Entities;
using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pratica.XUnitTest
{
    public class CalculadoDeImpostoCalculaImposto
    {
        [Fact]
        public void RetornaImpostoDoISSDadoUmImpostoDeISSComUmOrcamentoValido()
        {
            // Arrange
            var valor = (decimal)1000.0;
            var orcamento = new Orcamento(valor);
            var imposto = new ISS();
            var calculadorDeImposto = new CalculadorDeImposto(orcamento, imposto);

            // Act
            var impostoCalculado = calculadorDeImposto.CalculaImposto();

            // Assert
            var impostoEsperado = decimal.Multiply(valor, (decimal)0.06);
            Assert.Equal(impostoEsperado, impostoCalculado);
        }

        [Fact]
        public void RetornaImpostoDoCMSDadoUmImpostoDeICMSComUmOrcamentoValido()
        {
            // Arrange
            var valor = (decimal)1000.0;
            var orcamento = new Orcamento(valor);
            var imposto = new ICMS();
            var calculadorDeImposto = new CalculadorDeImposto(orcamento, imposto);

            // Act
            var impostoCalculado = calculadorDeImposto.CalculaImposto();

            // Assert
            var impostoEsperado = decimal.Add(decimal.Multiply(valor, (decimal)0.05), (decimal)50.0);
            Assert.Equal(impostoEsperado, impostoCalculado);
        }


        [Theory]
        [InlineData(100.0, 1000.0)]
        public void RetornaImpostoUsadoDadoUmImpostoDeICMSComUmOrcamentoValido(decimal impostoEsperado, decimal valorOrcamento)
        {
            // Arrange
            var orcamento = new Orcamento(valorOrcamento);
            var imposto = new ICMS();
            var calculadorDeImposto = new CalculadorDeImposto(orcamento, imposto);

            // Act
            var impostoCalculado = calculadorDeImposto.CalculaImposto();

            // Assert
            Assert.Equal(impostoEsperado, impostoCalculado);
        }

    }
}
