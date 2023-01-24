using ExerciseAbstract.Entities;
using System.Globalization;

namespace ExerciseAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> listTaxPayer = new List<TaxPayer>();



            Console.Write($"Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write($"Individual or company (i/c)? ");
                char var1 = char.Parse(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (var1 == 'i')
                {
                    Console.Write($"Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayer.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write($"Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    listTaxPayer.Add(new Company(name, anualIncome, numberOfEmployees));
                }

                
            }
            Console.WriteLine($"-------------------------");
            Console.WriteLine($"TAXES PAID:");
            double sum = 0;
            foreach (TaxPayer taxPayer in listTaxPayer)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += taxPayer.Tax();
            }
            Console.WriteLine($"--------------------------------------");
            Console.Write($"Total Taxes: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}