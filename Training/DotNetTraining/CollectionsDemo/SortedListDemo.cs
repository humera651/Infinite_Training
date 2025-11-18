using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {
            //Generic way to declare
            //SortedList<int,string> products = new SortedList<int,string>();
            //products.Add(101, "Laptop");
            //products.Add(103, "Tablet");
            //products.Add(102, "Mobile");
            //products.Add(104, "Monitor");

            //foreach (var item in products)
            //{
            //    Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            //}

            SortedList<int, string> inventory = new SortedList<int, string>();
            inventory.Add(2001, "Wheat - 50Kg");
            inventory.Add(2002, "Rice - 25Kg");
            inventory.Add(2003, "Sugar - 10Kg");
            inventory.Add(2004, "Salt - 5Kg");
            inventory.Add(2005, "Oil - 1Ltr");

            Console.WriteLine("\nInventory Details");
            Console.WriteLine("First Item Code " + inventory.Keys[0]);
            Console.WriteLine("Last Item Value " + inventory.Values[inventory.Count - 1]);

            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Search By Key
            Console.WriteLine("Enter the key to search");
            int keyToSearch = Convert.ToInt32(Console.ReadLine());
            if (inventory.ContainsKey(keyToSearch))
            {
                Console.WriteLine("Item Found: " + inventory[keyToSearch]);
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            //Search By Value
            Console.WriteLine("Enter the value to search");
            string valueToSearch = Console.ReadLine();
            if(inventory.ContainsValue(valueToSearch))
            {
                Console.WriteLine("Item Found with key: " + inventory.IndexOfValue(valueToSearch));
            }
            else
            {
                Console.WriteLine("Item not found");
            }

            //update value
            Console.WriteLine("Enter the key to update the value");
            int keyToUpdate = Convert.ToInt32(Console.ReadLine());
            string newValue = Console.ReadLine();
            inventory[keyToUpdate] = newValue;
            Console.WriteLine("updated value " + inventory[keyToUpdate]);

            //remove by key
            Console.WriteLine("Removing item code 2004");
            inventory.Remove(2004);
            Console.WriteLine("After removal of 2004");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Remove by Index
            inventory.RemoveAt(0);
            Console.WriteLine("After removal of index 0");
            foreach (var item in inventory)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            //Get index of key
            Console.WriteLine("Index of key 2003 " + inventory.IndexOfKey(2003));

            inventory.Clear();

            Console.ReadLine();
        }
    }
}
