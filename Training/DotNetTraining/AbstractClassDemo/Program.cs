using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SavingsAccount savingsAccount = new SavingsAccount("SA123",1000);
            //savingsAccount.Deposit(500);
            //savingsAccount.CalculateInterest();

            //CurrentAccount currentAccount = new CurrentAccount("CA123",5000);
            //currentAccount.Deposit(500);
            //currentAccount.CalculateInterest();

            //BankAccount bankAccount = new BankAccount(); //error : can't create obj for abstract class BankAccount

            PersonalDetails personalDetails = new PersonalDetails();
            personalDetails.GetPersonalDetails();

            Console.ReadLine();
        }
    }
}
