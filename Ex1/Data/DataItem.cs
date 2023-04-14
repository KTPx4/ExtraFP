using Ex1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1.Data
{
    public class DataItem
    {
        private Item it;

        public DataItem() 
        {
            it = new Item();
        }
        public DataItem(string id)
        {
            it = new Item(id);
        }
        public DataItem(string ID, string Name, string size, string type,  string country) 
        { 
            it = new Item(ID, Name, size, type,  country);
        }

        public void addItem()
        {
            string query = "insert into Item values('" + it.ItemID +"', '" + it.ItemName + "', '" +it.ItemSize+"', '" +it.ItemType+ "','" + it.ItemCountry + "')";
            Connection.actionQuery(query);
        }
        public void editItem()
        {
            string query = "update Item set ItemName = '" + it.ItemName +"', Size ='"+it.ItemSize+"', type ='"+it.ItemType+"', country ='"+it.ItemCountry+"' where ItemID = '" + it.ItemID+"'";
            Connection.actionQuery(query);
        }
        public void deleteItem()
        {
            string query = "delete from Item where ItemID ='" + it.ItemID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectItems()
        {
            string q = "select* from Item";
            return Connection.selectQuery(q);
        }
        public DataTable selectItem()
        {
            string q = "select* from Item where ItemID ='" +it.ItemID +"'";
            return Connection.selectQuery(q);
        }
        public DataTable selectTop()
        {
            string s = "select top 1 ItemID from Item order by ItemID desc";
            return Connection.selectQuery(s);
        }
        public DataTable selectTop(string top)
        {
            string s = "SELECT TOP " +top+ " Item.ItemID as 'Item ID', Item.ItemName as 'Item Name', SUM(OrderDetail.Quantity) AS 'Total Quantity'" +
                        " FROM Item JOIN OrderDetail ON Item.ItemID = OrderDetail.ItemID" +
                        " GROUP BY Item.ItemID, Item.ItemName" +
                        " ORDER BY 'Total Quantity' DESC";
            return Connection.selectQuery(s);
        }
        public DataTable select(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}
