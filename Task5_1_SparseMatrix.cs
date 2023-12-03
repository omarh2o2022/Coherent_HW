using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task5_1
{
    class SparseMatrix : IEnumerable<long>
    {
        private readonly int rows;
        private readonly int columns;
        private readonly Dictionary<(int Row, int Column), long> _elements;

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Rows and columns must be strictly greater than zero.");

            this.rows = rows;
            this.columns = columns;
            this._elements = new Dictionary<(int Row, int Column), long>();
        }

        public long this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= rows || j < 0 || j >= columns)
                    throw new IndexOutOfRangeException("Invalid matrix indices.");

                return _elements.TryGetValue((i, j), out var value) ? value : 0;
            }
            set
            {
                if (i < 0 || i >= rows || j < 0 || j >= columns)
                    throw new IndexOutOfRangeException("Invalid matrix indices.");

                if (value != 0)
                {
                    _elements[(i, j)] = value;
                }
                else
                {
                    _elements.Remove((i, j));
                }
            }
        }

        public IEnumerator<long> GetEnumerator()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<(int Row, int Column, long Value)> GetNonzeroElements()
        {
            return _elements
                .OrderBy(e => e.Key.Column)
                .ThenBy(e => e.Key.Row)
                .Select(e => (e.Key.Row, e.Key.Column, e.Value));
        }

        public int GetCount(long x)
        {
            return _elements.Count(e => e.Value == x);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine,
                Enumerable.Range(0, rows)
                          .Select(row => string.Join(" ", Enumerable.Range(0, columns).Select(col => this[row, col]))));
        }
    }
}
