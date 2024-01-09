using System.Collections.Generic;

namespace Task6.task7
{
    public class ConcretePaperBookLibraryFactory : PaperBookLibraryFactory
    {
        public List<string> CreatePressReleaseItems()
        {
            // Implementation for creating press release items for PaperBooks
            return new List<string> { "Publisher1", "Publisher2" };
        }

        public Catalog CreateCatalog()
        {
            // Implementation for creating a catalog for PaperBooks
            Catalog catalog = new Catalog();
            // Add PaperBooks to the catalog
            return catalog;
        }
    }
}
