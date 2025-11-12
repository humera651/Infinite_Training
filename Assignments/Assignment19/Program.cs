using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static BankAccount operator +(BankAccount b1, BankAccount b2)
        {
            return new BankAccount(
                "TEMP",
                b1.AccountHolder + " & " + b2.AccountHolder,
               b1.Balance + b2.Balance
            );
        }

        public static BankAccount operator -(BankAccount bankAcc, decimal amount)
        {
            if(amount > bankAcc.Balance)
            {
                Console.WriteLine($"Transaction failed: Insufficient balance in {bankAcc.AccountHolder}'s account");
                return bankAcc;
            }
            return new BankAccount(bankAcc.AccountNumber, bankAcc.AccountHolder, bankAcc.Balance - amount);
        }

        public static bool operator ==(BankAccount b1, BankAccount b2)
        {
            return b1.Balance == b2.Balance;
        }

        public static bool operator !=(BankAccount b1, BankAccount b2) 
        {
            return b1.Balance != b2.Balance; 
        }

        public override bool Equals(object obj)
        {
            if (obj is BankAccount other)
            {
                return this.Balance == other.Balance;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }

        public override string ToString()
        {
            return $"Account Holder: {AccountHolder} , Account Number: {AccountNumber} , Balance: Rs {Balance}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("AC101","Ramesh Kumar",25000m);
            BankAccount acc2 = new BankAccount("AC102", "Suresh Nair", 40000);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            Console.WriteLine("\nMerging accounts (using +):");
            BankAccount merged = acc1 + acc2;
            Console.WriteLine($"Combined Balance: Rs {merged.Balance}");

            Console.WriteLine("\nComparing balances:");
            Console.WriteLine($"{acc1.AccountNumber} == {acc2.AccountNumber} -> {acc1 == acc2}");

            Console.WriteLine("\nWithdrawal operation (using -):");
            BankAccount newAcc1 = acc1 - 5000m;
            Console.WriteLine($"New Balance of {acc1.AccountHolder}: Rs {newAcc1.Balance}");

            Console.WriteLine("\nTrying invalid withdrawal");
            BankAccount invalidWithdraw = acc1 - 30000m;

            Console.WriteLine("\nFinal Account Details:");
            Console.WriteLine(newAcc1);
            Console.WriteLine(acc2);

            Console.ReadLine();

        }
    }
}
