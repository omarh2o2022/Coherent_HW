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
        private readonly Dictionary<int, Dictionary<int, long>> matrixData;

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Rows and columns must be strictly greater than zero.");

            this.rows = rows;
            this.columns = columns;
            this.matrixData = new Dictionary<int, Dictionary<int, long>>();
        }

        public long this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= rows || j < 0 || j >= columns)
                    throw new IndexOutOfRangeException("Invalid matrix indices.");

                return matrixData.ContainsKey(i) && matrixData[i].ContainsKey(j) ? matrixData[i][j] : 0;
            }
            set
            {
                if (i < 0 || i >= rows || j < 0 || j >= columns)
                    throw new IndexOutOfRangeException("Invalid matrix indices.");

                if (value != 0)
                {
                    if (!matrixData.ContainsKey(i))
                        matrixData[i] = new Dictionary<int, long>();

                    matrixData[i][j] = value;
                }
                else
                {
                    if (matrixData.ContainsKey(i) && matrixData[i].ContainsKey(j))
                        matrixData[i].Remove(j);
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

        public IEnumerable<(int, int, long)> GetNonzeroElements()
        {
            foreach (var row in matrixData.Keys.OrderBy(i => i))
            {
                foreach (var col in matrixData[row].Keys.OrderBy(j => j))
                {
                    yield return (row, col, matrixData[row][col]);
                }
            }
        }

        public int GetCount(long x)
        {
            if (x == 0)
            {
                int count = 0;
                foreach (var row in matrixData.Values)
                {
                    foreach (var val in row.Values)
                    {
                        if (val == 0)
                            count++;
                    }
                }
                return count;
            }
            else
            {
                int count = 0;
                foreach (var row in matrixData.Values)
                {
                    foreach (var val in row.Values)
                    {
                        if (val == x)
                            count++;
                    }
                }
                return count;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result += $"{this[i, j]} ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
