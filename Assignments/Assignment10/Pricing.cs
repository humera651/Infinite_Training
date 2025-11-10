using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal static class Pricing
    {
        public static double CalculateGst(double amount)
        {
            return (amount * 0.18);
        }

        public static double AddOnsCost(params string[] addOns)
        {
            double total = 0;
            foreach (var add in addOns)
            {
                switch(add.ToLower())
                {
                    case "child-seat":
                        total += 50;
                        break;
                    case "fast-tag":
                        total += 100; 
                        break;
                    case "priority-pickup":
                        total += 150;
                        break;
                    case "extra-luggage":
                        total += 200;
                        break;
                }
            }
            return total;
        }

        public static bool TryGetWeekendSurcharge(DateTime rideDate, out double percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Saturday || rideDate.DayOfWeek == DayOfWeek.Sunday)
            {
                percent = 10;
                return true;
            }
            percent = 0;
            return false;
        }

        public static void TryApplyCoupon_ByValue(double total,double couponAmount)
        {
            total -= couponAmount;
        }

        public static void ApplyCoupon_ByRef(ref double total,double couponAmount)
        {
            total -= couponAmount;
        }

        public static void RedeemLoyalty(ref int points,ref double total)
        {
            if(points >= 100)
            {
                total -= 50;
                points -= 100;
            }
        }

    }
}
