using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsDemo
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Hello");
            queue.Enqueue(45.65);
            queue.Enqueue(true);
            queue.Enqueue('A');

            foreach (Object item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine("After dequeue()" + queue.Count);

            Console.WriteLine("Top item in queue : " + queue.Peek());

            Console.ReadLine();
        }
    }
}
