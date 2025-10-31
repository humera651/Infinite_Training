using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double billAmount,totalAmount,gst,serviceCharge,amtPerPerson;
            int people;
            Console.WriteLine("Enter bill amount : ");
            billAmount =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter total people : ");
            people = Convert.ToInt32(Console.ReadLine());

            totalAmount = billAmount;
            if(billAmount > 1000)
            {
                gst = billAmount * 0.05;
                serviceCharge = billAmount * 0.10;
                totalAmount = billAmount + gst + serviceCharge;
            }
            amtPerPerson = totalAmount / people;
            Console.WriteLine("Each person should pay: Rs" + amtPerPerson);

            Console.ReadLine();

        }
    }
}
