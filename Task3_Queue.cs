using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Queue<T> : IQueue<T>
    {
        private LinkedList<T> list = new LinkedList<T>();
        public void Enqueue(T item)
        {
            list.AddLast(item);
        }

        public T DeQueue()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }

        public bool IsEmpty => list.Count == 0;

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T Dequeue()
        {
            return default;
        }
    }
}
