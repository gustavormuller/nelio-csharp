using System;

namespace Exercicios4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 1 e 1000");
            int x = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= x; i++) {
                if (i == 1 || i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}