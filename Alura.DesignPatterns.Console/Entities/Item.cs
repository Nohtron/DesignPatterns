namespace Alura.DesignPatterns.App.Entities
{
    public class Item
    {
        public string Nome { get; set; }
        public double Valor;

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}