using ExerciseException.Entities;
using ExerciseException.Entities.Exceptions;
using System.Globalization;

namespace ExerciseException
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account();

            Console.WriteLine($"Enter account data: ");
            Console.Write($"Number: ");
            account.Number = int.Parse( Console.ReadLine() );
            Console.Write($"Holder: ");
            account.Holder = Console.ReadLine();
            Console.Write($"Initial balance: ");
            account.Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);     
            Console.Write($"Withdraw limit: ");
            account.WithdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"");
            Console.Write($"Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         
            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine(account);
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}