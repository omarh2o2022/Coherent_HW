using System;
using System.Linq;

namespace Task6
{
    public static class CatalogDisplay
    {
        public static void DisplayCatalog(string title, Catalog catalog)
        {
            Console.WriteLine($"--- {title} ---");
            foreach (var isbn in catalog.GetIsbns())
            {
                Book book = catalog.GetBook(isbn);
                string authors = string.Join(", ", book.Authors.Select(author => author.ToString()));
                Console.WriteLine($"ISBN: {isbn}, Title: {book.Title}, Authors: {authors}");
            }
            Console.WriteLine();
        }
    }
    
}
