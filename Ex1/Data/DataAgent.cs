using Ex1.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Data
{
    public class DataAgent
    {
        private Agent Ag;

        public DataAgent()
        {
            Ag = new Agent();
        }
        public DataAgent(string id, string name, string addr)
        {
            Ag = new Agent(id, name, addr);
        }

        public void addAgent()
        {
            string query = "insert into Agent values('" + Ag.AgentID+"', '"+ Ag.AgentName+"', '"+Ag.AgentAddr +"')";
            Connection.actionQuery(query);
        }
        public void deleteAgent()
        {
            string query = "delete from Agent where AgentID ='" + Ag.AgentID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectAgents()
        {
            string q = "select* from Agent";
            return Connection.selectQuery(q);
        }
        public DataTable selectAgent()
        {
            string q = "select* from Agent where AgentID ='" + Ag.AgentID + "'";
            return Connection.selectQuery(q);
        }
        public DataTable selectTop()
        {
            string s = "select top 1 AgentID from Agent order by AgentID desc";
            return Connection.selectQuery(s);
        }
    }
}
