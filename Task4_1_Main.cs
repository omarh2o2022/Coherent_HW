using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DiagonalMatrix<int> matrixOne = new DiagonalMatrix<int>(3);
                DiagonalMatrix<int> matrixTwo = new DiagonalMatrix<int>(4);

                Console.WriteLine($"Matrix 1 Size: {matrixOne.Size}");
                Console.WriteLine($"Matrix 2 Size: {matrixTwo.Size}");

                matrixOne[0, 0] = 1;
                matrixOne[1, 1] = 2;
                matrixOne[2, 2] = 3;

                matrixTwo[0, 0] = 4;
                matrixTwo[1, 1] = 5;
                matrixTwo[2, 2] = 6;
                matrixTwo[3, 3] = 7;

                Console.WriteLine($"Matrix 1:");
                MatrixUtility.PrintMatrix(matrixOne);

                Console.WriteLine($"Matrix 2:");
                MatrixUtility.PrintMatrix(matrixTwo);

                DiagonalMatrix<int> resultMatrix = matrixOne.Add(matrixTwo, (a, b) => a + b);

                Console.WriteLine($"Result Matrix (Matrix1 + Matrix2):");
                MatrixUtility.PrintMatrix(resultMatrix);

                MatrixTracker<int> matrixTracker = new MatrixTracker<int>(matrixOne);

                matrixOne[0, 0] = 10;
                Console.WriteLine("After change:");
                MatrixUtility.PrintMatrix(matrixOne);

                matrixTracker.Undo();
                Console.WriteLine("After undo:");
                MatrixUtility.PrintMatrix(matrixOne);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.Read();
        }       
    }
}
