using Assignment14.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Pricing
{
    public class TieredDiscountStrategy : IPricingStrategy
    {
        public decimal CalculateTotal(ILineItem[] items)
        {
            decimal total = 0;
            for (int i = 0; i < items.Length; i++) 
            {
                total += items[i].UnitPrice * items[i].Quantity;
            }
            if (total >= 15000)
                total = total * 0.88m;
            else if (total >= 5000)
                total = total * 0.95m;
            return total;
        }
    }
}
