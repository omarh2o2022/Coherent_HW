using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class QueueExtensions
    {
        public static IQueue<T> Tail<T>(this IQueue<T> queue)
        {
            Queue<T> newQueue = new Queue<T>();
            bool first = true;

            foreach(var item in queue)
            {
                if (!first)
                {
                    newQueue.Enqueue(item);
                }
                else
                {
                    first = false;
                }
            }
            return newQueue;
        }
    }
}
