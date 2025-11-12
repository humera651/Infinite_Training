using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CollectionsDemo
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Anvith");
            ht.Add(2, "Keerthana");
            ht.Add("eid", "IT");
            ht.Add("dept", "IT");
            ht.Add("location", "Bangalore");
            ht["email"] = "sample@gmail.com";
            ht[56] = "Test Value";

            Console.WriteLine("Hash table values are");

            Console.WriteLine("First Value : " + ht[1]);
            Console.WriteLine("Count of Hash Table : "+ht.Count);
            Console.WriteLine("The key 56 is available or not : " + ht.ContainsKey(56));
            Console.WriteLine("The Value sample@gmail.com is Available or not : " + ht.ContainsValue(56));

            ht.Remove(2);
            Console.WriteLine("\n Hash table keys are");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("Key : " + item);
            }

            Console.WriteLine("\n Hash table values are");
            foreach (var item in ht.Values)
            {
                Console.WriteLine("Values : " + item);
            }

            Console.WriteLine("\n Hash table keys and values are");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            object[] keyArray = new object[ht.Keys.Count];
            ht.Keys.CopyTo(keyArray, 0);
            Console.WriteLine("\n after copying all keys into keyArray");
            foreach(var item in keyArray)
            {
                Console.WriteLine(item);
            }

            Hashtable h2 = new Hashtable();
            foreach (DictionaryEntry item in ht) 
            {
                h2[item.Key] = item.Value;
            }

            h2.Clear();
            Console.WriteLine("After clearing the hashtable " +h2.Count);

            Console.ReadLine();
        }
    }
}
