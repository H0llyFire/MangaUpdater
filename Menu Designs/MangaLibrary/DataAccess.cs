using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MangaLibrary
{
    public class DataAccess
    {
        public static List<MangaListModel> LoadMangas()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<MangaListModel> output = cnn.Query<MangaListModel>("select * from Manga order by Priority desc", new DynamicParameters()).ToList();
                MangaListModel.SetOrder(output);
                return output;
            }
        }
        public static List<MangaListModel> LoadMangas(string querry)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<MangaListModel> output = cnn.Query<MangaListModel>("select * from Manga Where Name Like '%" + querry + "%' order by Priority desc", new DynamicParameters()).ToList();
                MangaListModel.SetOrder(output);
                return output;
            }
        }
        public static void SaveManga(MangaListModel manga)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into " +
                    "Manga (Name, Image, Rating, Priority, LinkManganelo, LinkEarlymanga, LastReadChapter, NewestChapterManganelo, NewestChapterEarlymanga, NewestDateManganelo, NewestDateEarlymanga) " +
                    "values (@Name, @Image, @Rating, @Priority, @LinkManganelo, @LinkEarlymanga, @LastReadChapter, @NewestChapterManganelo, @NewestChapterEarlymanga, @NewestDateManganelo, @NewestDateEarlymanga)", manga);

            }
        }
        public static void UpdateManga(MangaListModel manga)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Manga set " +
                    "(Name, Rating, Priority, LinkManganelo, LinkEarlymanga, LastReadChapter, NewestChapterManganelo, NewestChapterEarlymanga, NewestDateManganelo, NewestDateEarlymanga) " +
                    "= " +
                    "(@Name, @Rating, @Priority, @LinkManganelo, @LinkEarlymanga, @LastReadChapter, @NewestChapterManganelo, @NewestChapterEarlymanga, @NewestDateManganelo, @NewestDateEarlymanga)" +
                    "where Id=@Id", manga);
            }
        }
        public static void UpdateImage(MangaListModel manga)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Manga set " +
                    "(Image) " +
                    "= " +
                    "(@Image)" +
                    "where Id=@Id", manga);
            }
        }
        public static void UpdateChapters(MangaListModel manga)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Manga set " +
                    "(NewestChapterManganelo, NewestChapterEarlymanga, NewestDateManganelo, NewestDateEarlymanga) " +
                    "= " +
                    "(@NewestChapterManganelo, @NewestChapterEarlymanga, @NewestDateManganelo, @NewestDateEarlymanga)" +
                    "where Id=@Id", manga);
            }
        }
        public static void DeleteManga(MangaListModel manga)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Manga where Id=@Id", manga);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
