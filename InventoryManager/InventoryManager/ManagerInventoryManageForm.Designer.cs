namespace InventoryManager
{
    partial class InventoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnManageDetails = new System.Windows.Forms.Button();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.grpbxNavButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxNavButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(708, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnViewAll.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnViewAll.Location = new System.Drawing.Point(21, 27);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(449, 73);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "VIEW ALL INVENTORY";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(1756, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAnalytics.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytics.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAnalytics.Location = new System.Drawing.Point(21, 113);
            this.btnAnalytics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(449, 73);
            this.btnAnalytics.TabIndex = 10;
            this.btnAnalytics.Text = "VIEW ANALYTICS";
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // btnManageDetails
            // 
            this.btnManageDetails.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnManageDetails.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDetails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManageDetails.Location = new System.Drawing.Point(21, 199);
            this.btnManageDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageDetails.Name = "btnManageDetails";
            this.btnManageDetails.Size = new System.Drawing.Size(449, 73);
            this.btnManageDetails.TabIndex = 11;
            this.btnManageDetails.Text = "MANAGE PRODUCT DETAILS";
            this.btnManageDetails.UseVisualStyleBackColor = false;
            this.btnManageDetails.Click += new System.EventHandler(this.btnManageDetails_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnManageStock.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnManageStock.Location = new System.Drawing.Point(21, 285);
            this.btnManageStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(449, 73);
            this.btnManageStock.TabIndex = 12;
            this.btnManageStock.Text = "MANAGE STOCK";
            this.btnManageStock.UseVisualStyleBackColor = false;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // grpbxNavButtons
            // 
            this.grpbxNavButtons.BackColor = System.Drawing.Color.DimGray;
            this.grpbxNavButtons.Controls.Add(this.btnManageStock);
            this.grpbxNavButtons.Controls.Add(this.btnManageDetails);
            this.grpbxNavButtons.Controls.Add(this.btnAnalytics);
            this.grpbxNavButtons.Controls.Add(this.btnViewAll);
            this.grpbxNavButtons.Location = new System.Drawing.Point(714, 395);
            this.grpbxNavButtons.Name = "grpbxNavButtons";
            this.grpbxNavButtons.Size = new System.Drawing.Size(490, 379);
            this.grpbxNavButtons.TabIndex = 13;
            this.grpbxNavButtons.TabStop = false;
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1901, 1035);
            this.Controls.Add(this.grpbxNavButtons);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxNavButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnManageDetails;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.GroupBox grpbxNavButtons;
    }
}