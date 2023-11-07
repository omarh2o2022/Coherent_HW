using System;


namespace taskOnePartThree
{
    internal class Program
    {
        static void Main(string[] args)            
        {
            Console.WriteLine("please enter your name");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello! {userName}, How many elements do you want your array to have?.");
                        
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

                Console.WriteLine("\nThis is your original array:");
                PrintArray(originalUserArray);

                int[] uniqueArray = new int[uniqueCount];
                Array.Copy(newUniqueArray, uniqueArray, uniqueCount);

                Console.WriteLine("\nThis is the unique array:");
                PrintArray(uniqueArray);
            }
            else
            {
                Console.WriteLine("Invalid input for the number of elements. Please enter a positive integer.");
            }
            Console.WriteLine("\nto exit press enter");
            Console.Read();
        }

        static void PrintArray(int[] arr)
        {
             for (int i = 0; i < arr.Length; i++)
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
