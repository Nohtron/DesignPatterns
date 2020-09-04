using Alura.DesignPatterns.App.Entities;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Pratica.XUnitTest
{
    public class ICMSCalcula
    {
        [Fact]
        public void DeveRetornarCincoPorCentoDadoUmOrcamentoComValorValido()
        {
            // Arrange
            var orcamento = new Orcamento((decimal)1000.0);
            var icms = new ICMS();

            // Act
            var impostoCalculado = icms.Calcula(orcamento);

            // Assert
            var valorEsperado = (decimal)(1000.0 * 0.05 + 50.0);
            impostoCalculado.Should().Be(valorEsperado);
        }

    }
}
