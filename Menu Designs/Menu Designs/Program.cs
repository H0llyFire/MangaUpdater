using System;
using System.Windows.Forms;

namespace Menu_Designs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormObjects.MainMenuForm = new MainMenu();
            Application.Run(FormObjects.MainMenuForm);
        }
    }
}
