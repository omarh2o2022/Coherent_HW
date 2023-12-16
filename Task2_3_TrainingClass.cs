using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{   
    public class Training
    {
        private Lesson[] lessons;

        public Training()
        {
            lessons = new Lesson[0];
        }

        public void Add(Lesson lesson)
        {
            Array.Resize(ref lessons, lessons.Length + 1);
            lessons[lessons.Length - 1] = lesson;
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
            Training clonedTraining = new Training();
            foreach(var lesson in lessons)
            {
                clonedTraining.Add((Lesson)lesson.Clone());
            }
            return clonedTraining;
        }

    }
}  
