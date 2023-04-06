using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String strConn = ConfigurationManager.ConnectionStrings["MyConnect"].ConnectionString;
        public static void readServer()
        {
            string serverName = File.ReadAllText("server.txt");

            strConn = strConn.Replace("(local)", serverName);
        }
        [STAThread]
        static void Main()
        {
            readServer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
