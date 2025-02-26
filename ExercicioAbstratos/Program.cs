using System;
using System.Globalization;
using ExercicioAbstratos.Entities;

namespace ExercicioAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine()!);
                Console.Write("Name: ");
                string name = Console.ReadLine()!;
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double gastosComSaude = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, income, gastosComSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numEmp = int.Parse(Console.ReadLine()!);

                    list.Add(new PessoaJuridica(name, income, numEmp));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes paid:");

            double total = 0;
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p);
                total += p.CalcularImposto();
            }

            Console.WriteLine();
            Console.WriteLine($"Total taxes: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}