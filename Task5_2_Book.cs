using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    public class Book
    {
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public HashSet<string> Authors { get; set; }

        public Book(string title, DateTime? publicationDate, HashSet<string> authors)
        {
            Title = !string.IsNullOrEmpty(title) ? title : throw new ArgumentException("Title cannot be empty or null.");
            PublicationDate = publicationDate;
            Authors = authors ?? new HashSet<string>();
        }
    }
}
