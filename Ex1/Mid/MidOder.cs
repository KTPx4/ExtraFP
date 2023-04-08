using Ex1.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Mid
{
    public  class MidOder
    {
        private DataOder od;
        public MidOder() 
        {
            od = new DataOder();
        }
        public MidOder(string id, string date, string ag)
        {
            od = new DataOder(id, date, ag);
        }
        public string getID()
        {
            DataTable tb = od.selectTop();
            string lastID = "";
            if (tb.Rows.Count > 0)
            {
                //int end = tb.Rows.Count - 1;
                //MessageBox.Show(tb.Rows[0][0].ToString());
                String sttEnd = tb.Rows[0][0].ToString();
                int index = 0;
                for (int i = 0; i < sttEnd.Length; i++)
                {
                    var isNumeric = int.TryParse(sttEnd[i].ToString(), out int n);
                    if (isNumeric)
                    {
                        index = i;
                        break;
                    }
                }
                string firtID = sttEnd.Substring(0, index);
                // MessageBox.Show("" + index + "," + svend.Length);
                String sttend = sttEnd.Substring(index, sttEnd.Length - index);
                int newStt = int.Parse(sttend) + 1;


                for (int i = 0; i < (3 - newStt.ToString().Length); i++)
                {
                    lastID = lastID + "0";
                }
                lastID = firtID + lastID + newStt.ToString();
            }
            else
            {
                lastID = "OD001";
            }
            return lastID;
        }

        public void addOrder()
        {
            od.addOrder();
        }
        public void deleteOrder()
        {
            od.deleteOrder();
        }
        public DataTable selectOders()
        {
            return od.selectOders();
        }
        public DataTable selectOder()
        {
            return od.selectOder();
        }













    }
}
