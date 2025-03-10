using System.Globalization;
using ResolvidoLinq.Entities;

namespace ResolvidoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).Average();
            Console.WriteLine("Averga price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var belowAverage = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name);

            foreach (var belowAvgName in belowAverage)
            {
                Console.WriteLine(belowAvgName.Name);
            }
        }
    }
}