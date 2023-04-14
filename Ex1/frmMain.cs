using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex1.Class;
using Ex1.Mid;

namespace Ex1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            Style();
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
        private void ExportPDF(DataTable tb, string Path)
        {
            Document document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Path, FileMode.Create));
            document.Open();

            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 10);

            PdfPTable table = new PdfPTable(tb.Columns.Count + 1);

           // PdfPRow row = null;

            float[] widths = new float[tb.Columns.Count + 1];
            for (int i = 0; i <= tb.Columns.Count ; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 98;
           
            table.AddCell(new Phrase("STT", font5));
          
            foreach (DataColumn c in tb.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }
            int turn = 1;
            foreach (DataRow r in tb.Rows)
            {
                if (tb.Rows.Count > 0)
                {
                    table.AddCell(new Phrase(turn.ToString(), font5));
                    for (int h = 0; h < tb.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                    turn++;
                }
            }
            document.Add(table);
            document.Close();
        }

        private void exportIemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable d = (new MidItem()).selectItems();
            ExportPDF(d, "Report Items.pdf");
            MessageBox.Show("The report has created in 'Report Item.pdf'");
        }

        private void agentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataTable d = (new MidAgent()).selectAgents();
            ExportPDF(d, "Report Agents.pdf");   
            MessageBox.Show("The report has created in 'Report Agents.pdf'");
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable d = (new MidOder()).selectOders();
            ExportPDF(d, "Report Orders.pdf");         
            MessageBox.Show("The report has created in 'Report Orders.pdf'");
        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable d = (new MidODetail()).selectODetails();
            ExportPDF(d, "Report Orders Details.pdf");
            MessageBox.Show("The report has created in 'Report Order Details.pdf'");
        }
    }
}
