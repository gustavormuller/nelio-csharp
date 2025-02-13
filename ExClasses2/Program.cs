using System;
using System.Globalization;

namespace ExClasses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Insira a largura e a altura do retangulo");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}