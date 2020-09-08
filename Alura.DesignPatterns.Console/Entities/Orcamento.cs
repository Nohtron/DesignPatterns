using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
