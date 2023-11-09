using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            MatrixElementsDiagonal matrixOne = new MatrixElementsDiagonal(1, 2, 3);
            MatrixElementsDiagonal matrixTwo = new MatrixElementsDiagonal(4, 5, 6, 7);

            Console.WriteLine($"Matrix 1: {matrixOne.ToString()}");
            Console.WriteLine($"Matrix 2: {matrixTwo.ToString()}");            
            MatrixElementsDiagonal resultMatrix = matrixOne.Add(matrixTwo);
            Console.WriteLine($"Result Matrix (Matrix1 + Matrix2): {resultMatrix.ToString()}");                      
            Console.Read();
        }
    }
}
