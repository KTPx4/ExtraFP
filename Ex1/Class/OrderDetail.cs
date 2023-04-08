using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Class
{
    public class OrderDetail
    {
       public string ODDid { get; set; }
        public string OrderId { get; set; }
        public string ItemID { get; set; }
        public int quan { get; set; }
        public float unitA { get; set; }

        public OrderDetail()
        {
            this.ODDid = "";
            this.OrderId = "";
            this.ItemID = "";
            this.quan = 0;
            this.unitA= 0;
        }
        public OrderDetail(string odid, string oid, string iid, int quan, float unit)
        {
            this.ODDid = odid;
            this.OrderId = oid;
            this.ItemID = iid;
            this.quan = quan;
            this.unitA = unit;
        }
    }
}
