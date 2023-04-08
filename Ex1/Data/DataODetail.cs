using Ex1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Data
{
    public class DataODetail
    {
        private OrderDetail odd;

        public DataODetail()
        {
            odd = new OrderDetail();
        }
        public DataODetail(string odid, string oid, string iid, int quan, float unit)
        {
            odd = new OrderDetail(odid, oid, iid, quan, unit);
        }

        public void addODetail()
        {
            string query = "insert into OrderDetail values('" +odd.ODDid+"', '"+ odd.OrderId+"', '"+odd.ItemID+"', "+ odd.quan+", "+odd.unitA+ ")";
            Connection.actionQuery(query);
        }
        public void deleteODetail()
        {
            string query = "delete from OrderDetail where ID ='" + odd.ODDid + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectODetails()
        {
            string q = "select* from [OrderDetail] ";
            return Connection.selectQuery(q);
        }
        public DataTable selectODetail()
        {
            string q = "select* from  [OrderDetail]  where ID ='" + odd.ODDid + "'";
            return Connection.selectQuery(q);
        }
        public DataTable selectTop()
        {
            string s = "select top 1 ID from [OrderDetail] order by ID desc";
            return Connection.selectQuery(s);
        }

    }
}
