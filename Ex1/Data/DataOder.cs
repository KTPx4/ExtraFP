using Ex1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Data
{
    public class DataOder
    {
        private Order Od;

        public DataOder()
        {
            Od = new Order();
        }
        public DataOder(string id, string date, string ag)
        {
            Od = new Order(id, date, ag);
        }

        public void addOrder()
        {
            string query = "insert into [Order] values('" + Od.OderID+"', '"+Od.OderDate +"', '"+Od.OrderAID+ "')";
            Connection.actionQuery(query);
        }
        public void deleteOrder()
        {
            string query = "delete from [Order] where OrderID ='" + Od.OderID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectOders()
        {
            string q = "select* from [Order] ";
            return Connection.selectQuery(q);
        }
        public DataTable selectOder()
        {
            string q = "select* from  [Order]  where OrderID ='" + Od.OderID + "'";
            return Connection.selectQuery(q);
        }
        public DataTable selectTop()
        {
            string s = "select top 1 OrderID from [Order] order by OrderID desc";
            return Connection.selectQuery(s);
        }
    }
}
