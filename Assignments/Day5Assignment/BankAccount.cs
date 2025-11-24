using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{

    public class BankAccount
    {
        public decimal Balance { get; private set; }

        //Exercise 5: Transaction History Count
        public List<string> History { get; } = new List<string>();

        //Exercise 1: Bank Account
        public BankAccount(decimal openingBalance)
        {
            Balance = openingBalance;
        }

        //Exercise 2: Test Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be positive");

            Balance += amount;
            History.Add("Deposit " + amount);
        }

        //Exercise 3: Test Withdraw Method
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }

        //Exercise 9: Test Interest Calculation
        public void ApplyInterest(decimal rate)
        {
            Balance += Balance * rate;
        }
    }


}
