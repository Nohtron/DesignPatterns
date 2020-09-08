using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities.Discounts
{
    public class DescontoPorMaisDeUmValor : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return (double)orcamento.Valor * 0.07;
            else
                return ProximoDesconto.Desconta(orcamento);
        }
    }
}
