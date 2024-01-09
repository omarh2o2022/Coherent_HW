using System.Collections.Generic;

namespace Task6.task7
{
    public interface ILibraryFactory
    {
        Catalog CreateCatalog();
        List<string> CreatePressReleaseItems();
    }
}
