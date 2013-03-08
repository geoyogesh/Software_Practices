using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MEF_Part3_MenuSystem
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
            Application.Run(new MenuSystem());
        }
    }
}
