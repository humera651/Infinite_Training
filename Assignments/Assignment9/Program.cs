using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of items");
            int itemCount = Convert.ToInt32(Console.ReadLine());

            GroceryItem[] items = new GroceryItem[itemCount];
            GroceryBilling groceryBilling = new GroceryBilling();

            for (int i = 0; i < itemCount; i++) {
                items[i] = new GroceryItem();

                Console.WriteLine($"\nEnter details for item {i+1}: ");
                Console.WriteLine("Item name: ");
                items[i].name = Console.ReadLine();

                Console.WriteLine("Quantity: ");
                items[i].quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Price per unit");
                items[i].pricePerUnit = Convert.ToInt32(Console.ReadLine());
            }

            groceryBilling.CalculateBill(items, out double total, out double discount, out double finalAmount);
            groceryBilling.DisplayBill(items,total, discount, finalAmount);

            Console.ReadLine();
        }
    }
}
