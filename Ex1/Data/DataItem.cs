using Ex1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataItem(string ID, string Name, string size, string type, string date, string country) 
        { 
            it = new Item(ID, Name, size, type, date, country);
        }

        public void addItem()
        {
            string query = "insert into Item values('" + it.ItemID +"', '" + it.ItemName + "', '" +it.ItemSize+"', '" +it.ItemType+ "','" + it.ItemProDate +"', '" + it.ItemCountry + "')";
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

    }
}
