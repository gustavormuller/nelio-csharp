using System;
using System.Globalization;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine()!;
            Console.Write("Haverá depósito inicial (s/n)? ");
            char option = char.Parse(Console.ReadLine()!);
            if (option == 's' || option == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                c = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                c = new Conta(numero, titular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.WriteLine("");
            Console.Write("Digite um valor para depositar: ");
            double quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Depositar(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine("");
            Console.Write("Digite um valor para sacar: ");
            quantia = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            c.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}