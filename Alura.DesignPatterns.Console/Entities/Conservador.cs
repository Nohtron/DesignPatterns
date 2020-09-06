using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.DesignPatterns.App.Entities
{
    public class Conservador : IPerfil
    {
        public Conta _conta { get; set; }

        public Conservador(Conta conta)
        {
            _conta = conta;
        }

        public double CalcularRendimento(double chance)
        {
            return 0.008 * _conta.Saldo;
        }
    }
}
