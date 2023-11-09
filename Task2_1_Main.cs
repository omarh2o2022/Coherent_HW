using System;


namespace TaskTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreeDimensionalSpaceWithMass firstPoint = new ThreeDimensionalSpaceWithMass(1, 2, 3, 5);            

            ThreeDimensionalSpaceWithMass secondPoint = new ThreeDimensionalSpaceWithMass(4, 5, 6, -1);            

            Console.WriteLine($"firstPoint coordinates: X={firstPoint.X}, Y={firstPoint.Y}, Z={firstPoint.Z}, Mass={firstPoint.Mass}");
            Console.WriteLine($"secondPoint coordinates: X={secondPoint.X} , Y= {secondPoint.Y}, Z={secondPoint.Z} , Mass= {secondPoint.Mass}");

            Console.WriteLine($"Is firstPoint a zero point? {firstPoint.IsZero()}");
            Console.WriteLine($"Is secondPoint a zero point? {secondPoint.IsZero()}");

            double distance = firstPoint.CalculateDistance(secondPoint);
            Console.WriteLine($"Distance between fistPoint and secondPoint: {distance}");

            Console.Read();
        }

      
        
    }
}
