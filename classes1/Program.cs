using System;
using System.Globalization;

namespace classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine()!;
            Console.Write("Salário: ");
            pessoa1.Salario = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine()!;
            Console.Write("Salário: ");
            pessoa2.Salario = int.Parse(Console.ReadLine()!);

            double media = (pessoa1.Salario + pessoa2.Salario) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}