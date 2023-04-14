using Ex1.Class;
using Ex1.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex1.Mid
{
   
    public class MidAgent
    {
        private DataAgent ag;
        public MidAgent()
        {
            ag = new DataAgent();
        }
        
        public MidAgent(string id, string name, string addr)
        {
            ag = new DataAgent(id, name, addr);
        }
        
        public int addAgent()
        {
            DataTable tb = ag.selectAgent();
            if(tb.Rows.Count > 0) // exists data with id agents 
            {
                return 0;
            }
            ag.addAgent();
            return 1;
        }
       
        public int editAgent()
        {
            DataTable tb = ag.selectAgent();
            if (tb.Rows.Count == 0) // not exists data to edit
            {
                return 0;
            }
            ag.editAgent();
            return 1;
        }
        
        public int deleteAgent()
        {
            DataTable tb = ag.selectAgent();
            if (tb.Rows.Count == 0) // not exists data to delete
            {
                return 0;
            }
            ag.deleteAgent();
            return 1;
        }
        
        public DataTable selectAgents()
        {
           return ag.selectAgents();
        }
        
        public DataTable selectAgent()
        {
            return ag.selectAgent();
        }
        
        public string getID()
        {
            DataTable tb = ag.selectTop();
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
                lastID = "A0001";
            }
            return lastID;
        }

    }
}
