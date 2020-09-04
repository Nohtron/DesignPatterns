using Alura.DesignPatterns.App.Entities;
using FluentAssertions;
using Xunit;

namespace Pratica.XUnitTest
{
    public class ICCCCalcula
    {

        [Theory]
        [InlineData(5.0 , 100.0)]
        [InlineData(25.0, 500.0)]
        [InlineData(49.95, 999.0)]
        public void DeveRetornarCincoPorCentoDadoUmOrcamentoComValorValidoInferiorAUmMil(decimal valorEsperado, decimal valor)
        {
            // Arrange
            var orcamento = new Orcamento(valor);
            var iccc = new ICCC();

            // Act
            var impostoCalculado = iccc.Calcula(orcamento);

            // Assert
            impostoCalculado.Should().Be(valorEsperado);
        }

        [Theory]
        [InlineData(70.0, 1000.0)]
        [InlineData(140.0, 2000.0)]
        [InlineData(210.0, 3000.0)]
        public void DeveRetornarSetePorCentoDadoUmOrcamentoComValorEntreUmMilETresMilLimitesInclusos(decimal valorEsperado, decimal valor)
        {
            // Arrange
            var orcamento = new Orcamento(valor);
            var iccc = new ICCC();

            // Act
            var impostoCalculado = iccc.Calcula(orcamento);

            // Assert
            Assert.Equal(valorEsperado, impostoCalculado);
        }
    }
}
