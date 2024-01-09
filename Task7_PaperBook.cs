using System.Collections.Generic;

namespace Task6
{
    public class PaperBook : Book
    {
        public List<string> Isbns { get; set; }
        public string Publisher { get; set; }

        public PaperBook()
        {
            Isbns = new List<string>();
        }
    }
}
