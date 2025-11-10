using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    class OnlineStore
    {
        public void Checkout(int price)
        {
            Console.WriteLine($"Total amount to pay: Rs{price}");
        }
        public void Checkout(int price,int quantity)
        {
            int total = price * quantity;
            Console.WriteLine($"Total amount for {quantity} items: Rs {total}");
        }
        public void Checkout(string couponCode)
        {
            Console.WriteLine($"Coupon '{couponCode}' applied successfully");
        }

        public void Checkout(int price,int quantity,string couponCode)
        {
            int total = price * quantity;
            double discount = 0;

            if(couponCode == "SAVE10")
            {
                discount = 0.10 * total;
            }
            else if (couponCode == "SAVE20")
            {
                discount = 0.20 * total;
            }

            double finalAmount = total - discount;
            Console.WriteLine($"Price per item: Rs {price}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Coupon Code: {couponCode}");
            Console.WriteLine($"Discount Applied: Rs {discount}");
            Console.WriteLine($"Final Amount to Pay: Rs {finalAmount}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineStore store = new OnlineStore();

            store.Checkout(500);
            store.Checkout(500, 3);
            store.Checkout("SAVE10");
            store.Checkout(500, 3, "SAVE20");

            Console.ReadLine();
        }
    }
}
