using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class DiagonalMatrix<T>
    {
        private T[] diagonalElements;
        private int size;

        public DiagonalMatrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Size must be non-negative.");
            }

            this.size = size;
            diagonalElements = new T[size];
        }

        public int Size => size;

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= size || j >= size)
                {
                    throw new IndexOutOfRangeException("Invalid indices.");
                }

                return (i == j) ? diagonalElements[i] : default(T);
            }
            set
            {
                if (i < 0 || j < 0 || i >= size || j >= size)
                {
                    throw new IndexOutOfRangeException("Invalid indices.");
                }

                if (i == j && !diagonalElements[i].Equals(value))
                {
                    T oldValue = diagonalElements[i];
                    diagonalElements[i] = value;
                    OnElementChanged(new EventArgsChanged<T>(i, j, oldValue, value));
                }
            }
        }

        public event EventHandler<EventArgsChanged<T>> ElementChanged;

        protected virtual void OnElementChanged(EventArgsChanged<T> elementTwo)
        {
            ElementChanged?.Invoke(this, elementTwo);
        }
    }
}
