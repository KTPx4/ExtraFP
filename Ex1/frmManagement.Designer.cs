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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Items = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.Agents = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Items.SuspendLayout();
            this.Agents.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Items);
            this.tabControl1.Controls.Add(this.Agents);
            this.tabControl1.Location = new System.Drawing.Point(58, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 544);
            this.tabControl1.TabIndex = 3;
            // 
            // Items
            // 
            this.Items.Controls.Add(this.label2);
            this.Items.Location = new System.Drawing.Point(4, 29);
            this.Items.Name = "Items";
            this.Items.Padding = new System.Windows.Forms.Padding(3);
            this.Items.Size = new System.Drawing.Size(917, 511);
            this.Items.TabIndex = 0;
            this.Items.Text = "Items";
            this.Items.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item";
            // 
            // Agents
            // 
            this.Agents.Controls.Add(this.label1);
            this.Agents.Location = new System.Drawing.Point(4, 29);
            this.Agents.Name = "Agents";
            this.Agents.Padding = new System.Windows.Forms.Padding(3);
            this.Agents.Size = new System.Drawing.Size(917, 511);
            this.Agents.TabIndex = 1;
            this.Agents.Text = "Agents";
            this.Agents.UseVisualStyleBackColor = true;
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
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 780);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.tabControl1.ResumeLayout(false);
            this.Items.ResumeLayout(false);
            this.Items.PerformLayout();
            this.Agents.ResumeLayout(false);
            this.Agents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Agents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Items;
    }
}