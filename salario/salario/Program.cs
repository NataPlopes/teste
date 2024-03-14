using System;

namespace salario
{
    class Program
    {

        class Funcionario
        {
            public string Nome { get; set; }
            public double SalarioBruto { get; set; }
            public double Imposto { get; set; }

            public double CalcularSalarioLiquido()
            {
                return SalarioBruto - Imposto;
            }

            public void AumentarSalario(double porcentagemAumento)
            {
                SalarioBruto += SalarioBruto * (porcentagemAumento / 100);
            }
        }

        class Calculo
        {
            static void Main(string[] args)
            {
                Funcionario funcionario = new Funcionario();

                Console.WriteLine("Digite o nome do funcionário:");
                funcionario.Nome = Console.ReadLine();

                Console.WriteLine("Digite o salário bruto do funcionário:");
                funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor do imposto sobre o salário:");
                funcionario.Imposto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Dados do funcionário:");
                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine("Salário líquido: " + funcionario.CalcularSalarioLiquido());

                Console.WriteLine("Digite a porcentagem de aumento do salário:");
                double porcentagemAumento = Convert.ToDouble(Console.ReadLine());

                funcionario.AumentarSalario(porcentagemAumento);

                Console.WriteLine("Dados atualizados do funcionário:");
                Console.WriteLine("Nome: " + funcionario.Nome);
                Console.WriteLine("Salário líquido: " + funcionario.CalcularSalarioLiquido());
            }
        }
    }
}
