using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class MangaAdd : Form
    {
        public MangaAdd()
        {
            InitializeComponent();
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckLink(TextBoxLink.Text)) //Check link
            {
                MessageBox.Show("Enter a valid Manganelo or EarlyManga link.");
                return;
            }
            string[] data;
            MangaLibrary.MangaListModel manga = new MangaLibrary.MangaListModel();

            //Gets Data from a web page and sets it to the object
            if (TextBoxLink.Text.Contains(".com"))
            {
                data = WebScraping.ManganeloScraping.GetDataFromPage(TextBoxLink.Text, true);
                manga.NewestDateManganelo = DateTime.ParseExact(data[3], "MMM dd,yyyy HH:mm", new CultureInfo("en-US")); // "MMM dd, yyyy HH:mm"
                manga.NewestChapterManganelo = float.Parse(data[2]);
                manga.LinkManganelo = TextBoxLink.Text;
            }
            else
            {
                data = WebScraping.EarlymangaScraping.GetAllData(TextBoxLink.Text);
                manga.NewestDateEarlymanga = DateTime.Parse(data[3], new CultureInfo("en-US"));
                manga.NewestChapterEarlymanga = float.Parse(data[2]);
                manga.LinkEarlymanga = TextBoxLink.Text;
            }

            //Sets Common Data to the object

            manga.Name = data[1];
            manga.LastReadChapter = (float)numericUpDown1.Value;
            manga.Priority = (int)NumericPriority.Value;

            //Open image and save to DB
            Image image = new Bitmap(data[0]);
            byte[] pic = ImageFunctions.ImageToByte(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            //foreach(byte x in pic) { FormObjects.ConsoleLogForm.LogLine(x.ToString()); }
            manga.Image = pic;

            //Saves Data to the DB
            MangaLibrary.DataAccess.SaveManga(manga);

            //Annouce success and clear form
            FormObjects.ConsoleLogForm.LogLine(data[0]);
            MessageBox.Show("Successfully added " + manga.Name + " as a new manga.");
            numericUpDown1.Value = 0;
            TextBoxLink.Text = "";
            NumericPriority.Value = 0;
        }

        private void MangaAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormObjects.MainMenuForm.Enabled = true;
        }
        private bool CheckLink(string link)
        {
            if (link.StartsWith("http") && (link.Contains("manganato") || link.Contains("earlym"))) { return true; }
            return false;
        }

    }
}
