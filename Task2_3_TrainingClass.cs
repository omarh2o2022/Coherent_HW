using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{

    public class Lecture
    {
        public string TextDescription { get; set; }
        public string Topic { get; set; }
    }

    public class PracticalLesson
    {
        public string TextDescription { get; set; }
        public string TaskConditionLink { get; set; }
        public string SolutionLink { get; set; }
    }

    public class Training
    {
        public List<object> lessons = new List<object>();

        public string TextDescription { get; set; }

        public void Add(object lesson)
        {
            lessons.Add(lesson);
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
                TextDescription = this.TextDescription
            };

            foreach (var lesson in lessons)
            {
                if (lesson is Lecture)
                {
                    Lecture originalLecture = (Lecture)lesson;
                    Lecture clonedLecture = new Lecture
                    {
                        TextDescription = originalLecture.TextDescription,
                        Topic = originalLecture.Topic
                    };
                    clonedTraining.Add(clonedLecture);
                }
                else if (lesson is PracticalLesson)
                {
                    PracticalLesson originalPracticalLesson = (PracticalLesson)lesson;
                    PracticalLesson clonedPracticalLesson = new PracticalLesson
                    {
                        TextDescription = originalPracticalLesson.TextDescription,
                        TaskConditionLink = originalPracticalLesson.TaskConditionLink,
                        SolutionLink = originalPracticalLesson.SolutionLink
                    };
                    clonedTraining.Add(clonedPracticalLesson);
                }
            }

            return clonedTraining;
        }
    }
}
