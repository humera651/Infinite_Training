using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountNumber, double initialBalance) : base(accountNumber, initialBalance)
        {
        }
        public override void CalculateInterest()
        {
            //Current account do not earn interest
            Console.WriteLine("Current account do not earn interest");
        }
    }
}
