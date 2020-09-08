
using Alura.DesignPatterns.App.Entities;
using Alura.DesignPatterns.App.Entities.Discounts;
using System;

namespace Alura.DesignPatterns.App
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(1000.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("ESTOJO", 250.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
            orcamento.AdicionaItem(new Item("PAPEL", 250.0));
            orcamento.AdicionaItem(new Item("MOCHILA", 250.0));

            double desconto = calculadorDeDescontos.Calcula(orcamento);

            Console.WriteLine(desconto);
        }
    }
}
