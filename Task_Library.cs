using System.Collections.Generic;

namespace Task6.task7
{
    public class Library
    {
        public Catalog Catalog { get; set; }
        public List<string> PressReleaseItems { get; set; }

        // Parameterless constructor
        public Library()
        {
            Catalog = new Catalog(); // Initialize with an empty catalog
            PressReleaseItems = new List<string>(); // Initialize with an empty list
        }

        // Constructor with parameters
        public Library(Catalog catalog, List<string> pressReleaseItems)
        {
            Catalog = catalog;
            PressReleaseItems = pressReleaseItems;
        }
    }
}
