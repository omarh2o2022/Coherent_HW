using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    public sealed class MyRationalNumber : IComparable<MyRationalNumber>
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public MyRationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be 0");

            int firstArg = FirstArg(numerator, denominator);
            Numerator = numerator / firstArg;
            Denominator = denominator / firstArg;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object obj)
        {
            if (obj is MyRationalNumber other)
                return Numerator == other.Numerator &&
                       Denominator == other.Denominator;
            return false;
        }

        public int CompareTo(MyRationalNumber other)
        {
            return (Numerator * other.Denominator).CompareTo(Denominator * other.Numerator);
        }

        public static MyRationalNumber operator +(MyRationalNumber rationalOne, MyRationalNumber rationalTwo)
        {
            return new MyRationalNumber(rationalOne.Numerator * rationalTwo.Denominator +
                                       rationalTwo.Numerator * rationalOne.Denominator,
                                       rationalOne.Denominator * rationalTwo.Denominator);
        }

        public static MyRationalNumber operator -(MyRationalNumber rational3, MyRationalNumber rational4)
        {
            return new MyRationalNumber(rational3.Numerator * rational4.Denominator -
                                       rational4.Numerator * rational3.Denominator,
                                       rational3.Denominator * rational4.Denominator);
        }

        public static MyRationalNumber operator *(MyRationalNumber rational5, MyRationalNumber rational6)
        {
            return new MyRationalNumber(rational5.Numerator * rational6.Numerator,
                                      rational5.Denominator * rational6.Denominator);
        }

        public static MyRationalNumber operator /(MyRationalNumber rational7, MyRationalNumber rational8)
        {
            return new MyRationalNumber(rational7.Numerator * rational8.Denominator,
                                      rational7.Denominator * rational8.Numerator);
        }

        public static explicit operator double(MyRationalNumber rational)
        {
            return (double)rational.Numerator / rational.Denominator;
        }

        public static implicit operator MyRationalNumber(int integer)
        {
            return new MyRationalNumber(integer, 1);
        }

        private static int FirstArg(int firstRational, int secondRational)
        {
            return secondRational == 0 ? firstRational : FirstArg(secondRational, firstRational % secondRational);
        }

        public override int GetHashCode()
        {
            return Numerator ^ Denominator;
        }
    }
}
