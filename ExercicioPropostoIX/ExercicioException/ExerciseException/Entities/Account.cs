using ExerciseException.Entities.Exceptions;
using System.Globalization;

namespace ExerciseException.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            Balance = (deposit >= 0) ? Balance += deposit : throw new DomainException("Deposit error: Deposit can't be negative");
        }
        public void Withdraw(double withdraw)
        {
            Balance = (WithdrawLimit < withdraw) ? throw new DomainException("Withdraw error: The amount exceeds withdraw limit") : (Balance < withdraw) ? throw new DomainException("Withdraw error: Not enough balance") : Balance -= withdraw;
        }


        public override string ToString()
        {
            return $"New balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
