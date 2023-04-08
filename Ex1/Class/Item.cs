using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Class
{
    public class Item
    {
        //ItemID VARCHAR(10) PRIMARY KEY,
        //  ItemName NVARCHAR(50),
        //  Size VARCHAR(20),
        //  type NVARCHAR(20),
        //  ProductionDate DATE,
        //  Country VARCHAR(20)
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemSize { get; set; }
        public string ItemType { get; set; }
        public string ItemProDate { get; set; }
        public string ItemCountry { get; set; }

        public Item()
        {
            this.ItemID = "";
            this.ItemName = "";
            this.ItemSize = "";
            this.ItemType = "";
            this.ItemProDate = "2003/09/28";
            this.ItemCountry = "";
        }
        public Item(string id)
        {
            this.ItemID = id;
            this.ItemName = "";
            this.ItemSize = "";
            this.ItemType = "";
            this.ItemProDate = "2003/09/28";
            this.ItemCountry = "";
        }
        public Item(string ID, string Name, string size, string type, string date, string country)
        {
            this.ItemID = ID;
            this.ItemName = Name;
            this.ItemSize = size;
            this.ItemType = type;
            this.ItemProDate = date;
            this.ItemCountry = country;
        }
    }
}
