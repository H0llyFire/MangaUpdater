using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class MangaList : Form
    {
        public List<MangaLibrary.MangaListModel> mangas = new List<MangaLibrary.MangaListModel>();

        public MangaList()
        {
            InitializeComponent();
            LoadList();
        }

        private void ButtonUpdateAll_Click(object sender, EventArgs e)
        {
            WebScraping.Updatings.UpdateManga(mangas);
            LoadList();
            MessageBox.Show("Successfully updated every manga.");
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormObjects.SettingsForm = new Settings();
            FormObjects.SettingsForm.Visible = true;
        }

        private void MangaList_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormObjects.MainMenuForm.Enabled = true;
        }

        public void OpenMangaView(int index)
        {
            FormObjects.MangaViewForm = new MangaView(mangas[index]);
        }

        private void ListViewMangas_DoubleClick(object sender, EventArgs e)
        {
            if (ListViewMangas.SelectedItems != null)
            {
                OpenMangaView(ListViewMangas.SelectedIndices[0]);
            }
        }
        public void LoadList(string querry = "")
        {
            FormObjects.ConsoleLogForm.LogLine("Load Initiated");
            ListViewMangas.Items.Clear();
            if (querry == "")
                mangas = MangaLibrary.DataAccess.LoadMangas();
            else
                mangas = MangaLibrary.DataAccess.LoadMangas(querry);

            foreach (MangaLibrary.MangaListModel x in mangas)
            {
                //FormObjects.ConsoleLogForm.LogLine("Loaded Object");
                int highestChapter = (int)Math.Round(x.NewestChapterEarlymanga > x.NewestChapterManganelo ? x.NewestChapterEarlymanga : x.NewestChapterManganelo, 0);
                int chaptersLeft = highestChapter - (int)Math.Round(x.LastReadChapter);

                ListViewMangas.Items.Add(new ListViewItem(new string[] { chaptersLeft.ToString(), x.Name }));
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            LoadList(TextBoxSearch.Text);
        }
    }
}
