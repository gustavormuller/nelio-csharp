using System.Globalization;
using FixacaoLinq.Entities;

namespace FixacaoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var emailDosFuncs = list.Where(e => e.Salary > valor).OrderBy(e => e.Name).Select(e => e.Email);

            Console.WriteLine("Email das pessoas que ganham mais que " + valor.ToString("F2", CultureInfo.InvariantCulture));
            foreach (string email in emailDosFuncs)
            {
                Console.WriteLine(email);
            }

            var somaSalariosM = list.Where(e => e.Name[0] == 'M').Select(s => s.Salary).Sum();

            Console.WriteLine($"Soma do salário dos funcionários que começam com a letra 'M': {somaSalariosM}");
        }
    }
}