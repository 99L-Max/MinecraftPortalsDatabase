using System;
using System.Threading;
using System.Windows.Forms;

namespace MinecraftPortalsDatabase
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(ShowErrorMessage);
            Application.Run(new FormDatabaseWorlds());
        }

        private static void ShowErrorMessage(object sender, ThreadExceptionEventArgs e) =>
            MessageBox.Show(e.Exception.ToString());
    }
}
