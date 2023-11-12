using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2_3
{
    public interface ILesson
    {
        string TextDescription { get; set; }
    }

    public class Lecture : ILesson
    {
        public string TextDescription { get; set; }
        public string Topic { get; set; }
    }

    public class PracticalLesson : ILesson
    {
        public string TextDescription { get; set; }
        public string TaskConditionLink { get; set; }
        public string SolutionLink { get; set; }
    }

    public class Training
    {
        public ILesson[] lessons; 

        public string TextDescription { get; set; }

        public void Add(ILesson lesson)
        {
            if (lessons == null)
            {
                lessons = new ILesson[] { lesson };
            }
            else
            {
                int newLength = lessons.Length + 1;
                Array.Resize(ref lessons, newLength);
                lessons[newLength - 1] = lesson;
            }
        }

        public bool IsPractical()
        {
            foreach (var lesson in lessons)
            {
                if (lesson is Lecture)
                {
                    return false;
                }
            }
            return true;
        }

        public Training Clone()
        {
            Training clonedTraining = new Training
            {
                TextDescription = this.TextDescription,
                lessons = this.lessons != null ? (ILesson[])this.lessons.Clone() : null 
            };

            return clonedTraining;
        }
    }
}
