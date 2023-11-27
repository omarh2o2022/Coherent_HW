using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    public class Catalog
    {
        private Dictionary<string, Book> books;

        public Catalog()
        {
            books = new Dictionary<string, Book>();
        }

        public void AddBook(string isbn, Book book)
        {
            string normalizedISBN = isbn.Replace("-", "");

            if (!books.ContainsKey(normalizedISBN))
            {
                books.Add(normalizedISBN, book);
            }
        }

        public Book GetBook(string isbn)
        {
            string normalizedISBN = isbn.Replace("-", "");

            if (books.TryGetValue(normalizedISBN, out Book book))
            {
                return book;
            }

            return null;
        }

        public IEnumerable<string> GetSortedTitles()
        {
            return books.Values.Select(book => book.Title).OrderBy(title => title);
        }

        public IEnumerable<Book> GetBooksByAuthor(string authorName)
        {
            return books.Values.Where(book => book.Authors.Contains(authorName))
                              .OrderBy(book => book.PublicationDate);
        }

        public IEnumerable<(string Author, int BookCount)> GetAuthorBookCount()
        {
            return books.Values.SelectMany(book => book.Authors, (book, author) => author)
                              .GroupBy(author => author)
                              .Select(group => (Author: group.Key, BookCount: group.Count()))
                              .OrderBy(result => result.Author);
        }
    }
}
