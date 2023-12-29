using System.Collections.Generic;

namespace Task6
{
    public class Catalog
    {
        public Catalog() { } // For deserialization from data file

        private Dictionary<string, Book> booksByIsbn = new Dictionary<string, Book>();

        public List<Book> Books { get; set; } = new List<Book>();

        public void AddBook(string isbn, Book book)
        {
            string normalizedIsbn = NormalizeIsbn(isbn);

            if (!booksByIsbn.ContainsKey(normalizedIsbn))
            {
                booksByIsbn[normalizedIsbn] = book;
            }
        }

        public Book GetBook(string isbn)
        {
            string normalizedIsbn = NormalizeIsbn(isbn);

            if (booksByIsbn.TryGetValue(normalizedIsbn, out Book book))
            {
                return book;
            }

            return null;
        }

        public IEnumerable<string> GetIsbns()
        {
            return booksByIsbn.Keys;
        }

        private string NormalizeIsbn(string isbn)
        {
            return isbn.Replace("-", "");
        }
    }
}

