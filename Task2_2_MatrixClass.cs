using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    public class MatrixElementsDiagonal
    {
        private int[] diagonalElements;

        public int Size { get; }

        public MatrixElementsDiagonal(params int[] elements)
        {
            if (elements == null)
            {
                Size = 0;
                diagonalElements = new int[0];
            }
            else
            {
                Size = elements.Length;
                diagonalElements = new int[Size];
                for (int i = 0; i < Size; i++)
                {
                    diagonalElements[i] = elements[i];
                }
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size || i != j)
                    return 0;
                return diagonalElements[i];
            }
        }

        public int Track()
        {
            int sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum += diagonalElements[i];
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            if (obj is MatrixElementsDiagonal other)
            {
                if (Size != other.Size)
                    return false;

                for (int i = 0; i < Size; i++)
                {
                    if (diagonalElements[i] != other.diagonalElements[i])
                        return false;
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Diagonal Matrix ({Size}x{Size})";
        }
    }

    public static class DiagonalMatrixExtensions
    {
        public static MatrixElementsDiagonal Add(this MatrixElementsDiagonal firstMatrix, MatrixElementsDiagonal secondMatrix)
        {
            int size = Math.Max(firstMatrix.Size, secondMatrix.Size);
            int[] resultElements = new int[size];

            for (int i = 0; i < size; i++)
            {
                int value1 = (i < firstMatrix.Size) ? firstMatrix[i, i] : 0;
                int value2 = (i < secondMatrix.Size) ? secondMatrix[i, i] : 0;
                resultElements[i] = value1 + value2;
            }

            return new MatrixElementsDiagonal(resultElements);
        }
    }

}
