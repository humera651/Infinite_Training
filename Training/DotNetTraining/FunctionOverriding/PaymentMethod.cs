using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverriding
{
    public class PaymentMethod
    {
        public virtual string Provider => "Generic Provider";

        public virtual bool ProcessPayment(decimal amount)
        {
            if (amount > 0) 
            {
                Console.WriteLine($"Processing payment of Rs {amount} through {Provider}");
                return true;
            }
            else
                return false;
        }

        public void SamplePayment()
        {
            Console.WriteLine("This is a sample payment method");
        }
    }
}
