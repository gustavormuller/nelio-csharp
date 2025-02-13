using System;
using System.Globalization;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite 3 números com uma casa decimal: ");
                double n1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                double n2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                double n3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                double media = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}