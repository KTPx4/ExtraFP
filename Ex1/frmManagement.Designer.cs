namespace Ex1
{
    partial class frmManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.grbControl = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.cbbTop = new System.Windows.Forms.ComboBox();
            this.txtSNameA = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSNameI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.txtODDAgent = new System.Windows.Forms.TextBox();
            this.txtODDunit = new System.Windows.Forms.TextBox();
            this.txtODDquan = new System.Windows.Forms.TextBox();
            this.txtODDItem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnODDlistItem = new System.Windows.Forms.Button();
            this.btnODDshowO = new System.Windows.Forms.Button();
            this.btnODDshowOD = new System.Windows.Forms.Button();
            this.btnODDaddItem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabAgents = new System.Windows.Forms.TabPage();
            this.txtAgentAddress = new System.Windows.Forms.TextBox();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemCountry = new System.Windows.Forms.TextBox();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMana = new System.Windows.Forms.TabControl();
            this.grbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.grbControl.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabOrder.SuspendLayout();
            this.tabAgents.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.tabMana.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbData
            // 
            this.grbData.Controls.Add(this.dgvInfo);
            this.grbData.Location = new System.Drawing.Point(32, 286);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(974, 385);
            this.grbData.TabIndex = 4;
            this.grbData.TabStop = false;
            this.grbData.Text = "Data";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeColumns = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(6, 25);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.RowHeadersVisible = false;
            this.dgvInfo.RowHeadersWidth = 62;
            this.dgvInfo.RowTemplate.Height = 28;
            this.dgvInfo.Size = new System.Drawing.Size(963, 354);
            this.dgvInfo.TabIndex = 0;
            this.dgvInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfo_CellClick);
            // 
            // grbControl
            // 
            this.grbControl.Controls.Add(this.btnAdd);
            this.grbControl.Controls.Add(this.btnCancel);
            this.grbControl.Controls.Add(this.btnRemove);
            this.grbControl.Controls.Add(this.btnSave);
            this.grbControl.Controls.Add(this.btnEdit);
            this.grbControl.Location = new System.Drawing.Point(32, 201);
            this.grbControl.Name = "grbControl";
            this.grbControl.Size = new System.Drawing.Size(974, 79);
            this.grbControl.TabIndex = 5;
            this.grbControl.TabStop = false;
            this.grbControl.Text = "Control";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(763, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(600, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 36);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(240, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 36);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.label17);
            this.tabSearch.Controls.Add(this.cbbTop);
            this.tabSearch.Controls.Add(this.txtSNameA);
            this.tabSearch.Controls.Add(this.label16);
            this.tabSearch.Controls.Add(this.txtSNameI);
            this.tabSearch.Controls.Add(this.label4);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(966, 140);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(286, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Top Items";
            // 
            // cbbTop
            // 
            this.cbbTop.FormattingEnabled = true;
            this.cbbTop.Items.AddRange(new object[] {
            "Top 10",
            "Top 20",
            "Top 30",
            "Top 40"});
            this.cbbTop.Location = new System.Drawing.Point(385, 89);
            this.cbbTop.Name = "cbbTop";
            this.cbbTop.Size = new System.Drawing.Size(199, 28);
            this.cbbTop.TabIndex = 14;
            this.cbbTop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtSNameA
            // 
            this.txtSNameA.Location = new System.Drawing.Point(634, 27);
            this.txtSNameA.Multiline = true;
            this.txtSNameA.Name = "txtSNameA";
            this.txtSNameA.Size = new System.Drawing.Size(172, 30);
            this.txtSNameA.TabIndex = 13;
            this.txtSNameA.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(523, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 20);
            this.label16.TabIndex = 12;
            this.label16.Text = "Agent Name";
            // 
            // txtSNameI
            // 
            this.txtSNameI.Location = new System.Drawing.Point(265, 27);
            this.txtSNameI.Multiline = true;
            this.txtSNameI.Name = "txtSNameI";
            this.txtSNameI.Size = new System.Drawing.Size(199, 30);
            this.txtSNameI.TabIndex = 11;
            this.txtSNameI.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = " Name Item";
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.txtODDAgent);
            this.tabOrder.Controls.Add(this.txtODDunit);
            this.tabOrder.Controls.Add(this.txtODDquan);
            this.tabOrder.Controls.Add(this.txtODDItem);
            this.tabOrder.Controls.Add(this.label15);
            this.tabOrder.Controls.Add(this.btnODDlistItem);
            this.tabOrder.Controls.Add(this.btnODDshowO);
            this.tabOrder.Controls.Add(this.btnODDshowOD);
            this.tabOrder.Controls.Add(this.btnODDaddItem);
            this.tabOrder.Controls.Add(this.label14);
            this.tabOrder.Controls.Add(this.label11);
            this.tabOrder.Controls.Add(this.label12);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(961, 140);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order Items";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // txtODDAgent
            // 
            this.txtODDAgent.Location = new System.Drawing.Point(95, 28);
            this.txtODDAgent.Multiline = true;
            this.txtODDAgent.Name = "txtODDAgent";
            this.txtODDAgent.Size = new System.Drawing.Size(133, 34);
            this.txtODDAgent.TabIndex = 23;
            // 
            // txtODDunit
            // 
            this.txtODDunit.Location = new System.Drawing.Point(339, 29);
            this.txtODDunit.Multiline = true;
            this.txtODDunit.Name = "txtODDunit";
            this.txtODDunit.Size = new System.Drawing.Size(159, 33);
            this.txtODDunit.TabIndex = 17;
            this.txtODDunit.TextChanged += new System.EventHandler(this.txtODDunit_TextChanged);
            // 
            // txtODDquan
            // 
            this.txtODDquan.Location = new System.Drawing.Point(339, 91);
            this.txtODDquan.Multiline = true;
            this.txtODDquan.Name = "txtODDquan";
            this.txtODDquan.Size = new System.Drawing.Size(159, 34);
            this.txtODDquan.TabIndex = 15;
            this.txtODDquan.TextChanged += new System.EventHandler(this.txtODDquan_TextChanged);
            // 
            // txtODDItem
            // 
            this.txtODDItem.Location = new System.Drawing.Point(95, 90);
            this.txtODDItem.Multiline = true;
            this.txtODDItem.Name = "txtODDItem";
            this.txtODDItem.Size = new System.Drawing.Size(133, 33);
            this.txtODDItem.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "Agent ID";
            // 
            // btnODDlistItem
            // 
            this.btnODDlistItem.Location = new System.Drawing.Point(540, 25);
            this.btnODDlistItem.Name = "btnODDlistItem";
            this.btnODDlistItem.Size = new System.Drawing.Size(145, 44);
            this.btnODDlistItem.TabIndex = 21;
            this.btnODDlistItem.Text = "Show list Item";
            this.btnODDlistItem.UseVisualStyleBackColor = true;
            this.btnODDlistItem.Click += new System.EventHandler(this.btnODDlistItem_Click);
            // 
            // btnODDshowO
            // 
            this.btnODDshowO.Location = new System.Drawing.Point(716, 25);
            this.btnODDshowO.Name = "btnODDshowO";
            this.btnODDshowO.Size = new System.Drawing.Size(179, 44);
            this.btnODDshowO.TabIndex = 20;
            this.btnODDshowO.Text = "Show Order";
            this.btnODDshowO.UseVisualStyleBackColor = true;
            this.btnODDshowO.Click += new System.EventHandler(this.btnODDshowO_Click);
            // 
            // btnODDshowOD
            // 
            this.btnODDshowOD.Location = new System.Drawing.Point(716, 85);
            this.btnODDshowOD.Name = "btnODDshowOD";
            this.btnODDshowOD.Size = new System.Drawing.Size(179, 44);
            this.btnODDshowOD.TabIndex = 19;
            this.btnODDshowOD.Text = "Show OrderDetail";
            this.btnODDshowOD.UseVisualStyleBackColor = true;
            this.btnODDshowOD.Click += new System.EventHandler(this.btnODDshowOD_Click);
            // 
            // btnODDaddItem
            // 
            this.btnODDaddItem.Location = new System.Drawing.Point(540, 85);
            this.btnODDaddItem.Name = "btnODDaddItem";
            this.btnODDaddItem.Size = new System.Drawing.Size(145, 44);
            this.btnODDaddItem.TabIndex = 18;
            this.btnODDaddItem.Text = "Add Item";
            this.btnODDaddItem.UseVisualStyleBackColor = true;
            this.btnODDaddItem.Click += new System.EventHandler(this.btnODDaddItem_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Unit Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Item ID";
            // 
            // tabAgents
            // 
            this.tabAgents.Controls.Add(this.txtAgentAddress);
            this.tabAgents.Controls.Add(this.txtAgentName);
            this.tabAgents.Controls.Add(this.txtAgentID);
            this.tabAgents.Controls.Add(this.label10);
            this.tabAgents.Controls.Add(this.label9);
            this.tabAgents.Controls.Add(this.label8);
            this.tabAgents.Controls.Add(this.label1);
            this.tabAgents.Location = new System.Drawing.Point(4, 29);
            this.tabAgents.Name = "tabAgents";
            this.tabAgents.Padding = new System.Windows.Forms.Padding(3);
            this.tabAgents.Size = new System.Drawing.Size(961, 140);
            this.tabAgents.TabIndex = 1;
            this.tabAgents.Text = "Agents";
            this.tabAgents.UseVisualStyleBackColor = true;
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.Location = new System.Drawing.Point(711, 57);
            this.txtAgentAddress.Multiline = true;
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.Size = new System.Drawing.Size(181, 38);
            this.txtAgentAddress.TabIndex = 9;
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(413, 56);
            this.txtAgentName.Multiline = true;
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(181, 38);
            this.txtAgentName.TabIndex = 7;
            // 
            // txtAgentID
            // 
            this.txtAgentID.Location = new System.Drawing.Point(132, 57);
            this.txtAgentID.Multiline = true;
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(181, 38);
            this.txtAgentID.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agents";
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.label7);
            this.tabItems.Controls.Add(this.txtItemCountry);
            this.tabItems.Controls.Add(this.txtItemType);
            this.tabItems.Controls.Add(this.txtItemName);
            this.tabItems.Controls.Add(this.txtItemSize);
            this.tabItems.Controls.Add(this.txtItemID);
            this.tabItems.Controls.Add(this.label6);
            this.tabItems.Controls.Add(this.label5);
            this.tabItems.Controls.Add(this.label3);
            this.tabItems.Controls.Add(this.label2);
            this.tabItems.Location = new System.Drawing.Point(4, 29);
            this.tabItems.Margin = new System.Windows.Forms.Padding(0);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabItems.Size = new System.Drawing.Size(961, 140);
            this.tabItems.TabIndex = 0;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Country";
            // 
            // txtItemCountry
            // 
            this.txtItemCountry.Location = new System.Drawing.Point(747, 19);
            this.txtItemCountry.Multiline = true;
            this.txtItemCountry.Name = "txtItemCountry";
            this.txtItemCountry.Size = new System.Drawing.Size(186, 37);
            this.txtItemCountry.TabIndex = 11;
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(406, 94);
            this.txtItemType.Multiline = true;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(186, 37);
            this.txtItemType.TabIndex = 9;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(106, 92);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(186, 37);
            this.txtItemName.TabIndex = 7;
            // 
            // txtItemSize
            // 
            this.txtItemSize.Location = new System.Drawing.Point(407, 16);
            this.txtItemSize.Multiline = true;
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(186, 37);
            this.txtItemSize.TabIndex = 3;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(108, 16);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(186, 37);
            this.txtItemID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // tabMana
            // 
            this.tabMana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMana.Controls.Add(this.tabItems);
            this.tabMana.Controls.Add(this.tabAgents);
            this.tabMana.Controls.Add(this.tabOrder);
            this.tabMana.Controls.Add(this.tabSearch);
            this.tabMana.Location = new System.Drawing.Point(32, 22);
            this.tabMana.Name = "tabMana";
            this.tabMana.SelectedIndex = 0;
            this.tabMana.Size = new System.Drawing.Size(974, 173);
            this.tabMana.TabIndex = 3;
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 698);
            this.ControlBox = false;
            this.Controls.Add(this.grbControl);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.tabMana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.grbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.grbControl.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.tabAgents.ResumeLayout(false);
            this.tabAgents.PerformLayout();
            this.tabItems.ResumeLayout(false);
            this.tabItems.PerformLayout();
            this.tabMana.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.GroupBox grbControl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtSNameI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TextBox txtODDAgent;
        private System.Windows.Forms.TextBox txtODDunit;
        private System.Windows.Forms.TextBox txtODDquan;
        private System.Windows.Forms.TextBox txtODDItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnODDlistItem;
        private System.Windows.Forms.Button btnODDshowO;
        private System.Windows.Forms.Button btnODDshowOD;
        private System.Windows.Forms.Button btnODDaddItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabAgents;
        private System.Windows.Forms.TextBox txtAgentAddress;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.TextBox txtAgentID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemCountry;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabMana;
        private System.Windows.Forms.TextBox txtSNameA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbbTop;
    }
}