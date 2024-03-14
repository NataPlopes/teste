using System;

namespace media_aluno
{
    using System;

    class Aluno
    {
        public string Nome { get; set; }
        public double NotaTrimestre1 { get; set; }
        public double NotaTrimestre2 { get; set; }
        public double NotaTrimestre3 { get; set; }

        public double CalcularNotaFinal()
        {
            return NotaTrimestre1 * 0.3 + NotaTrimestre2 * 0.35 + NotaTrimestre3 * 0.35;
        }

        public bool Aprovado()
        {
            return CalcularNotaFinal() >= 60;
        }

        public double PontosNecessariosParaAprovacao()
        {
            double notaMinima = 60;
            double notaFinal = CalcularNotaFinal();

            if (notaFinal >= notaMinima)
                return 0;

            return notaMinima - notaFinal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do primeiro trimestre:");
            aluno.NotaTrimestre1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota do segundo trimestre:");
            aluno.NotaTrimestre2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota do terceiro trimestre:");
            aluno.NotaTrimestre3 = Convert.ToDouble(Console.ReadLine());

            double notaFinal = aluno.CalcularNotaFinal();
            Console.WriteLine($"Nota final do aluno {aluno.Nome}: {notaFinal}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aluno APROVADO!");
            }
            else
            {
                Console.WriteLine("Aluno REPROVADO!");
                Console.WriteLine($"Pontos necessários para aprovação: {aluno.PontosNecessariosParaAprovacao()}");
            }
        }
    }
}