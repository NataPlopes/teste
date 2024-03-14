using System;

namespace atividade_retangulo
{
    using System;
    class Retangulo
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double CalcularArea()
        {
            return largura * altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }

        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do retângulo:");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            Retangulo retangulo = new Retangulo(largura, altura);

            double area = retangulo.CalcularArea();
            double perimetro = retangulo.CalcularPerimetro();
            double diagonal = retangulo.CalcularDiagonal();

            Console.WriteLine("Área do retângulo: " + area);
            Console.WriteLine("Perímetro do retângulo: " + perimetro);
            Console.WriteLine("Diagonal do retângulo: " + diagonal);
        }
    }
}