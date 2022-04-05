using System;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FormObjects.ConsoleLogForm = new ConsoleLog();
        }

        private void ButtonAddManga_Click(object sender, EventArgs e)
        {
            FormObjects.MangaAddForm = new MangaAdd();
            FormObjects.MangaAddForm.Visible = true;
            FormObjects.MainMenuForm.Enabled = false;
        }

        private void ButtonViewManga_Click(object sender, EventArgs e)
        {
            FormObjects.MangaListForm = new MangaList();
            FormObjects.MangaListForm.Visible = true;
            FormObjects.MainMenuForm.Enabled = false;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormObjects.SettingsForm = new Settings();
            FormObjects.SettingsForm.Visible = true;
            FormObjects.MainMenuForm.Enabled = false;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
