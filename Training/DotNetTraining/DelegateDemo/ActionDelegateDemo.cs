using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void PrintDelegate(int Number);
    public delegate void GreetMessage(string str);
    internal class ActionDelegateDemo
    {
        static void Main(string[] args)
        {
            //Example for action delegate

            //PrintDelegate printDel = new PrintDelegate(ConsolePrint);
            //or
            PrintDelegate printDel = ConsolePrint;
            printDel(100);

            //ActionDelegate example 2
            Action<int> printAction = ConsolePrint;
            printDel(200);

            //ActionDelegate with anonymous method
            Action<string> greet = delegate (string name)
            {
                Console.WriteLine("Hello from anonymous method " + name);
            };

            greet("Bob");

            //Example for Lambda Expression with Action Delegate
            //Action<string> greet = name => Console.WriteLine("Hello" + name);

            //greet("Alice");
            Console.ReadLine();
        }
        public static void ConsolePrint(int i)
        {
            Console.WriteLine("ConsolePrint function" + i);
        }

        public static void greetmessage(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
