using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class Arrojado : IPerfil
    {
        private Conta _conta { get; set; }

        public Arrojado(Conta conta)
        {
            _conta = conta;
        }

        public double CalcularRendimento(double chance)
        {
            if (chance > 80)
                return 0.05 * _conta.Saldo;
            else if (chance > 50)
                return 0.03 * _conta.Saldo;
            else
                return 0.006 * _conta.Saldo;
        }
    }
}

