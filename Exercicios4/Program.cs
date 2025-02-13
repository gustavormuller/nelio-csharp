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

            int fatorial = 1;

            for (int i = 1; i <= N; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}