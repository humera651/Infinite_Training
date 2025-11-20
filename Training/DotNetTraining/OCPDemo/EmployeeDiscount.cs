using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public class EmployeeDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount()
        {
            return 0.5m;
        }
    }
}
