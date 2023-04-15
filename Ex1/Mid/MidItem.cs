using Ex1.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1.Mid
{
    public class MidItem 
    {
        private DataItem p;
        public MidItem() 
        { 
            p = new DataItem();
        }
        public MidItem(string id)
        {
            p = new DataItem(id);
        }
        public MidItem(string ID, string Name, string size, string type,  string country)
        {
            p = new DataItem(ID, Name, size, type,  country);
        }

        public string getID()
        {
            DataTable tb = p.selectTop();
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


                for (int i = 0; i < (4 - newStt.ToString().Length); i++)
                {
                    lastID = lastID + "0";
                }
                lastID = firtID + lastID + newStt.ToString();
            }
            else
            {
                lastID = "I0001";
            }
            return lastID;
        }
        
        public int addItem()
        {
            DataTable tb = p.selectItem();
            if(tb.Rows.Count > 0 ) 
            {
                return 0; // exists ID in db 
            }
            p.addItem();
            return 1;
        }
        
        public int deleteItem()
        {
            DataTable tb = p.selectItem();
            if (tb.Rows.Count == 0)
            {               
                return 0;// not exists ID in db 
            }
          
            p.deleteItem();
            return 1;
        }
        
        public int editItem()
        {
            DataTable tb = p.selectItem();
            if (tb.Rows.Count == 0)
            {               
                return 0;// not exists ID in db 
            }
            p.editItem();
            return 1;
        }

        public DataTable selectItems()
        {
            return p.selectItems();
        }
        
        public DataTable selectItem()
        {
            return p.selectItem();
        }
        
        public DataTable selectTop(string top)
        {
            return p.selectTop(top);
        }
        
        public DataTable select(string query)
        {
            return p.select(query);
        }
    }
}
