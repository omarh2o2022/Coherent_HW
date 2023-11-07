using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, whats your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"{userName}, in order to generate your ISBN number, you need to enter 9 digit characters,");

            Console.Write("please enter your 9 digit characters now: ");
            string input = Console.ReadLine();

            if (input.Length != 9)
            {
                Console.WriteLine("Input should be 9 digits.");
                return;
            }

            int checkDigit = CalculateCheckDigit(input);

            string isbn = input + (checkDigit == 10 ? "X" : checkDigit.ToString());
            
            Console.WriteLine($"thank you, your generated ISBN is: {isbn}");
            Console.WriteLine("to exit press enter");
            Console.Read();
        }

        static int CalculateCheckDigit(string input)
        {
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit = int.Parse(input[i].ToString());
                sum += (10 - i) * digit;
            }

            int checkDigit = 11 - (sum % 11);
            return checkDigit;
        }
    }
}
