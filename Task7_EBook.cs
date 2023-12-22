using System.Collections.Generic;

namespace Task6.task7
{
    public class EBook : Book
    {        
        public string ResourceIdentifier { get; set; }
        public List<string> Formats { get; set; }

        public EBook()
        {
            Formats = new List<string>();
        }
    }
}
