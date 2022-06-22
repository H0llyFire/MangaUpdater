using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;

namespace Menu_Designs.WebScraping
{
    public class Updatings
    {
        //Gets link(s) => 
        //loads the pages and downloads data via GetData() => 
        //saves into db => 
        //updates manga list and selected manga https://earlym.net
        private static MangaLibrary.MangaListModel UpdateManganelo(MangaLibrary.MangaListModel manga)
        {
            if (manga.LinkManganelo == "https://manganato.com" || manga.LinkManganelo == null || manga.LinkManganelo == "") { return manga; }

            string[] data;
            try
            {
                data = ManganeloScraping.GetChapters(manga.LinkManganelo);
                manga.NewestChapterManganelo = float.Parse(data[0]);
            }
            catch
            {
                FormObjects.ConsoleLogForm.LogLine("[Manganelo]FAILED:  " + manga.Name, Color.Red);
                return manga;
            }

            manga.NewestDateManganelo = DateTime.ParseExact(data[1], "MMM dd,yyyy HH:mm", new CultureInfo("en-US"));
            MangaLibrary.DataAccess.UpdateChapters(manga);
            FormObjects.ConsoleLogForm.LogLine("[Manganelo]SUCCESS: " + manga.Name, Color.ForestGreen);
            return manga;
        }
        private static MangaLibrary.MangaListModel UpdateEarlymanga(MangaLibrary.MangaListModel manga)
        {
            if (manga.LinkEarlymanga == "https://earlym.net" || manga.LinkEarlymanga == null || manga.LinkEarlymanga == "https://earlym.org") { return manga; }

            string[] data;
            try
            {
                data = EarlymangaScraping.GetChaptersData(manga.LinkEarlymanga);
                manga.NewestChapterEarlymanga = float.Parse(data[0]);
            }
            catch
            {
                FormObjects.ConsoleLogForm.LogLine("[EarlyManga]FAILED:  " + manga.Name, Color.Red);
                return manga;
            }
            
            manga.NewestDateEarlymanga = DateTime.Parse(data[1], new CultureInfo("en-US"));
            MangaLibrary.DataAccess.UpdateChapters(manga);
            FormObjects.ConsoleLogForm.LogLine("[EarlyManga]SUCCESS: " + manga.Name, Color.ForestGreen);
            return manga;
        }

        public static void UpdateManga(List<MangaLibrary.MangaListModel> mangas)
        {
            foreach (MangaLibrary.MangaListModel manga in mangas)
            {
                UpdateManganelo(manga);
                UpdateEarlymanga(manga);
            }
            FormObjects.ConsoleLogForm.LogLine("All manga updated.");
        }
        public static MangaLibrary.MangaListModel UpdateManga(MangaLibrary.MangaListModel manga)
        {
            manga = UpdateManganelo(manga);
            manga = UpdateEarlymanga(manga);
            return manga;
        }
    }
}
