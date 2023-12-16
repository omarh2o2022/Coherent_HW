using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> firstMatrix, DiagonalMatrix<T> secondMatrix, Func<T, T, T> addFunction)
        {
            if (firstMatrix.Size != secondMatrix.Size)
            {
                throw new ArgumentException("Matrices must have the same size.");
            }

            DiagonalMatrix<T> resultMatrix = new DiagonalMatrix<T>(firstMatrix.Size);

            for (int i = 0; i < firstMatrix.Size; i++)
            {
                T value1 = firstMatrix[i, i];
                T value2 = secondMatrix[i, i];
                resultMatrix[i, i] = addFunction(value1, value2);
            }

            return resultMatrix;
        }
    }
}
