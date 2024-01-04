using System.Collections.Generic;

namespace Task6.task7
{
    public class Library
    {
        public Library() { } // For deserialization from data file
        public Catalog Catalog { get; set; }
        public List<string> PressReleaseItems { get; set; }

        public Library(Catalog catalog, List<string> pressReleaseItems)
        {
            Catalog = catalog;
            PressReleaseItems = pressReleaseItems;

            InitializePagesForEBooks();
        }

        private void InitializePagesForEBooks()
        {
            foreach (var book in Catalog.Books)
            {
                if (book is EBook eBook)
                {
                    eBook.FetchPagesAsync().Wait(); // Using Wait() for simplicity; consider using async all the way
                }
            }
        }
    }
}
