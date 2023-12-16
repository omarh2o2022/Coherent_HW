using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(6);
            queue.Enqueue(8);

            Console.WriteLine("Original Queue:");
            foreach(var item in queue)
            {
                Console.WriteLine(item + " ");
            }

            IQueue<int> tailQueue = queue.Tail();
            Console.WriteLine("Tail Queue:");
            foreach(var item in tailQueue)
            {
                Console.WriteLine(item + " ");
            }

            int dequeuedItem = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {dequeuedItem}");
            Console.Read();
        }
    }
}
