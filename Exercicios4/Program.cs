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
                Console.WriteLine("Digite pares de números: ");
                double n1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                double n2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    double divisao = n1 / n2;
                    Console.WriteLine(divisao.ToString("F2", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}