using Alura.DesignPatterns.App.Interfaces;
using System;

namespace Alura.DesignPatterns.App.Entities
{
    public class CalculadorDeImposto
    {
        Orcamento _orcamento;
        IImposto _imposto;

        public CalculadorDeImposto(Orcamento orcamento, IImposto imposto)
        {
            _orcamento = orcamento;
            _imposto = imposto;
        }

        public decimal CalculaImposto()
        {
            return _imposto.Calcula(_orcamento);
        }
    }
}
