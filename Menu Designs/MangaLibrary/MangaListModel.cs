using System;
using System.Collections.Generic;

namespace MangaLibrary
{
    public class MangaListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int Priority { get; set; }
        public string LinkManganelo { get; set; }
        public string LinkEarlymanga { get; set; }
        public float LastReadChapter { get; set; }
        public float NewestChapterManganelo { get; set; }
        public float NewestChapterEarlymanga { get; set; }
        public DateTime NewestDateManganelo { get; set; }
        public DateTime NewestDateEarlymanga { get; set; }
        public byte[] Image { get; set; }
        public int Order { get; set; }

        public static void SetOrder(List<MangaListModel> mangas)
        {
            int x = 0;
            foreach (MangaListModel manga in mangas)
            {
                manga.Order = x;
                x++;
            }
        }
    }
}
