using System.Net;

namespace Menu_Designs.WebScraping
{
    class ManganeloScraping
    {
        private static string link = "https://manganato.com";

        private static string DownloadPage(string link) //Downloads raw HTML web page
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString(link);
            }
        }
        private static string CleanPage(string page) //Cleans not needed bits from the web page
        {
            //<span class="info-image">
            //<h1>The Beginning After The End</h1>
            //<ul class="row-content-chapter">

            int start = page.IndexOf("<span class=\"info-image\">");
            int end = page.IndexOf("</li>");
            return page.Substring(start, end - start);
        }
        private static string[] SplitData(string page) //Splits data from a cleaned page into parts
        {
            string[] data = new string[4];

            //Get Name and Image link
            int startImg = page.IndexOf("src=\"") + 5;
            int startName = page.IndexOf("<h1>") + 4;
            int startChap = page.IndexOf("class=\"chapter");

            data[0] = page.Substring(startImg, page.IndexOf("\" alt") - startImg);
            data[1] = page.Substring(startName, page.IndexOf("</h1>") - startName);

            //Gets Chapter Number and date
            string subdata = page.Substring(startChap);
            int startChapNum = subdata.IndexOf('>') + 1;
            int startChapDate = subdata.LastIndexOf("=\"") + 2;

            string chapterNum = subdata.Substring(startChapNum, subdata.IndexOf('<') - startChapNum);
            try { chapterNum = chapterNum.Substring(0, chapterNum.IndexOf(' ', chapterNum.IndexOf(' ') + 1)); }
            catch { }
            chapterNum = chapterNum.Substring(0, chapterNum.LastIndexOfAny("0123456789".ToCharArray()) + 1);

            data[2] = chapterNum.Substring(chapterNum.IndexOf(' ') + 1);
            data[3] = subdata.Substring(startChapDate, subdata.LastIndexOf('"') - startChapDate);

            return data;
        }
        public static string[] GetDataFromPage(string link, bool downloadImage = false) //Gets data from a link
        {
            string page = DownloadPage(link);
            page = CleanPage(page);
            string[] data = SplitData(page);
            if (downloadImage) { data[0] = ImageFunctions.DownloadImage(data[0]); }

            foreach (string x in data)
            {
                FormObjects.ConsoleLogForm.LogLine(x);
            }

            return data;
        }
        public static string GetImage(string link)
        {
            string page = DownloadPage(link);
            int start = page.IndexOf("<span class=\"info-image\">");
            int end = page.IndexOf("<h1>");
            page = page.Substring(start, end - start);
            int startImg = page.IndexOf("src=\"") + 5;
            string imageLink = page.Substring(startImg, page.IndexOf("\" alt") - startImg);
            return ImageFunctions.DownloadImage(imageLink);
        }

        public static string[] GetChapters(string link)
        {
            string page = DownloadPage(link);
            page = CleanPage(page);
            int startChap = page.IndexOf("class=\"chapter");
            string[] data = new string[2];

            string subdata = page.Substring(startChap);
            int startChapNum = subdata.IndexOf('>') + 1;
            int startChapDate = subdata.LastIndexOf("=\"") + 2;

            string chapterNum = subdata.Substring(startChapNum, subdata.IndexOf('<') - startChapNum);
            try { chapterNum = chapterNum.Substring(0, chapterNum.IndexOf(' ', chapterNum.IndexOf(' ') + 1)); }
            catch { }
            chapterNum = chapterNum.Substring(0, chapterNum.LastIndexOfAny("0123456789".ToCharArray()) + 1);

            data[0] = chapterNum.Substring(chapterNum.IndexOf(' ') + 1);
            data[1] = subdata.Substring(startChapDate, subdata.LastIndexOf('"') - startChapDate);

            return data;
        }
    }
}
