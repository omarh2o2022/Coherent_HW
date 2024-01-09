using System.Collections.Generic;

namespace Task6.task7
{
    public interface PaperBookLibraryFactory : ILibraryFactory
    {
        new List<string> CreatePressReleaseItems();
        new Catalog CreateCatalog();
    }
}
