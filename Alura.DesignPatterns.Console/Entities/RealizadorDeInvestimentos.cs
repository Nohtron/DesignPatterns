using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class RealizadorDeInvestimentos
    {
        private IPerfil _estrategia { get; set; }
        private Conta _conta { get; set; }

        public RealizadorDeInvestimentos(IPerfil estrategia, Conta conta)
        {
            _estrategia = estrategia;
            _conta = conta;
        }


        public void RealizaInvestimento(Conta conta, IPerfil estrategia)
        {
            double chance = new Random().Next(101);

            double rendimento = estrategia.CalcularRendimento(chance);

            rendimento -= rendimento * 0.75;

            _conta.Depositar(rendimento);
        }
    }
}
