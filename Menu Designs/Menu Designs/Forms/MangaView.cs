using System;
using System.Drawing;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class MangaView : Form
    {
        MangaLibrary.MangaListModel manga;
        public MangaView(MangaLibrary.MangaListModel manga)
        {
            this.manga = manga;
            InitializeComponent();
            SetupManga();
            Visible = true;
        }
        private void SetupManga()
        {
            TextBoxEarlymangaChapters.Text = manga.NewestChapterEarlymanga.ToString();
            TextBoxEarlymangaDate.Text = manga.NewestDateEarlymanga.ToString();
            TextBoxManganeloChapters.Text = manga.NewestChapterManganelo.ToString();
            TextBoxManganeloDate.Text = manga.NewestDateManganelo.ToString();
            TextBoxName.Text = manga.Name;
            NumericPriority.Value = manga.Priority;
            NumericRating.Value = (decimal)manga.Rating;
            NumericChaptersRead.Value = (decimal)manga.LastReadChapter;
            LinkEarlymanga.Text = manga.LinkEarlymanga == null ? "https://earlym.net" : manga.LinkEarlymanga;
            LinkManganelo.Text = manga.LinkManganelo == null ? "https://manganato.com" : manga.LinkManganelo;
            PictureManga.Image = ImageFunctions.ByteToImage(manga.Image);
            //PictureManga.Image              = new Bitmap(".\\images\\23-1609948262.jpg");
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (manga.Order == 0) { return; }
            manga = FormObjects.MangaListForm.mangas[manga.Order - 1];
            SetupManga();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (manga.Order == FormObjects.MangaListForm.mangas.Count - 1) { return; }
            manga = FormObjects.MangaListForm.mangas[manga.Order + 1];
            SetupManga();
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            manga = WebScraping.Updatings.UpdateManga(manga);
            FormObjects.MangaListForm.LoadList();
            TextBoxEarlymangaChapters.Text = manga.NewestChapterEarlymanga.ToString();
            TextBoxEarlymangaDate.Text = manga.NewestDateEarlymanga.ToString();
            TextBoxManganeloChapters.Text = manga.NewestChapterManganelo.ToString();
            TextBoxManganeloDate.Text = manga.NewestDateManganelo.ToString();
            MessageBox.Show("Successfully updated " + manga.Name);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            manga.Rating = (double)NumericRating.Value;
            manga.Priority = (int)NumericPriority.Value;
            manga.LastReadChapter = (float)NumericChaptersRead.Value;
            manga.LinkEarlymanga = LinkEarlymanga.Text;
            manga.LinkManganelo = LinkManganelo.Text;
            manga.Name = TextBoxName.Text;
            MangaLibrary.DataAccess.UpdateManga(manga);
            FormObjects.MangaListForm.LoadList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this? This action can't be reverted.", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MangaLibrary.DataAccess.DeleteManga(manga);
                FormObjects.MangaListForm.LoadList();
                Close();
            }
        }

        private void LinkManganelo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { System.Diagnostics.Process.Start(LinkManganelo.Text); }
        }

        private void LinkEarlymanga_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { System.Diagnostics.Process.Start(LinkEarlymanga.Text); }
        }

        private void LinkEarlymanga_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TextBoxLinkEarlymanga.Text = LinkEarlymanga.Text;
                LinkEarlymanga.Visible = false;
                TextBoxLinkEarlymanga.Visible = true;
                ActiveControl = TextBoxLinkEarlymanga;

            }
        }

        private void LinkManganelo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TextBoxLinkManganelo.Text = LinkManganelo.Text;
                LinkManganelo.Visible = false;
                TextBoxLinkManganelo.Visible = true;
                ActiveControl = TextBoxLinkManganelo;

            }
        }

        private void TextBoxLinkEarlymanga_Leave(object sender, EventArgs e)
        {
            LinkEarlymanga.Text = TextBoxLinkEarlymanga.Text == "" ? "https://earlym.net" : TextBoxLinkEarlymanga.Text;
            LinkEarlymanga.Visible = true;
            TextBoxLinkEarlymanga.Visible = false;
        }

        private void TextBoxLinkManganelo_Leave(object sender, EventArgs e)
        {
            LinkManganelo.Text = TextBoxLinkManganelo.Text == "" ? "https://manganato.com" : TextBoxLinkManganelo.Text;
            LinkManganelo.Visible = true;
            TextBoxLinkManganelo.Visible = false;
        }

        private void ButtonDownloadImage_Click(object sender, EventArgs e)
        {
            string imageLink;
            if (RadioManganelo.Checked)
            { imageLink = WebScraping.ManganeloScraping.GetImage(manga.LinkManganelo); }
            else
            { imageLink = WebScraping.EarlymangaScraping.GetImageLink(manga.LinkEarlymanga); }

            Image image = new Bitmap(imageLink);
            manga.Image = ImageFunctions.ImageToByte(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            MangaLibrary.DataAccess.UpdateImage(manga);
            FormObjects.MangaListForm.LoadList();

            PictureManga.Image = ImageFunctions.ByteToImage(manga.Image);
            MessageBox.Show("Successfully updated image.");
        }
    }
}
