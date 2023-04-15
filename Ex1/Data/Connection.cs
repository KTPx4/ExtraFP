using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Ex1.Data
{
    public class Connection
    {

        public static SqlConnection cn;
        private static string serverName = "";
        private static string dbName = "";
        public static String strConn = "initial catalog = (db); data source = (local); integrated security = true";
        public Connection()
        {
            if (!readServer())
            {
                MessageBox.Show("Can not find 'server.txt', please create");
                Environment.Exit(0);
            }
        }

        public static bool readServer()
        {
            string path = "server.txt";
            if (!File.Exists(path))
            {
                return false;
            }

            string text = File.ReadAllText(path);
            string[] arr = text.Split('|');
            if (arr.Length != 2)
            {
                return false;
            }
            serverName = arr[0];
            dbName = arr[1];

            strConn = strConn.Replace("(local)", serverName);
            strConn = strConn.Replace("(db)", dbName);
            return true;
        }

        public static void connect()
        {
            string s = strConn;
            cn = new SqlConnection(s);
            cn.Open();

        }

        public static void actionQuery(string sql)
        {
            connect(); 

            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            cn.Close();
            return dt;
        }
        public static void dropDatabase(string dbName)
        {
            string query = $"DROP DATABASE IF EXISTS {dbName}";
            actionQuery(query);
        }

        public static void restoreDatabase(string dbName, string backupPath)
        {
            // Kết nối đến master database
            string connectionString = $"Data Source={get_serverName()};Initial Catalog=master;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Xóa database cũ (nếu tồn tại)
            dropDatabase(dbName);

            // Khôi phục database từ backup
            string query = $"RESTORE DATABASE {dbName} FROM DISK='{backupPath}' WITH REPLACE";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static string get_serverName()
        {
            return serverName;
        }
        public static string get_DB()
        {
            return dbName;
        }
    }
}
