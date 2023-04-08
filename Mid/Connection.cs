using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid
{
    public class Connection
    {
        private static SqlConnection cn;
        private static string connectionString = "initial catalog = (db); data source = (local); integrated security = true";
       
        public static void connect()
        {
            cn = new SqlConnection()
            //string s = "initial catalog = QLSV; data source = DESKTOP-VGVFSE4\\SQLEXPRESS; integrated security = true";
            //cn = new SqlConnection(s);
            //cn.Open();

        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
