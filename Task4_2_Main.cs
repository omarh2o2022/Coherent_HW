using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRationalNumber firstRational = new MyRationalNumber(1, 2);
            MyRationalNumber secondRational = new MyRationalNumber(2, 3);

            Console.WriteLine(firstRational + secondRational); 
            Console.WriteLine((double)firstRational); 
            Console.WriteLine(3 + secondRational); 

            Console.Read();
        }
    }
}
