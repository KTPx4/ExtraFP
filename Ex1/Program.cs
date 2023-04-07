using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static String strConn = ConfigurationManager.ConnectionStrings["MyConnect"].ConnectionString;
        public static bool readServer()
        {
            string path = "server.txt";
            if (!File.Exists(path))
            {
                return false;
            }

            string text = File.ReadAllText(path);
            string[] arr = text.Split('|');
            if(arr.Length != 2 )
            {
                return false;
            }
            string serverName = arr[0];
            string dbName = arr[1];

            strConn = strConn.Replace("(local)", serverName);
            strConn = strConn.Replace("(db)", dbName);
            return true;
        }
        [STAThread]
        static void Main()
        {
            if(!readServer())
            {
                MessageBox.Show("Can not find 'server.txt', please create");
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
