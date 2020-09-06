using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class Moderado : IPerfil
    {
        private Conta _conta { get; set; }

        public Moderado(Conta conta)
        {
            _conta = conta;
        }

        public double CalcularRendimento(double chance)
        {
            if (chance > 50)
                return 0.025 * _conta.Saldo;
            else
                return 0.007 * _conta.Saldo;
        }
    }
}
