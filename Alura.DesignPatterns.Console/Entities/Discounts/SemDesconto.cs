using Alura.DesignPatterns.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities.Discounts
{
    class SemDesconto : IDesconto
    {
        public IDesconto ProximoDesconto { get; set; } = null;

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
