using Assignment14.Contracts;
using Assignment14.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14.Pricing
{
    public class MRPStrategy : IPricingStrategy
    {
        public decimal CalculateTotal(ILineItem[] items)
        {
            decimal total = 0;
            for (int i = 0; i < items.Length; i++)
            {
                total += items[i].UnitPrice * items[i].Quantity;
            }
            return total;
        }
    }
}
