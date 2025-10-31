using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double purchase_amt, final_amt;
            Console.WriteLine("Enter purchase amount");
            purchase_amt = Convert.ToDouble(Console.ReadLine());

            if(purchase_amt<=1000)
                Console.WriteLine("Final amount after discount : " + purchase_amt);
            else if(purchase_amt>1000 && purchase_amt<5000)
                Console.WriteLine("Final amount after discount : " + (purchase_amt - (purchase_amt*10/100)));
            else if(purchase_amt>=5000)
                Console.WriteLine("Final amount after discount : " + (purchase_amt - (purchase_amt * 20 / 100)));
            Console.ReadLine();
        }
    }
}
