using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class ISS : IImposto
    {
        public decimal Calcula(Orcamento orcamento)
        {
            return decimal.Multiply(orcamento.Valor, (decimal)0.06);
        }
    }
}
