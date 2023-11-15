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
            foreach (var lesson in lessons)
            {
                if (lesson is Lecture)
                {
                    Lecture originalLecture = (Lecture)lesson;
                    Lecture clonedLecture = new Lecture
                    {
                        Description = originalLecture.Description,
                        Topic = originalLecture.Topic
                    };
                    clonedTraining.Add(clonedLecture);
                }
                else if (lesson is PracticalLesson)
                {
                    PracticalLesson originalPracticalLesson = (PracticalLesson)lesson;
                    PracticalLesson clonedPracticalLesson = new PracticalLesson
                    {
                        Description = originalPracticalLesson.Description,
                        TaskLink = originalPracticalLesson.TaskLink,
                        SolutionLink = originalPracticalLesson.SolutionLink
                    };
                    clonedTraining.Add(clonedPracticalLesson);
                }
            }
            return clonedTraining;
        }
    }
}  
