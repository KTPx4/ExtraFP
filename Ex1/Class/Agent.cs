using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Class
{
    public class Agent
    {
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public string AgentAddr { get; set; }
        public Agent()
        {
            this.AgentID = "";
            this.AgentName = "";
            this.AgentAddr = "";
        }
        public Agent(string id, string name, string addr)
        {
            this.AgentID = id;
            this.AgentName = name;
            this.AgentAddr = addr;
        }
    }
}
