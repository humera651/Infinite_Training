using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class GroceryBilling
    {
        public void CalculateBill(GroceryItem[] items,out double total,out double discount,out double finalAmount)
        {
            total = 0;

            foreach (var item in items)
            {
                total += item.CalculateItemTotal();
            }

            if (total >= 5000)
                discount = total * 0.20;
            else if (total >= 2000 && total <= 4999)
                discount = total * 0.10;
            else if (total >= 1000 && total <= 1999)
                discount = total * 0.5;
            else
                discount = 0;

            finalAmount = total - discount;
        }

        public void DisplayBill(GroceryItem[] items,double total,double discount,double finalAmount)
        {
            Console.WriteLine("\n==========Smart Grocery Bill===========\n");

            for(int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"Item Name: {items[i].name}");
                Console.WriteLine($"Quantity: {items[i].quantity}");
                Console.WriteLine($"Price per unit: {items[i].pricePerUnit}");
                Console.WriteLine($"Total for this item: {items[i].CalculateItemTotal()}");
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine($"Total amount: {total}");
            Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Final amount to pay: {finalAmount}");
            Console.WriteLine("=======================================");
        }
    }
}
