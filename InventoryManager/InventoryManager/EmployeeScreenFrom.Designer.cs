namespace InventoryManager
{
    partial class EmployeeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeScreen));
            this.Header = new System.Windows.Forms.Label();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewStock = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditInventory = new System.Windows.Forms.Button();
            this.btnStockList = new System.Windows.Forms.Button();
            this.lowStock_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.newPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.newBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newTitle = new System.Windows.Forms.TextBox();
            this.editInventory = new System.Windows.Forms.DataGridView();
            this.removeInventory_btn = new System.Windows.Forms.Button();
            this.addInventory_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lowStockList = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editInventory)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowStockList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(608, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(180, 39);
            this.Header.TabIndex = 6;
            this.Header.Text = "Employee";
            this.Header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Header.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.LoginLogo.Location = new System.Drawing.Point(0, -2);
            this.LoginLogo.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(318, 181);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 7;
            this.LoginLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(990, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 36);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewStock);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(257, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 402);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // viewStock
            // 
            this.viewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStock.Location = new System.Drawing.Point(121, -18);
            this.viewStock.Margin = new System.Windows.Forms.Padding(2);
            this.viewStock.Name = "viewStock";
            this.viewStock.RowTemplate.Height = 24;
            this.viewStock.Size = new System.Drawing.Size(750, 569);
            this.viewStock.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(835, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Stock";
            // 
            // btnEditInventory
            // 
            this.btnEditInventory.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditInventory.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditInventory.Location = new System.Drawing.Point(784, 86);
            this.btnEditInventory.Name = "btnEditInventory";
            this.btnEditInventory.Size = new System.Drawing.Size(148, 67);
            this.btnEditInventory.TabIndex = 15;
            this.btnEditInventory.Text = "Edit Store Inventory";
            this.btnEditInventory.UseVisualStyleBackColor = false;
            this.btnEditInventory.Click += new System.EventHandler(this.btnEditInventory_Click);
            // 
            // btnStockList
            // 
            this.btnStockList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStockList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStockList.Location = new System.Drawing.Point(938, 86);
            this.btnStockList.Name = "btnStockList";
            this.btnStockList.Size = new System.Drawing.Size(148, 67);
            this.btnStockList.TabIndex = 16;
            this.btnStockList.Text = "List Store Stock";
            this.btnStockList.UseVisualStyleBackColor = false;
            this.btnStockList.Click += new System.EventHandler(this.btnStockList_Click);
            // 
            // lowStock_btn
            // 
            this.lowStock_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lowStock_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lowStock_btn.Location = new System.Drawing.Point(630, 86);
            this.lowStock_btn.Name = "lowStock_btn";
            this.lowStock_btn.Size = new System.Drawing.Size(148, 67);
            this.lowStock_btn.TabIndex = 17;
            this.lowStock_btn.Text = "Run Low Stock Report";
            this.lowStock_btn.UseVisualStyleBackColor = false;
            this.lowStock_btn.Click += new System.EventHandler(this.btnListInventory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.newPrice);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.newBrand);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.newType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.newDetails);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.newTitle);
            this.panel2.Controls.Add(this.editInventory);
            this.panel2.Controls.Add(this.removeInventory_btn);
            this.panel2.Controls.Add(this.addInventory_btn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(260, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 402);
            this.panel2.TabIndex = 20;
            this.panel2.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(202, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Price";
            this.label11.Visible = false;
            // 
            // newPrice
            // 
            this.newPrice.Location = new System.Drawing.Point(205, 222);
            this.newPrice.Name = "newPrice";
            this.newPrice.Size = new System.Drawing.Size(216, 20);
            this.newPrice.TabIndex = 31;
            this.newPrice.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(202, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Brand";
            this.label10.Visible = false;
            // 
            // newBrand
            // 
            this.newBrand.Location = new System.Drawing.Point(205, 331);
            this.newBrand.Name = "newBrand";
            this.newBrand.Size = new System.Drawing.Size(216, 20);
            this.newBrand.TabIndex = 29;
            this.newBrand.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(202, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Type";
            this.label4.Visible = false;
            // 
            // newType
            // 
            this.newType.Location = new System.Drawing.Point(205, 275);
            this.newType.Name = "newType";
            this.newType.Size = new System.Drawing.Size(216, 20);
            this.newType.TabIndex = 27;
            this.newType.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(202, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Details";
            this.label3.Visible = false;
            // 
            // newDetails
            // 
            this.newDetails.Location = new System.Drawing.Point(205, 165);
            this.newDetails.Name = "newDetails";
            this.newDetails.Size = new System.Drawing.Size(216, 20);
            this.newDetails.TabIndex = 25;
            this.newDetails.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(202, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Title";
            this.label2.Visible = false;
            // 
            // newTitle
            // 
            this.newTitle.Location = new System.Drawing.Point(205, 106);
            this.newTitle.Name = "newTitle";
            this.newTitle.Size = new System.Drawing.Size(216, 20);
            this.newTitle.TabIndex = 23;
            this.newTitle.Visible = false;
            // 
            // editInventory
            // 
            this.editInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editInventory.Location = new System.Drawing.Point(334, -18);
            this.editInventory.Margin = new System.Windows.Forms.Padding(2);
            this.editInventory.Name = "editInventory";
            this.editInventory.RowTemplate.Height = 24;
            this.editInventory.Size = new System.Drawing.Size(563, 409);
            this.editInventory.TabIndex = 22;
            // 
            // removeInventory_btn
            // 
            this.removeInventory_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.removeInventory_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.removeInventory_btn.Location = new System.Drawing.Point(33, 246);
            this.removeInventory_btn.Name = "removeInventory_btn";
            this.removeInventory_btn.Size = new System.Drawing.Size(148, 67);
            this.removeInventory_btn.TabIndex = 21;
            this.removeInventory_btn.Text = "Remove Inventory";
            this.removeInventory_btn.UseVisualStyleBackColor = false;
            this.removeInventory_btn.Click += new System.EventHandler(this.removeInventory_btn_Click_1);
            // 
            // addInventory_btn
            // 
            this.addInventory_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addInventory_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addInventory_btn.Location = new System.Drawing.Point(33, 141);
            this.addInventory_btn.Name = "addInventory_btn";
            this.addInventory_btn.Size = new System.Drawing.Size(148, 67);
            this.addInventory_btn.TabIndex = 20;
            this.addInventory_btn.Text = "Add Inventory";
            this.addInventory_btn.UseVisualStyleBackColor = false;
            this.addInventory_btn.Click += new System.EventHandler(this.addInventory_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edit Store Inventory";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lowStockList);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(257, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 393);
            this.panel3.TabIndex = 22;
            this.panel3.Visible = false;
            // 
            // lowStockList
            // 
            this.lowStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowStockList.Location = new System.Drawing.Point(398, 73);
            this.lowStockList.Margin = new System.Windows.Forms.Padding(2);
            this.lowStockList.Name = "lowStockList";
            this.lowStockList.RowTemplate.Height = 24;
            this.lowStockList.Size = new System.Drawing.Size(563, 295);
            this.lowStockList.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(208, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 67);
            this.button4.TabIndex = 20;
            this.button4.Text = "Notify Manager";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Low Stock List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(257, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 393);
            this.panel4.TabIndex = 23;
            this.panel4.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(398, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 67);
            this.button5.TabIndex = 21;
            this.button5.Text = "Game Titles, Prices Details ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(235, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 67);
            this.button6.TabIndex = 20;
            this.button6.Text = "List Low Stock";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(728, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "Under Construction";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(633, 93);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(491, 300);
            this.textBox6.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(675, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "List Store Stock";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1277, 733);
            this.Controls.Add(this.lowStock_btn);
            this.Controls.Add(this.btnStockList);
            this.Controls.Add(this.btnEditInventory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.LoginLogo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Store Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CUSTOMER_SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editInventory)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowStockList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditInventory;
        private System.Windows.Forms.Button btnStockList;
        private System.Windows.Forms.Button lowStock_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeInventory_btn;
        private System.Windows.Forms.Button addInventory_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView viewStock;
        public System.Windows.Forms.DataGridView editInventory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newBrand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newTitle;
        public System.Windows.Forms.DataGridView lowStockList;
    }
}