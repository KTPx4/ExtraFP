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
                catch (Exception a)
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
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }

            frmManagement f = new frmManagement(tab);
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void tsmItem_Click(object sender, EventArgs e)
        {

            callManagement(0);
        }

        private void tsmAgents_Click(object sender, EventArgs e)
        {
            callManagement(1);
        }
    }
}
