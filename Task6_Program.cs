using System;
using System.Collections.Generic;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Author author1 = new Author { FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1980, 1, 1) };
           Author author2 = new Author { FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1990, 5, 15) };
           Author author3 = new Author { FirstName = "Bob", LastName = "Johnson", DateOfBirth = new DateTime(1975, 12, 31) };
           Author author4 = new Author { FirstName = "Alice", LastName = "Brown", DateOfBirth = new DateTime(1995, 6, 20) };
           Author author5 = new Author { FirstName = "Mark", LastName = "Davis", DateOfBirth = new DateTime(1985, 9, 30) };
           Author author6 = new Author { FirstName = "Emily", LastName = "Wilson", DateOfBirth = new DateTime(1998, 2, 14) };
           
           Book book1 = new Book { Title = "The Secret Window", PublicationDate = new DateTime(2018, 1, 1) };
           book1.Authors.AddRange(new List<Author> { author1, author2 });
           Book book2 = new Book { Title = "Harry Potter", PublicationDate = new DateTime(2001, 3, 10) };
           book2.Authors.AddRange(new List<Author> { author3, author4 });                
           Book book3 = new Book { Title = "Narnia", PublicationDate = new DateTime(1999, 5, 11) };
           book3.Authors.AddRange(new List<Author> { author4, author1});
           Book book4 = new Book { Title = "The last Kingdom", PublicationDate = new DateTime(1815, 6, 25) };
           book4.Authors.AddRange(new List<Author> { author5, author2 });
           Book book5 = new Book { Title = "The Hobbit", PublicationDate = new DateTime(1937, 9, 21) };
           book5.Authors.AddRange(new List<Author> { author6, author3 });

           Catalog catalog = new Catalog();
           catalog.AddBook("123-4-56-789012-3", book1);
           catalog.AddBook("4567890123456", book2);
           catalog.AddBook("789-0-12-345678-9", book3);
           catalog.AddBook("012-3-45-678901-2", book4);
           catalog.AddBook("345-6-78-901234-5", book5);

           IRepository<Catalog> xmlRepository = new XMLRepository<Catalog>();
           xmlRepository.Save("catalog.xml", catalog);

           Catalog loadedCatalogFromXml = xmlRepository.Load("catalog.xml");

           IRepository<Catalog> jsonRepository = new JSONRepository<Catalog>();
           jsonRepository.Save("catalog.json", catalog);

           Catalog loadedCatalogFromJson = jsonRepository.Load("catalog.json");

           CatalogDisplay.DisplayCatalog("Original Catalog", catalog);
           CatalogDisplay.DisplayCatalog("Loaded Catalog from XML", loadedCatalogFromXml);
           CatalogDisplay.DisplayCatalog("Loaded Catalog from JSON", loadedCatalogFromJson);

           // Save each author's books to a separate JSON file
           AuthorToJson.SaveAuthorToJsonFile(author1, new List<Book> { book1, book3 });
           AuthorToJson.SaveAuthorToJsonFile(author2, new List<Book> { book1, book4 });
           AuthorToJson.SaveAuthorToJsonFile(author3, new List<Book> { book2, book5 });
           AuthorToJson.SaveAuthorToJsonFile(author4, new List<Book> { book2, book3 });
           AuthorToJson.SaveAuthorToJsonFile(author5, new List<Book> { book4 });
           AuthorToJson.SaveAuthorToJsonFile(author6, new List<Book> { book5 });

           Console.ReadLine();
        }          
    }    
}
