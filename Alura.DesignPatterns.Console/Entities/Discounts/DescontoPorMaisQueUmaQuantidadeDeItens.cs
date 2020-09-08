using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities.Discounts
{
    public class DescontoPorMaisQueUmaQuantidadeDeItens : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return (double)orcamento.Valor * 0.1;
            else
                return ProximoDesconto.Desconta(orcamento);

        }
    }
}
