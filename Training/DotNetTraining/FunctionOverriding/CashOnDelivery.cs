using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverriding
{
    internal class CashOnDelivery : PaymentMethod
    {
        public override string Provider => "Cash On Delivery";

        //public override bool ProcessPayment(decimal amount)
        //{
        //    if (amount > 0 && amount <= 10000)
        //    {
        //        Console.WriteLine($"Processing cash on delivery payment of Rs {amount} through {Provider}");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("cash on delivery payment failed: Amount exceeds limit or is invalid");
        //        return false;
        //    }
        //}
    }
}
