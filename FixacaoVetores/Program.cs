using System;
using System.Globalization;

namespace FixacaoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int N = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel nº " + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;
                Console.Write("Email: ");
                string email = Console.ReadLine()!;
                Console.Write("Quarto: ");
                int aluguel = int.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                vect[aluguel] = new Estudante(nome, email);
            }

            Console.WriteLine("");
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}