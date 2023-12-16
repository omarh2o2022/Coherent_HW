using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    public class Lecture : Lesson
    {
        public string Topic { get; set; }
        public override object Clone()
        {
            return new Lecture
            {
               Description = this.Description,
               Topic = this.Topic
            };
        }
    }
}
