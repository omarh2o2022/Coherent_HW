using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Training originalTraining = new Training();
            originalTraining.Add(new Lecture { Description = "Introduction to C#", Topic = "Basics" });
            originalTraining.Add(new PracticalLesson { Description = "Hands-on with C#", TaskLink = "task1", SolutionLink = "solution1" });

            Training clonedTraining = originalTraining.Clone();

            Console.WriteLine("Is original training practical? " + originalTraining.IsPractical()); 
            Console.WriteLine("Is cloned training practical? " + clonedTraining.IsPractical()); 
       
            Console.Read();
        }
    }


}
