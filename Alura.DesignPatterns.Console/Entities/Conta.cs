namespace Alura.DesignPatterns.App.Entities
{
    public class Conta
    {
        public double Saldo { get; private set; }

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(double quantidade)
        {
            Saldo += quantidade;
        }
    }
}