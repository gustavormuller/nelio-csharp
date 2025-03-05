using System.Globalization;
using FixacaoInterfaces.Entities;
using FixacaoInterfaces.Services;

namespace FixacaoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int n = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, n);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}