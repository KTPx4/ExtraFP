using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class frmManagement : Form
    {
        private int tab;
        public frmManagement()
        {
            this.tab = 0;
            InitializeComponent();
        }
        public frmManagement(int tab)
        {
            this.tab = tab;
            InitializeComponent();
        }

       

        private void frmManagement_Load(object sender, EventArgs e)
        {
            TabPage Show;
            TabPage Hide;
            if(this.tab == 0)
            {
                Show = Items;
                Hide = Agents;
            }
            else
            {
                Show = Agents;
                Hide = Items;
            }

            if (!tabControl1.TabPages.Contains(Show))
            {
                tabControl1.TabPages.Add(Show);
            }
            if (tabControl1.TabPages.Contains(Hide))
            {
                tabControl1.TabPages.Remove(Hide);
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
