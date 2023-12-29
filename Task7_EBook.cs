using HtmlAgilityPack;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Task6.task7
{
    public class EBook : Book
    {
        public string ResourceIdentifier { get; set; }
        public List<string> Formats { get; set; }

        public int Pages { get; set; }

        public EBook()
        {
            Formats = new List<string>();
        }

        public async Task FetchPagesAsync()
        {
            string url = $"https://archive.org/details/{ResourceIdentifier}";

            using (var httpClient = new HttpClient())
            {
                string htmlContent = await httpClient.GetStringAsync(url);

                // Parse HTML content to get the number of pages
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(htmlContent);

                var pagesNode = htmlDocument.DocumentNode.SelectSingleNode("//span[@itemprop='numberOfPages']");
                if (pagesNode != null)
                {
                    if (int.TryParse(pagesNode.InnerText, out int numberOfPages))
                    {
                        Pages = numberOfPages;
                    }
                }
            }
        }
    }
}
