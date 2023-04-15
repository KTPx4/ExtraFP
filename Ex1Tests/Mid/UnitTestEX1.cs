using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex1.Mid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Configuration;
using Ex1.Data;
using System.Data.SqlClient;

namespace Ex1.Mid.Tests
{
   
    [TestClass()] 
    public class UnitTestEX1
    {
        private DataTable lTestCase;
        private Connection cn;

        [TestMethod()]       
        public void addItemTest()
        {
            bool isRead = readFile("TestCase/AddItem.txt");
            if (!isRead || lTestCase.Rows.Count < 1)
            {
                Assert.AreEqual(-1, -2); // error for readfile
                return;
            }

            cn = new Connection();
            
            createBackup(); // create backup for database

            foreach (DataRow row in lTestCase.Rows)
            {
                int expected = int.Parse(row[1].ToString());

                string id = row[0].ToString();
                MidItem it = new MidItem(id); // create Item and add

                int actual = it.addItem();

                Console.WriteLine($"Test case {id}: expected {expected}, and actual {actual}");
                Assert.AreEqual(expected, actual, $"Test case {id}: expected {expected}, and actual {actual}");// values 1 for add success or 0 for failed

                //if(actual == 1)
                //{
                //    it.deleteItem(); // delete if item add success
                //}    
            }

            resetDB(); // reset after db additem

        }

        [TestMethod()]
        public void removeItemTest()
        {
            bool isRead = readFile("TestCase/DeleteItem.txt");
            if (!isRead || lTestCase.Rows.Count < 1)
            {
                Assert.AreEqual(-1, -2); // error for readfile
                return;
            }

            cn = new Connection();

            createBackup(); // create backup for database

            foreach (DataRow row in lTestCase.Rows)
            {
                int expected = int.Parse(row[1].ToString());

                string id = row[0].ToString();
                MidItem it = new MidItem(id); // create Item and add

                int actual = it.deleteItem();

                Console.WriteLine($"Test case {id}: expected {expected}, and actual {actual}");
                Assert.AreEqual(expected, actual, $"Test case {id}: expected {expected}, and actual {actual}");// values 1 for add success or 0 for failed
            }

            resetDB(); // reset after db additem
        }

        [TestMethod()]
        public void editItemTest()
        {
            bool isRead = readFile("TestCase/EditItem.txt");
            if (!isRead || lTestCase.Rows.Count < 1)
            {
                Assert.AreEqual(-1, -2); // error for readfile
                return;
            }

            cn = new Connection();

            createBackup(); // create backup for database

            foreach (DataRow row in lTestCase.Rows)
            {
                int expected = int.Parse(row[1].ToString());

                string id = row[0].ToString();
                MidItem it = new MidItem(id); // create Item and add

                int actual = it.editItem();

                Console.WriteLine($"Test case {id}: expected {expected}, and actual {actual}");
                Assert.AreEqual(expected, actual, $"Test case {id}: expected {expected}, and actual {actual}");// values 1 for add success or 0 for failed
              
            }

            resetDB(); // reset after db additem

        }

        public bool readFile(string path)
        {

            if (!File.Exists(path))
            {
                return false;
            }

            createList();
            StreamReader reader = new StreamReader(path);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
               
                string[] arr = line.Split('|');
                if(arr.Length < 1) 
                {
                    return false;
                }
                if (arr[0] == "" || arr[1] =="")
                {
                    break;
                }
                string id = arr[0];
                if(!int.TryParse(arr[1], out int n))
                {
                    return false;
                }
                int expected = int.Parse(arr[1]);

                lTestCase.Rows.Add(id, expected);
                //Console.WriteLine(line);
            }

            return true;

        }
       
        void createList()
        {
            lTestCase = new DataTable();
            lTestCase.Columns.Add("ID", typeof(string));      
            lTestCase.Columns.Add("Expected", typeof(int));
        }

        public  void createBackup()
        {
            cn = new Connection();
            string connectionString = $"Data Source={Connection.get_serverName()};Initial Catalog={Connection.get_DB()};Integrated Security=True";
            string NameDB = Connection.get_DB();

            SqlConnection conn = new SqlConnection(connectionString);

            string backupPath = $"{NameDB}.bak";

            conn.Open();

            SqlCommand cmd = new SqlCommand($"BACKUP DATABASE {NameDB} TO DISK='{backupPath}'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void resetDB()
        {
            string NameDB = Connection.get_DB();
            string backupPath = $"{NameDB}.bak";

            string connectionString = $"Data Source={Connection.get_serverName()};Initial Catalog=master;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(connectionString);
            conn1.Open();
            
            // set db single and restore 
            SqlCommand cmd3 = new SqlCommand($"ALTER DATABASE {NameDB} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE {NameDB} FROM DISK='{backupPath}' WITH REPLACE;", conn1);
            cmd3.ExecuteNonQuery();
            conn1.Close();



            // set db default
            connectionString = $"Data Source={Connection.get_serverName()};Initial Catalog=master;Integrated Security=True";
            SqlConnection conn2 = new SqlConnection(connectionString);
            conn2.Open();

            SqlCommand cmd4 = new SqlCommand($"ALTER DATABASE ExtraFP SET MULTI_USER", conn2);
            cmd4.ExecuteNonQuery();
            conn2.Close();

        }
    }
}