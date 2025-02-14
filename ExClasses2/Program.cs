using System;
using System.Globalization;

namespace ExClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Insira o nome e as notas do aluno:");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine("Nota final = " + aluno.NotaFinal());
            if (aluno.Aprovado())
            {
                Console.WriteLine("Aluno aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante() + " pontos");
            }
        }
    }
}