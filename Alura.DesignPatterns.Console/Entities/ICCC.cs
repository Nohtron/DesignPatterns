using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class ICCC : IImposto
    {
        public decimal Calcula(Orcamento orcamento)
        {
            if (decimal.Compare((decimal)orcamento.Valor, (decimal)1000.0) == -1)
            {
                return decimal.Multiply((decimal)orcamento.Valor, (decimal)0.05);
            }
            else if (decimal.Compare((decimal)orcamento.Valor, (decimal)3000.0) <= 1)
            {
                return decimal.Multiply((decimal)orcamento.Valor, (decimal)0.07);
            }
            else
            {
                return decimal.Add(decimal.Multiply((decimal)orcamento.Valor, (decimal)0.08), (decimal)30.0);
            }
        }
    }
}
