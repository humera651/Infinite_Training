using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class UtilityBill
    {
        public int customerId;
        public string customerName;

        static double serviceCharge = 50.0;
        static double taxRate = 0.10;

        public static double GetServiceCharge()
        {
            return serviceCharge;
        }

        public double TotalUsage(params int[] readings)
        {
            double total = 0;
            foreach (int r in readings)
            {
                total += r;
            }
            return total;
        }

        public void CalculateBill(out double total,out double tax,out double netPayable,params int[] readings)
        {
            double ratePerUnit = 6.5;
            double usage = TotalUsage(readings);

            total = usage * ratePerUnit;
            tax = total * taxRate;
            netPayable = total + tax + GetServiceCharge();
        }

        public void DisplayBill(double total,double tax,double netPayable)
        {
            Console.WriteLine("\n==============Utility Bill==============");
            Console.WriteLine($"Customer Id : {customerId}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Service Charge : Rs {GetServiceCharge()}");
            Console.WriteLine($"Total Usage : Rs {total}");
            Console.WriteLine($"Tax Applied : Rs {tax}");
            Console.WriteLine($"Net Payable : Rs {netPayable}");
            Console.WriteLine("==========================================\n");
        }
    }
}
