using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsDemo
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("Test");
            stack.Push(3.14);
            Console.WriteLine("Items in Stack");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("top of the item in stack is : " +stack.Peek());

            stack.Pop();
            Console.WriteLine("Items in Stack after Pop: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Test is there or not in stack : " + stack.Contains("Test"));
            Console.WriteLine("Total item in the stack : " + stack.Count);

            stack.Clear();

            Console.WriteLine("Total items in the stack" + stack.Count);

            Console.ReadLine();
        }
    }
}
