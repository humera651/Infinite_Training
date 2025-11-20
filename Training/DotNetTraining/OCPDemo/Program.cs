using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OCPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("--------OCP Demo---------");
            IDiscountStrategy discount = new VipDiscount();
            WriteLine("Vip Discount : " +discount.ApplyDiscount());

            discount = new EmployeeDiscount();
            WriteLine("Employee Discount : " +discount.ApplyDiscount());

            ReadLine();
        }
    }
}
