using System;

namespace proyect01_Omar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!, please enter your your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($" 'Hello {userName}!' you need to assign value to two integers A and B; Make sure the value of A is greater than B ");
                        
            int firstNumber, secondNumber;
            do
            {
                Console.WriteLine("please type the value of integer A:");
                firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Now, type the value for integer B:");
                secondNumber = int.Parse(Console.ReadLine());

                if (firstNumber >= secondNumber)
                {
                    Console.WriteLine("First number cannot be greater than or equal to the second number. Please enter valid values.");
                }
            } while (firstNumber >= secondNumber);
            

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                string duodecimal = ConvertToDuodecimal(Math.Abs(i)); 
                int countA = CountAInDuodecimal(duodecimal);

                if (countA == 2)
                {
                  Console.WriteLine($"Decimal: {i}, Duodecimal: {duodecimal}");
                }
            }

            Console.WriteLine($"Numbers in decimal representation from {firstNumber} to {secondNumber} with exactly two 'A' symbols in duodecimal:");

            Console.Read();

        }

        static int CountAInDuodecimal(string duodecimal)
        {
            int count = 0;
            foreach (char a in duodecimal)
            {
                if (a == 'A')
                {
                    count++;
                }
            }
            return count;
        }


        static string ConvertToDuodecimal(int number)
        {
            const string duodecimalNumb = "0123456789AB";
            string result = "";

            if (number == 0)
            {
                return "0";
            }

            while (number > 0)
            {
                int remainder = number % 12;
                result = duodecimalNumb[remainder] + result;
                number /= 12;
            }

            return result;
        }

        
    }
}
