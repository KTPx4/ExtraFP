using Ex1.Data;
using Ex1.Mid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ex1
{
    public partial class frmManagement : Form
    {
        public int tab { get; set; }

        private static  DataTable ListItem;
        private static int edit = 0; // =0 for add new rows, = 1 for edit row
        private static int editOrderDetail = 0; // 0 for edit listItem, other is block edit
        private static int indexList = 0; // index of list item when click in dataGridView
        private static int clickItem = 0; // 1 for click in list, 0 is add new item
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
            
            edit = 0;
            showTab(this.tab);
            blockControl(false);
            btnAdd.Enabled = true;
            if(tab == 0)
            {
                clearTxtItem();
                //showDGV(new MidItem().selectItems());
            }
            else if(tab == 1)
            {

                clearTxtAgent();
                //showDGV(new MidAgent().selectAgents());
            }
            else if(tab == 2)
            {
                clearTxtO();
                //showDGV(ListItem);
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
            TabPage Hide3 = tabSearch;
            blockControl(false);
            if (tab == 0)
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
                showDGV(ListItem);
                btnODDaddItem.Enabled = false;
                blockTxtO(false);
                addListItem();
            }
            else if(tab == 3)
            {
                Show = tabSearch;
                Hide3 = tabItems;
                showDGV(new DataTable());
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
            if (tabMana.TabPages.Contains(Hide3))
            {
                tabMana.TabPages.Remove(Hide3);
            }


        }
        void addListItem()
        {
            ListItem = new DataTable();
            ListItem.Columns.Add("ID", typeof(string));
            ListItem.Columns.Add("Name", typeof(string));
        
            ListItem.Columns.Add("Country", typeof(string));
            ListItem.Columns.Add("Quantity", typeof(int));
        }
     
        void blockTxtItem(bool b)
        {
            txtItemID.Enabled = b;
            txtItemName.Enabled = b;
            txtItemSize.Enabled = b;
            txtItemType.Enabled = b;
         
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
            // txtODDID.Enabled = b;
            txtODDItem.Enabled = b;
            txtODDquan.Enabled = b;
            txtODDunit.Enabled = b;
            txtODDAgent.Enabled = b;
        }
        void clearTxtItem()
        {
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtItemSize.Text = "";
            txtItemType.Text = "";
        
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
            // txtODDID.Text = "";
            txtODDItem.Text = "";
            txtODDquan.Text = "";
            txtODDunit.Text = "";
            txtODDAgent.Text = "";
        }
        void cleartxtSearch()
        {
            txtSIDI.Text = "";
            txtSNameI.Text = "";
            txtSNameA.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            edit = 0;
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
                btnODDaddItem.Enabled = true;
                clearTxtO();
                MidODetail o = new MidODetail();
                // txtODDID.Text = o.getID();

            }
        }
        bool is_exists_Agent(string id)
        {
            MidAgent a = new MidAgent(id, "", "");
      
            DataTable t = a.selectAgent();
            if (t.Rows.Count < 1)
                return false;

            return true;
        }
        string createOrder()
        {
            string agent = txtODDAgent.Text;
            string item = txtODDItem.Text;
            string unit = txtODDunit.Text;
            string quan = txtODDquan.Text;

            if(agent == "" || item=="" || unit == "" || quan == "")
            {
                MessageBox.Show("Please input full value!");
                return "";
            }
            string currentDate = DateTime.Now.ToString("yyyy/MM/dd");
            if(!is_exists_Agent(agent))
            {
                MessageBox.Show("IDAgent is not exists in data of Agent");
                return "";
            }
            
            string id =(new MidOder()).getID();
            MidOder o = new MidOder(id, currentDate, agent);
            o.addOrder();
            return id;
            //MessageBox.Show(currentDate);
        }
        int createODetail(string ido)
        {
            int count = 0;
            float unit = float.Parse(txtODDunit.Text);
            //ListItem.Columns.Add("ID", typeof(string));
            //ListItem.Columns.Add("Name", typeof(string));
            //ListItem.Columns.Add("Country", typeof(string));
            //ListItem.Columns.Add("Quantity", typeof(int));
            foreach(DataRow r in ListItem.Rows)
            {
                string idItem = r[0].ToString();
                int quan = int.Parse(r[3].ToString());
                MidODetail o = new MidODetail();
                string idOD = o.getID();
                MidODetail add = new MidODetail(idOD, ido, idItem, quan, unit);
                add.addODetail();
                count++;
                //MessageBox.Show(idItem);
            }
            return count;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {
                if (this.tab == 0)
                {
                    string id = txtItemID.Text;
                    string name = txtItemName.Text;
                    string size = txtItemSize.Text;
                    string type = txtItemType.Text;

                    string country = txtItemCountry.Text;

                    if (id == "" || name == "" || size == "" || type == "" || country == "")
                    {
                        MessageBox.Show("Please input full value!");
                        return;
                    }


                    MidItem it = new MidItem(id, name, size, type, country);
                    //MessageBox.Show(it.ToString());
                    it.addItem();
                    //showDGV(new MidItem().selectItems());



                }
                else if (this.tab == 1)
                {
                    string id = txtAgentID.Text;
                    string name = txtAgentName.Text;
                    string add = txtAgentAddress.Text;
                    if (id == "" || name == "" || add == "")
                    {
                        MessageBox.Show("Please input full value!");
                        return;
                    }
                    MidAgent ag = new MidAgent(id, name, add);
                    ag.addAgent();


                }

                else if (this.tab == 2)
                {
                    string id = createOrder();
                    if(id =="")
                    {
                        MessageBox.Show("Order Item failled");
                    }
                    MessageBox.Show("Order Success, " + createODetail(id) +" rows for Order Detail has been insert!");
                
                    //1 order is more order detail (each order detail is 1 item, but same id order)
                }
            }
            else
            {
                if (this.tab == 0)
                {
                    string id = txtItemID.Text;
                    string name = txtItemName.Text;
                    string size = txtItemSize.Text;
                    string type = txtItemType.Text;

                    string country = txtItemCountry.Text;

                    if (id == "" || name == "" || size == "" || type == "" || country == "")
                    {
                        MessageBox.Show("Please input full value!");
                        return;
                    }


                    MidItem it = new MidItem(id, name, size, type, country);
                    //MessageBox.Show(it.ToString());
                    it.editItem();
                    //showDGV(new MidItem().selectItems());



                }
                else if (this.tab == 1)
                {
                    string id = txtAgentID.Text;
                    string name = txtAgentName.Text;
                    string add = txtAgentAddress.Text;
                    if (id == "" || name == "" || add == "")
                    {
                        MessageBox.Show("Please input full value!");
                        return;
                    }
                    MidAgent ag = new MidAgent(id, name, add);
                    ag.editAgent();


                }
                else if(this.tab == 2)
                {
                    if(editOrderDetail == 0)
                    {
                        addData();
                    }
                }

            }
            load();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            load();
        }

        void addData()
        {
            if (txtODDItem.Text == "")
            {
                MessageBox.Show("Please input ID item");
                txtODDItem.Focus();
                return;
            }
            if (txtODDquan.Text == "")
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
                MessageBox.Show("This Item is not exists in data of Item");
                txtODDItem.Text = "";
                return;
            }
            else
            {
                if(edit == 0)
                {
                    foreach (DataRow dr in tb.Rows)
                    {
                        string ids = dr[0].ToString();

                        DataRow[] foundRows = ListItem.Select("ID = '" + ids + "'");

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
                          
                            //ListItem.Columns.Add("Country");
                            //ListItem.Columns.Add("Quantity");

                            ListItem.Rows.Add(ids, dr[1], dr[4], quan);

                            // id does not exist in the DataTable
                        }
                    }               

                }
                else
                {
                    //MessageBox.Show("ok" );
                    foreach (DataRow dr in tb.Rows)
                    {
                       

                        DataRow[] foundRows = ListItem.Select("ID = '" + id + "'");


                        if (foundRows.Length > 0 )
                        {
                            int rowIndex = ListItem.Rows.IndexOf(foundRows[0]);
                            MessageBox.Show("" + rowIndex + " , " + indexList);
                            if( rowIndex != indexList)
                            {

                                MessageBox.Show("This Item is already in list");
                                txtODDItem.Text = "";
                                return;

                            }
                            else
                            {
                                ListItem.Rows[rowIndex]["ID"] = id;
                                ListItem.Rows[rowIndex]["Name"] = dr[1];
                                ListItem.Rows[rowIndex]["Country"] = dr[4];
                                ListItem.Rows[rowIndex]["Quantity"] = quan;

                                txtODDItem.Text = "";
                                txtODDquan.Text = "";
                                
                            }

                            // id exists in the DataTable
                        }
                        else
                        {
                            
                            ListItem.Rows[indexList]["ID"] = id;
                            ListItem.Rows[indexList]["Name"] = dr[1];
                            ListItem.Rows[indexList]["Country"] = dr[4];
                            ListItem.Rows[indexList]["Quantity"] = quan;

                            txtODDItem.Text = "";
                            txtODDquan.Text = "";
                           
                        }


                    }


                }
              
            }



            edit = 0;
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
            //if(clickItem == 1)
            //{
            //    edit = 0;
            //    txtODDquan.Text = "";
            //    txtODDItem.Text = "";
            //    txtODDItem.Focus();
            //    return;
            //}
            blockTxtO(true);
            addData();
            btnSave.Enabled = true;
            btnEdit.Enabled= false;
        }

        private void btnODDlistItem_Click(object sender, EventArgs e)
        {
            showDGV(ListItem);
            editOrderDetail = 0;
        }

        private void btnODDshowO_Click(object sender, EventArgs e)
        {
            showDGV(new MidOder().selectOders());
            editOrderDetail = 1;
        }

        private void btnODDshowOD_Click(object sender, EventArgs e)
        {
            showDGV(new MidODetail().selectODetails());
            editOrderDetail = 2;
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvInfo.CurrentRow.Index;
            if(this.tab != 2)
            {
                btnEdit.Enabled = true;
                btnRemove.Enabled = true;

            }
            if(this.tab == 0)
            {
                blockTxtItem(false);
                txtItemID.Text = dgvInfo.Rows[index].Cells[0].Value.ToString();
                txtItemName.Text = dgvInfo.Rows[index].Cells[1].Value.ToString();
                txtItemSize.Text = dgvInfo.Rows[index].Cells[2].Value.ToString();
                txtItemType.Text = dgvInfo.Rows[index].Cells[3].Value.ToString();
                txtItemCountry.Text = dgvInfo.Rows[index].Cells[4].Value.ToString();
            }
            else if(this.tab == 1)
            {
               txtAgentID.Text = dgvInfo.Rows[index].Cells[0].Value.ToString();
                txtAgentName.Text = dgvInfo.Rows[index].Cells[1].Value.ToString();
                txtAgentAddress.Text = dgvInfo.Rows[index].Cells[2].Value.ToString();

            }
            else if(this.tab == 2)
            {
                if(editOrderDetail == 0)
                {
                    //ListItem.Columns.Add("ID", typeof(string));
                    //ListItem.Columns.Add("Name", typeof(string));

                    //ListItem.Columns.Add("Country", typeof(string));
                    //ListItem.Columns.Add("Quantity", typeof(int));
                    clickItem = 1;
                    txtODDItem.Text = dgvInfo.Rows[index].Cells[0].Value.ToString();
                    txtODDquan.Text = dgvInfo.Rows[index].Cells[3].Value.ToString();
                    indexList = index;
                    txtODDItem.Enabled = false;
                    txtODDquan.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            btnSave.Enabled = true;
            if(this.tab == 0)
            {
                blockTxtItem(true);
              
              
                txtItemID.Enabled = false;
            }
            else if (this.tab == 1)
            {
                blockTxtAgent(true);

                MidItem it_id = new MidItem();
                txtAgentID.Enabled = false;
            }
            else if(this.tab == 2)
            {
                if(editOrderDetail == 0)
                {
                    blockTxtO(false);
                    txtODDItem.Enabled = true;
                    txtODDquan.Enabled = true;
                    txtODDItem.Focus();
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createODetail("");
        }

        private void txtODDunit_TextChanged(object sender, EventArgs e)
        {
            if (txtODDunit.Text == "")
            {
                return;
            }
            if (!float.TryParse(txtODDunit.Text, out float n))
            {
                MessageBox.Show("Please input Unit Amount same as money!");
                txtODDunit.Text = "";
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = dgvInfo.CurrentRow.Index;
          
            if (this.tab == 0)
            {
                blockTxtItem(false);
                string ItemID  = dgvInfo.Rows[index].Cells[0].Value.ToString();
                string Name = dgvInfo.Rows[index].Cells[1].Value.ToString();
                string ItemSize = dgvInfo.Rows[index].Cells[2].Value.ToString();
                string ItemType = dgvInfo.Rows[index].Cells[3].Value.ToString();
                string ItemCountry = dgvInfo.Rows[index].Cells[4].Value.ToString();
                MidItem i = new MidItem(ItemID, Name, ItemSize, ItemType, ItemCountry);
                i.deleteItem();

            }
            else if (this.tab == 1)
            {
                string AgentID = dgvInfo.Rows[index].Cells[0].Value.ToString();
                //string AgentName = dgvInfo.Rows[index].Cells[1].Value.ToString();
                //string AgentAddress = dgvInfo.Rows[index].Cells[2].Value.ToString();
                MidAgent a = new MidAgent(AgentID, "", "");
                a.deleteAgent();
            }
            else if (this.tab == 2)
            {
                if (editOrderDetail == 0)
                {
                    //ListItem.Columns.Add("ID", typeof(string));
                    //ListItem.Columns.Add("Name", typeof(string));

                    //ListItem.Columns.Add("Country", typeof(string));
                    //ListItem.Columns.Add("Quantity", typeof(int));
               
                    string ODDItem = dgvInfo.Rows[index].Cells[0].Value.ToString();
                    //string txtODDquan = dgvInfo.Rows[index].Cells[3].Value.ToString();
                    DataRow[] foundRows = ListItem.Select("ID = '" + ODDItem + "'");

                    if (foundRows.Length > 0)
                    {
                        // Lấy dòng đầu tiên trong các dòng được tìm thấy
                        DataRow rowToDelete = foundRows[0];

                        // Xóa dòng đó khỏi DataTable
                        rowToDelete.Delete();
                    }
                }
            }
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTop.Text == "")
            {
                return;
            }
            cleartxtSearch();
            MidItem i = new MidItem();
            string[] arr = cbbTop.Text.Split(' ');
            showDGV(i.selectTop(arr[1]));
        }

        private void txtSIDI_TextChanged(object sender, EventArgs e)
        {
            if(txtSIDI.Text == "")
            {
                return;
            }
            
            if(txtSNameI.Text == "" && txtSNameA.Text == "")
            {
                MidItem i = new MidItem(txtSIDI.Text);
                showDGV(i.selectItem());
                return;
                
            }
            if (txtSNameI.Text != "" && txtSNameA.Text == "")
            {
                string s = "SELECT * FROM Item WHERE ItemID = '" + txtSIDI.Text+ "' AND ItemName = '" + txtSNameI.Text +"'";
                MidItem i = new MidItem();
                showDGV(i.select(s));
                return;
            }


        }

       
    }
}
