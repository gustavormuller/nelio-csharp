using System;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int N = int.Parse(Console.ReadLine()!);

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite um número");
                int x = int.Parse(Console.ReadLine()!);
                if (x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");

        }
    }
}