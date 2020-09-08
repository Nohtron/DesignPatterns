using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities.Discounts
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto Desconto1 = new DescontoPorMaisDeUmValor();
            IDesconto Desconto2 = new DescontoPorVendaCasada();
            IDesconto Desconto3 = new DescontoPorMaisQueUmaQuantidadeDeItens();
            IDesconto SemDesconto = new SemDesconto();

            Desconto1.ProximoDesconto = Desconto2;
            Desconto2.ProximoDesconto = Desconto3;
            Desconto3.ProximoDesconto = SemDesconto;

            return Desconto1.Desconta(orcamento);
        }        
    }
}
