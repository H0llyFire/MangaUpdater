using System;
using System.Drawing;
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
        public void LogLine(string text, Color color)
        {
            ConsoleLogBox.SelectionStart = ConsoleLogBox.TextLength;
            ConsoleLogBox.SelectionLength = 0;
            ConsoleLogBox.SelectionColor = color;

            ConsoleLogBox.AppendText(text + "\n");
            ConsoleLogBox.SelectionColor = ConsoleLogBox.ForeColor;
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            //WebScraping.EarlymangaScraping.GetAllData(TextBoxCommand.Text);
        }

        public void ToggleConsole()
        {
            Visible = !Visible;
        }

        private void ConsoleLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
