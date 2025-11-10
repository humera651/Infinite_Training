using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Welcome to Online Utility Billing System=======");
            Console.Write("Enter number of customers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"\nEnter details for Customer #{i}");
                UtilityBill utilityBill = new UtilityBill();

                Console.Write("Customer ID: ");
                utilityBill.customerId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Customer Name: ");
                utilityBill.customerName = Console.ReadLine();

                Console.Write("How many monthly usage readings? : ");
                int count = Convert.ToInt32(Console.ReadLine());
                
                int[] readings = new int[count];

                for(int j = 0; j < count; j++)
                {
                    Console.Write($"Enter reading #{j + 1}: ");
                    readings[j] = Convert.ToInt32(Console.ReadLine());
                }

                double total, tax, netPayable;
                utilityBill.CalculateBill(out total, out tax, out netPayable, readings);

                utilityBill.DisplayBill(total, tax, netPayable);
            }

            Console.WriteLine("All customer bills processed successfully!");
            Console.ReadLine();
        }
    }
}
