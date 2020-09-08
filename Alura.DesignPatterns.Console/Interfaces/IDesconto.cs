using Alura.DesignPatterns.App.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Interfaces
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        public IDesconto ProximoDesconto { get; set; }
    }
}
