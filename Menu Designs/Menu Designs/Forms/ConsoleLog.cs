using System;
using System.Windows.Forms;

namespace Menu_Designs
{
    public partial class ConsoleLog : Form
    {
        public ConsoleLog()
        {
            InitializeComponent();
            //Visible = true;
        }
        public void LogLine(string text)
        {
            ConsoleLogBox.AppendText(text + "\n");
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            //WebScraping.EarlymangaScraping.GetAllData(TextBoxCommand.Text);
        }

        public void ToggleConsole()
        {
            Visible = !Visible;
        }
    }
}
