using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    internal class ThreeDimensionalSpaceWithMass
    {
        private double[] coordinates = new double[3];
        private double mass;

        public double X
        {
            get { return coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public double Y
        {
            get { return coordinates[1]; }
            set { coordinates[1] = value; }
        }

        public double Z
        {
            get { return coordinates[2]; }
            set { coordinates[2] = value; }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = (value >= 0) ? value : 0; }
        }

        public ThreeDimensionalSpaceWithMass(double valueOfX, double valueOfY, double valueOfZ, double valueOfMass)
        {
            X = valueOfX; 
            Y = valueOfY; 
            Z = valueOfZ;   
            Mass = valueOfMass;
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public double CalculateDistance(ThreeDimensionalSpaceWithMass newPointObject)
        {
            double newX = X - newPointObject.X;
            double newY = Y - newPointObject.Y;
            double newZ = Z - newPointObject.Z;

            return Math.Sqrt(newX * newX + newY * newY + newZ * newZ);
        }
    }
}
