using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IQueue<T> : IEnumerable<T>
    {
        void Enqueue(T item);
        T Dequeue();
        bool IsEmpty { get; }
    }
}
