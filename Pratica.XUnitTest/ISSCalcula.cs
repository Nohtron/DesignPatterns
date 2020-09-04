using Alura.DesignPatterns.App.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace Pratica.XUnitTest
{
    public class ISSCalcula
    {
        [Fact]
        public void DeveRetornarSeisPorCentoDadoUmaValorDeOrcamento()
        {
            // Arrange
            Orcamento orcamento = new Orcamento((decimal)1000.0);
            ISS iss = new ISS();

            // Act
            var impostoCalculado = iss.Calcula(orcamento);

            // Assert
            var valorEsperado = (decimal)(1000.0 * 0.06); // 6%
            impostoCalculado.Should().Be(valorEsperado);
        }
    }
}
