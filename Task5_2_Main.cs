using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstBook = new Book("Harry Potter", new DateTime(2020, 1, 1), new HashSet<string> { "Igor Kheidorov", "Omar Sanchez" });
            var secondBook = new Book("Lord of the Rings", new DateTime(2018, 3, 15), new HashSet<string> { "Igor the Boss" });
            var thirdBook = new Book("Black Window", null, new HashSet<string> { "Marco Hinojosa", "pope john paul 2" });

            var catalog = new Catalog();

            catalog.AddBook("123-4-56-789012-3", firstBook);
            catalog.AddBook("9876543210123", secondBook);
            catalog.AddBook("111-1-11-111111-1", thirdBook);

            Console.WriteLine("Sorted Titles:");
            foreach (var title in catalog.GetSortedTitles())
            {
                Console.WriteLine(title);
            }

            Console.WriteLine("\nBooks by Author2:");
            foreach (var book in catalog.GetBooksByAuthor("Author2"))
            {
                Console.WriteLine($"Title: {book.Title}, Publication Date: {book.PublicationDate}");
            }

            Console.WriteLine("\nAuthor Book Count:");
            foreach (var result in catalog.GetAuthorBookCount())
            {
                Console.WriteLine($"{result.Author} - {result.BookCount} books");
            }
            Console.Read();
        }
