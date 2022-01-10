using DevExpress.Skins;
using DevExpress.UserSkins;
using QLTV.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLTV
{
    static class Program
    {
        public static frmMain frmChinh;
        public static string id;
        public static string connstr = "Data Source=DESKTOP-MAA5MC1;Initial Catalog=QLTV;Persist Security Info=True;User ID=sa;Password=123";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
