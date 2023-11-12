using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Training originalTraining = new Training
            {
                TextDescription = "C# training management system"
            };
                          
            originalTraining.Add(new Lecture { TextDescription = "Intro to C#", Topic = "Basics" });
            originalTraining.Add(new PracticalLesson { TextDescription = "Hands-on C# Programming", TaskConditionLink = "task-link", SolutionLink = "solution-link" });

            Training clonedTraining = originalTraining.Clone();
               
            bool isPractical = clonedTraining.IsPractical();

            Console.WriteLine($"Is practical: {isPractical}");
            Console.Read();
        }
    }

    
}
