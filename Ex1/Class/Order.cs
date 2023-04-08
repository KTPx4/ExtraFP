using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Class
{
    public class Order
    {
        public string OderID { get; set; }
        public string OderDate { get; set; }
        public string OrderAID { get; set; }
        public Order()
        {
            this.OderID = "";
            this.OderDate = "";
            this.OrderAID = "";
        }
        public Order(string id, string date, string ag)
        {
            this.OderID = id;
            this.OderDate = date;
            this.OrderAID = ag;
        }
    }
}
