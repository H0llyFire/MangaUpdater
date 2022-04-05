using System;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            TextBoxLocation.Text = "MangaDB.db";
        }

        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormObjects.MainMenuForm.Enabled = true;
        }

        private void ButtonConsole_Click(object sender, EventArgs e)
        {
            FormObjects.ConsoleLogForm.ToggleConsole();
        }
    }
}
