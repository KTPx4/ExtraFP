using Ex1.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Mid
{
    public class MidODetail
    {
        private DataODetail odd;

        public MidODetail()
        {
            odd = new DataODetail();
        }
        public MidODetail(string odid, string oid, string iid, int quan, float unit)
        {
            odd = new DataODetail(odid, oid, iid, quan, unit);
        }
        public string getID()
        {
            DataTable tb = odd.selectTop();
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
                lastID = "ODD001";
            }
            return lastID;
        }
        public void addODetail()
        {
            odd.addODetail();
        }
        public void deleteODetail()
        {
            odd.deleteODetail();
        }
        public DataTable selectODetails()
        {
            return odd.selectODetails();
        }
        public DataTable selectODetail()
        {
            
            return odd.selectODetail();
        }

    }
}
