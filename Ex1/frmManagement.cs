using Ex1.Mid;
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
        public int tab { get; set; }

        private DataTable ListItem;

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

            load();


        }



        void load()
        {
            showTab(this.tab);
            blockControl(false);
            if(tab == 0)
            {
                clearTxtItem();
            }
            else if(tab == 1)
            {
                clearTxtAgent();
            }
            else if(tab == 2)
            {
                clearTxtO();
            }

        }
        private void showDGV(DataTable s)
        {
            dgvInfo.DataSource = s;
        }
        public void showTab(int tab)
        {
            TabPage Show = tabItems;
            TabPage Hide1 = tabAgents;
            TabPage Hide2 = tabOrder;

            
            if(tab == 0)
            {
                blockTxtItem(false);
              
                showDGV(new MidItem().selectItems());
            }
            else if(tab == 1) 
            {
                blockTxtAgent(false);
                Show = tabAgents;
                Hide1 = tabItems;
                showDGV(new MidAgent().selectAgents());

            }
            else if(tab == 2)
            {
                Show = tabOrder;
                Hide2 = tabItems;
                showDGV(new DataTable());
                addListItem();
            }

            if (!tabMana.TabPages.Contains(Show))
            {
                tabMana.TabPages.Add(Show);
            }
            if (tabMana.TabPages.Contains(Hide1))
            {
                tabMana.TabPages.Remove(Hide1);
            }
            if (tabMana.TabPages.Contains(Hide2))
            {
                tabMana.TabPages.Remove(Hide2);
            }
           
        }
        void addListItem()
        {
            ListItem = new DataTable();
            ListItem.Columns.Add("ID", typeof(string));
            ListItem.Columns.Add("Name", typeof(string));
            ListItem.Columns.Add("ProductionDate", typeof(string));
            ListItem.Columns.Add("Country", typeof(string));
            ListItem.Columns.Add("Quantity", typeof(int));
        }
     
        void blockTxtItem(bool b)
        {
            txtItemID.Enabled = b;
            txtItemName.Enabled = b;
            txtItemSize.Enabled = b;
            txtItemType.Enabled = b;
            txtItemDate.Enabled = b;
            txtItemCountry.Enabled = b;            
        }
        void blockTxtAgent(bool b)
        {
            txtAgentID.Enabled = b;
            txtAgentName.Enabled = b;
            txtAgentAddress.Enabled = b;
        }
        void blockControl(bool b)
        {
            btnEdit.Enabled = b;
            btnSave.Enabled = b;
            btnRemove.Enabled = b;
        }        
        void blockTxtO(bool b)
        {
            txtODDID.Enabled = b;
            txtODDItem.Enabled = b;
            txtODDquan.Enabled = b;
            txtODDunit.Enabled = b;
        }
        void clearTxtItem()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtItemSize.Text = "";
            txtItemType.Text = "";
            txtItemDate.Text = "";
            txtItemCountry.Text = "";
        }
        void clearTxtAgent()
        {
            txtAgentID.Text = "";
            txtAgentName.Text = "";
            txtAgentAddress.Text = "";
        }
        void clearTxtO()
        {
            txtODDID.Text = "";
            txtODDItem.Text = "";
            txtODDquan.Text = "";
            txtODDunit.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            if (this.tab == 0)
            {
                blockTxtItem(true);
                clearTxtItem();
                MidItem it_id = new MidItem();
                txtItemID.Text = it_id.getID();
            }
            else if (this.tab == 1)
            {
                blockTxtAgent(true);
                clearTxtAgent();
                MidAgent ag = new MidAgent();
                txtAgentID.Text = ag.getID();
            }
            else if(this.tab == 2)
            {
                blockTxtO(true);
                clearTxtO();
                MidODetail o = new MidODetail();
                txtODDID.Text = o.getID();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.tab == 0)
            {
                string id = txtItemID.Text;
                string name = txtItemName.Text;
                string size = txtItemSize.Text;
                string type = txtItemType.Text;
                string date = txtItemDate.Text;
                string country = txtItemCountry.Text;

                if (id == "" || name == "" || size == "" || type == "" || date == "" || country == "")
                {
                    MessageBox.Show("Please input full value!");
                    return;
                }
               
                    
                MidItem it = new MidItem(id, name, size, type, date, country);
                //MessageBox.Show(it.ToString());
                it.addItem();
                //showDGV(new MidItem().selectItems());
                load();
              
              
            }
            else if(this.tab == 1)
            {
                string id = txtAgentID.Text;
                string name = txtAgentName.Text;
                string add = txtAgentAddress.Text;
                if(id =="" || name =="" || add =="")
                {
                    MessageBox.Show("Please input full value!");
                    return;
                }
                MidAgent ag = new MidAgent(id, name, add);
                ag.addAgent();
                load();

            }

            else if(this.tab == 2)
            {
                //1 order is more order detail (each order detail is 1 item, but same id order)
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        void addData()
        {
            if(txtODDquan.Text == "")
            {
                MessageBox.Show("Please enter Quantity");
                txtODDquan.Focus();
                return;
            }
            string id = txtODDItem.Text;
            int quan = int.Parse(txtODDquan.Text);
            MidItem it = new MidItem(id);
            DataTable tb = it.selectItem();
            if(tb.Rows.Count < 1)
            {
                MessageBox.Show("This Item is not exists in table Item");
                txtODDItem.Text = "";
                return;
            }
            else
            {
                foreach(DataRow dr in tb.Rows)
                {
                    string ids = dr[0].ToString();

                    DataRow[] foundRows = ListItem.Select("ID = '" + ids+"'");

                    if (foundRows.Length > 0)
                    {
                        MessageBox.Show("This Item is already in list");
                        txtODDItem.Text = "";
                        return;
                        // id exists in the DataTable
                    }
                    else
                    {
                        //ListItem.Columns.Add("ID");
                        //ListItem.Columns.Add("Name");
                        //ListItem.Columns.Add("ProductionDate");
                        //ListItem.Columns.Add("Country");
                        //ListItem.Columns.Add("Quantity");

                        ListItem.Rows.Add(ids, dr[1], dr[4], dr[5], quan);

                        // id does not exist in the DataTable
                    }
                }
            }
            showDGV(ListItem);
            return;
        }

        private void txtODDquan_TextChanged(object sender, EventArgs e)
        {
            if(txtODDquan.Text == "")
            {
                return;
            }
            if (!int.TryParse(txtODDquan.Text, out int n))
            {
                MessageBox.Show("Please input quantity is a integer number!");
                txtODDquan.Text = "";
                return;
            }
        }

        private void btnODDaddItem_Click_1(object sender, EventArgs e)
        {
            addData();
            btnSave.Enabled = true;
            
        }

        private void btnODDlistItem_Click(object sender, EventArgs e)
        {
            showDGV(ListItem);
        }

        private void btnODDshowO_Click(object sender, EventArgs e)
        {
            showDGV(new MidOder().selectOders());

        }

        private void btnODDshowOD_Click(object sender, EventArgs e)
        {
            showDGV(new MidODetail().selectODetails());
        }
    }
}
