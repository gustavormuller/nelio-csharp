using System;
using System.Globalization;

namespace ExClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Insira os dados do funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine(func);

            Console.WriteLine("");
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}