using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class ICMS : IImposto
    {
        public decimal Calcula(Orcamento orcamento)
        {
            return decimal.Add(decimal.Multiply((decimal)orcamento.Valor, (decimal)0.05), (decimal)50.0);
        }
    }
}
