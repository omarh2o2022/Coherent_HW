using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
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
