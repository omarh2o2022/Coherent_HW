using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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
            // Check ISBN validity before adding
            if (IsValidISBN(isbn))
            {
                string normalizedISBN = isbn.Replace("-", "");

                if (!books.ContainsKey(normalizedISBN))
                {
                    books.Add(normalizedISBN, book);
                }
                else
                {
                    Console.WriteLine($"ISBN {isbn} already exists in the catalog.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid ISBN format: {isbn}");
            }
        }

        public Book GetBook(string isbn)
        {
            // Check ISBN validity before retrieving
            if (IsValidISBN(isbn))
            {
                string normalizedISBN = isbn.Replace("-", "");

                if (books.TryGetValue(normalizedISBN, out Book book))
                {
                    return book;
                }
                else
                {
                    Console.WriteLine($"Book with ISBN {isbn} not found in the catalog.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid ISBN format: {isbn}");
            }

            return null;
        }

        private bool IsValidISBN(string isbn)
        {
            // ISBN regex pattern
            string pattern = @"^\d{3}-?\d-?\d{2}-?\d{6}-?\d$|^\d{13}$";

            // Check if the provided ISBN matches the pattern
            return Regex.IsMatch(isbn, pattern);
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
