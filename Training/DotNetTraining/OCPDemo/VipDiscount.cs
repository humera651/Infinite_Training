using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public class VipDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount()
        {
            return 0.8m;
        }
    }
}
