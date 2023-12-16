using System;

namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SparseMatrix sparseMatrix = new SparseMatrix(3, 4);

            sparseMatrix[0, 0] = 1;
            sparseMatrix[0, 1] = 0;
            sparseMatrix[1, 2] = 3;
            sparseMatrix[2, 3] = 4;

            Console.WriteLine($"Sparse Matrix: \n{sparseMatrix}");
            
            Console.WriteLine("Nonzero Elements:");
            foreach (var element in sparseMatrix.GetNonzeroElements())
            {
                Console.WriteLine($"({element.Item1}, {element.Item2}): {element.Item3}");
            }

            Console.WriteLine("Count of 0 in Matrix: " + sparseMatrix.GetCount(0));
            Console.WriteLine("Count of 3 in Matrix: " + sparseMatrix.GetCount(3));

            Console.Read();
        }
    }
}
