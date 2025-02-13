using System;

namespace Exercicios3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");

            int option = int.Parse(Console.ReadLine()!);

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (option != 4)
            {
                if (option == 1)
                {
                    alcool++;
                }
                else if (option == 2)
                {
                    gasolina++;
                }
                else if (option == 3)
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Álcool");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel");
                Console.WriteLine("4 - Fim");
                option = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}