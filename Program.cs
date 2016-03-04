using System;
using System.Collections.Generic;
using System.Web;
using System.Windows.Forms;

namespace _4chget
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length < 2)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            } else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                string url = (args[1].Replace("4chget://", ""));
                Application.Run(new frmMain(true, url));

            }
        }
    }
}
