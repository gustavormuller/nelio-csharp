using System;
using System.Collections.Generic;
using System.Globalization;

namespace FixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int N = int.Parse(Console.ReadLine()!);

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Funcionário Nº " + i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine("");
            }

            Console.WriteLine("");
            Console.Write("Digite o ID do funcionário que terá aumento de salário: ");
            int searchId = int.Parse(Console.ReadLine()!);

            Funcionario? func = list.Find(x => x.Id == searchId);
            if (func != null)
            {
                Console.Write("Insira a porcentagem de aumento: ");
                double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                func.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}