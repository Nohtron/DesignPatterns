using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities.Discounts
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto ProximoDesconto { get ; set ; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
                return ProximoDesconto.Desconta(orcamento);
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
