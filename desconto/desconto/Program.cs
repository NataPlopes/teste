using System;

namespace desconto
{

    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double CalcularValorTotal()
        {
            double valorTotal = Preco * Quantidade;

            if (Quantidade <= 10)
            {
                return valorTotal;
            }
            else if (Quantidade <= 20)
            {
                return valorTotal * 0.9; // 10% de desconto
            }
            else if (Quantidade <= 50)
            {
                return valorTotal * 0.8; // 20% de desconto
            }
            else
            {
                return valorTotal * 0.75; // 25% de desconto
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Digite o nome do produto:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());

            double valorTotal = produto.CalcularValorTotal();
            Console.WriteLine($"Valor total do pedido: R${valorTotal:F2}");
        }
    }
}