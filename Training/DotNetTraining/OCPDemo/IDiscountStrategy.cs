using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPDemo
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount();
    }
}
