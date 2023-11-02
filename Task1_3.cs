using System;


namespace taskOnePartThree
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("please enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello! {userName}, \n  In order for me to generate your array, first you need to indicate how many elements your array will contain, then you must enter the number that each element must contain one at a time.");
            Console.Write("\nHow many elements do you want your array to have?: ");
            
            if (int.TryParse(Console.ReadLine(), out int userArray) && userArray > 0)
            {
                int[] originalUserArray = new int[userArray];
                int uniqueCount = 0;
                int[] newUniqueArray = new int[userArray];

                for (int i = 0; i < userArray; i++)
                {
                    
                    Console.Write($"Enter element {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int userElementInput))
                    {
                        originalUserArray[i] = userElementInput;
                        if (!ContainsNumber(newUniqueArray, uniqueCount, userElementInput))
                        {
                            newUniqueArray[uniqueCount] = userElementInput;
                            uniqueCount++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        i--;
                    }
                }

                Console.WriteLine("\nthis is your original array:");
                PrintArray(originalUserArray);

                Console.WriteLine("\nthis is the unique array:");
                PrintArray(newUniqueArray, uniqueCount);
            }
            else
            {
                Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            }
            Console.WriteLine("\nto exit press enter");
            Console.Read();
        }

        static void PrintArray(int[] arr, int length = -1)
        {
            if (length == -1)
            {
                length = arr.Length;
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static bool ContainsNumber(int[] arr, int length, int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
