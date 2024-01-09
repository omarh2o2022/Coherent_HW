using System;
using System.Collections.Generic;

namespace Task6
{
    public class Book
    {
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
    }
}
