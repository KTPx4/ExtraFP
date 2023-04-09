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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Style()
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    System.Windows.Forms.Control Mdi = (MdiClient)ctl;
                    
                    Mdi.BackColor = System.Drawing.Color.White;
              
                }
                catch (Exception e)
                {
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Style();
        }

        private void callManagement(int tab)
        {
            int check = 0;
            foreach (Form c in this.MdiChildren)
            {
                if(c is frmManagement)
                {
                    ((frmManagement)c).showTab(tab);
                    ((frmManagement)c).tab = tab;
                    check = 1;
                }
                else
                {
                    c.Close();
                }

            }
            if(check == 0)
            {
                frmManagement f = new frmManagement(tab);
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
        private void tsmItem_Click(object sender, EventArgs e)
        {

            callManagement(0);
        }

        private void tsmAgents_Click(object sender, EventArgs e)
        {
            callManagement(1);
        }

        private void tsmAddAgents_Click(object sender, EventArgs e)
        {
            callManagement(2);
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callManagement(3);
        }
    }
}
