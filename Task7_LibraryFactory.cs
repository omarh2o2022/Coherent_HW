using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task6.task7
{
    public static class LibraryFactory
    {
        public static Library CreatePaperLibrary()
        {
            List<string> pressReleaseItems = new List<string>();

            // Specify the full path to the books_info.csv file
            string csvFilePath = @"C:\Users\omarh\OneDrive\Documents\Coherent Solutions HW\books_info.csv";

            // Load data from books_info.csv and create PaperBooks and Catalog
            string[] lines = File.ReadAllLines(csvFilePath);

            Catalog catalog = new Catalog();

            foreach (string line in lines.Skip(1)) // Skip header
            {
                string[] values = line.Split(',');

                string title = values[0].Trim();
                DateTime? publicationDate = DateTime.TryParse(values[1], out DateTime date) ? date : (DateTime?)null;
                string isbn = values[2].Trim();
                string publisher = values[3].Trim();

                // Check if the publisher is not already in pressReleaseItems
                if (!pressReleaseItems.Contains(publisher))
                {
                    pressReleaseItems.Add(publisher);
                }

                // Create a PaperBook
                PaperBook paperBook = new PaperBook
                {
                    Title = title,
                    PublicationDate = publicationDate,
                    Isbns = new List<string> { isbn },
                    Publisher = publisher
                };

                // Add the PaperBook to the Catalog
                catalog.AddBook(isbn, paperBook);
            }

            return new Library(catalog, pressReleaseItems);
        }

        public static Library CreateEBookLibrary()
        {
            List<string> pressReleaseItems = new List<string>();

            // Specify the full path to the books_info.csv file
            string csvFilePath = @"C:\Users\omarh\OneDrive\Documents\Coherent Solutions HW\task7data.csv";

            // Load data from books_info.csv and create EBooks and Catalog
            string[] lines = File.ReadAllLines(csvFilePath);

            Catalog catalog = new Catalog();

            foreach (string line in lines.Skip(1)) // Skip header
            {
                string[] values = line.Split(',');

                string title = values[0].Trim();
                string resourceIdentifier = values[1].Trim();
                string[] formats = values[2].Split(';').Select(format => format.Trim()).ToArray();

                // Check if the formats are not already in pressReleaseItems
                foreach (string format in formats)
                {
                    if (!pressReleaseItems.Contains(format))
                    {
                        pressReleaseItems.Add(format);
                    }
                }

                // Create an EBook
                EBook eBook = new EBook
                {
                    Title = title,
                    ResourceIdentifier = resourceIdentifier,
                    Formats = formats.ToList()
                };

                // Add the EBook to the Catalog
                catalog.AddBook(resourceIdentifier, eBook);
            }

            return new Library(catalog, pressReleaseItems);
        }
    }
}
