using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class PracticalLesson : Lesson
    {
        public string TaskLink { get; set; }
        public string SolutionLink { get; set; }
        public override object Clone()
        {
            return new PracticalLesson
            {
                Description = this.Description,
                TaskLink = this.TaskLink,   
                SolutionLink = this.SolutionLink    
            };
        }
    }
}
