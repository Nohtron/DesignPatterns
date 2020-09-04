using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class Orcamento
    {
        public decimal Valor { get; private set; }

        public Orcamento(decimal valor)
        {
            Valor = valor;
        }
    }
}
