using System.Collections.Generic;

namespace Task6
{
    public class Catalog
    {
        private Dictionary<string, Book> booksByIsbn = new Dictionary<string, Book>();

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
