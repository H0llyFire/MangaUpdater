using System.Net;

namespace Menu_Designs.WebScraping
{
    class EarlymangaScraping
    {
        private static string link = "https://earlym.net";

        private static string DownloadPage(string link) //Downloads raw HTML web page
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(link);
            }
        }
        private static string CleanPage(string page) //Cleans the page for later processing
        {
            int startIndex = page.IndexOf("<span class=\"mx-1\">") + 19;
            int endIndex = page.IndexOf("UTC (+00:00)") - 1;
            return page.Substring(startIndex, endIndex - startIndex);
        }
        private static string[] SplitCleanedPageData(string page) //Processes page data for later use
        {
            string[] fragments = new string[3];

            //Detaches Manga Name
            int nameEndIndex = page.IndexOf("</span>");
            fragments[1] = page.Substring(0, nameEndIndex);

            //Detaches Image Link
            int imageStartIndex = page.IndexOf("src=\"") + 5;
            int imageEndIndex = page.IndexOf("alt=") - 2;
            fragments[0] = link + "/" + page.Substring(imageStartIndex, imageEndIndex - imageStartIndex);

            //Detaches Chapter Info
            int chapterStartIndex = page.IndexOf("\"chapterN\"");
            fragments[2] = page.Substring(chapterStartIndex);

            return fragments;
        }
        private static string[] CleanChapterData(string chapterData) //Cleans chapter data for later use
        {
            //Detaches Chapter Number
            chapterData = chapterData.ToLower();
            int numberIndex = chapterData.IndexOf("chapter ") + 8;
            int numberEndIndex = chapterData.IndexOf('<');
            string[] data = new string[2];
            data[0] = chapterData.Substring(numberIndex, numberEndIndex - numberIndex);
            data[0] = data[0].Trim();

            //Detaches Chapter Date
            int DateIndex = chapterData.LastIndexOf("title=\"") + 7;
            data[1] = chapterData.Substring(DateIndex);
            return data;
        }
        private static string[] GetRoughData(string link) //Common page acquiring function
        {
            string page = CleanPage(DownloadPage(link));
            return SplitCleanedPageData(page);
        }
        public static string[] GetAllData(string link) //Gets all the needed data from a web page
        {
            string[] fragments = GetRoughData(link);
            string[] chapters = CleanChapterData(fragments[2]);
            string[] data = new string[4];
            data[0] = ImageFunctions.DownloadImage(fragments[0]);
            data[1] = fragments[1];
            data[2] = chapters[0];
            data[3] = chapters[1];

            foreach (string x in data) { FormObjects.ConsoleLogForm.LogLine(x); }
            return data;
        }
        public static string[] GetChaptersData(string link)
        {
            string[] fragments = GetRoughData(link);
            return CleanChapterData(fragments[2]);
        }
        public static string GetImageLink(string link)
        {
            string[] fragments = GetRoughData(link);
            return ImageFunctions.DownloadImage(fragments[0]);
        }
    }
}
