using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Task6
{
    public static class AuthorToJson
    {
        public static void SaveAuthorToJsonFile(Author author, List<Book> books)
        {
            string authorJson = JsonConvert.SerializeObject(new { Author = author, Books = books }, Formatting.Indented);
            string fileName = $"{author.FirstName}_{author.LastName}_Books.json";
            File.WriteAllText(fileName, authorJson);
            Console.WriteLine($"JSON file for {author.FirstName} {author.LastName} saved as {fileName}");
        }
    }
}
