using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LINQ.and.Databases
{
    static class Program
    {
        /// <summary>
        /// P. Tompane
        /// 2011/11/28 11:30
        /// Program accesses the catmanCollege MS Access database
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
