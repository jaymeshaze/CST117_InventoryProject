namespace InventoryManager
{
    partial class AnalyticData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyticData));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.viewInventoryData = new System.Windows.Forms.DataGridView();
            this.btnByBrand = new System.Windows.Forms.Button();
            this.btnByType = new System.Windows.Forms.Button();
            this.btnByItem = new System.Windows.Forms.Button();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.btnAscend = new System.Windows.Forms.Button();
            this.btnDescend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInventoryData)).BeginInit();
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
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(1756, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // viewInventoryData
            // 
            this.viewInventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewInventoryData.Location = new System.Drawing.Point(462, 242);
            this.viewInventoryData.Name = "viewInventoryData";
            this.viewInventoryData.RowTemplate.Height = 24;
            this.viewInventoryData.Size = new System.Drawing.Size(1000, 700);
            this.viewInventoryData.TabIndex = 10;
            // 
            // btnByBrand
            // 
            this.btnByBrand.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByBrand.Location = new System.Drawing.Point(462, 949);
            this.btnByBrand.Margin = new System.Windows.Forms.Padding(4);
            this.btnByBrand.Name = "btnByBrand";
            this.btnByBrand.Size = new System.Drawing.Size(134, 28);
            this.btnByBrand.TabIndex = 11;
            this.btnByBrand.Text = "By Brand";
            this.btnByBrand.UseVisualStyleBackColor = true;
            this.btnByBrand.Click += new System.EventHandler(this.btnByBrand_Click);
            // 
            // btnByType
            // 
            this.btnByType.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByType.Location = new System.Drawing.Point(596, 949);
            this.btnByType.Margin = new System.Windows.Forms.Padding(4);
            this.btnByType.Name = "btnByType";
            this.btnByType.Size = new System.Drawing.Size(134, 28);
            this.btnByType.TabIndex = 12;
            this.btnByType.Text = "By Type";
            this.btnByType.UseVisualStyleBackColor = true;
            this.btnByType.Click += new System.EventHandler(this.btnByType_Click);
            // 
            // btnByItem
            // 
            this.btnByItem.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnByItem.Location = new System.Drawing.Point(730, 949);
            this.btnByItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnByItem.Name = "btnByItem";
            this.btnByItem.Size = new System.Drawing.Size(134, 28);
            this.btnByItem.TabIndex = 13;
            this.btnByItem.Text = "By Item";
            this.btnByItem.UseVisualStyleBackColor = true;
            this.btnByItem.Click += new System.EventHandler(this.btnByItem_Click);
            // 
            // btnPreviousMenu
            // 
            this.btnPreviousMenu.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreviousMenu.Location = new System.Drawing.Point(1289, 949);
            this.btnPreviousMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousMenu.Name = "btnPreviousMenu";
            this.btnPreviousMenu.Size = new System.Drawing.Size(173, 28);
            this.btnPreviousMenu.TabIndex = 14;
            this.btnPreviousMenu.Text = "Previous Menu";
            this.btnPreviousMenu.UseVisualStyleBackColor = true;
            this.btnPreviousMenu.Click += new System.EventHandler(this.btnPreviousMenu_Click);
            // 
            // btnAscend
            // 
            this.btnAscend.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAscend.Location = new System.Drawing.Point(864, 949);
            this.btnAscend.Margin = new System.Windows.Forms.Padding(4);
            this.btnAscend.Name = "btnAscend";
            this.btnAscend.Size = new System.Drawing.Size(134, 28);
            this.btnAscend.TabIndex = 15;
            this.btnAscend.Text = "Ascend";
            this.btnAscend.UseVisualStyleBackColor = true;
            this.btnAscend.Click += new System.EventHandler(this.btnAscend_Click);
            // 
            // btnDescend
            // 
            this.btnDescend.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDescend.Location = new System.Drawing.Point(998, 949);
            this.btnDescend.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescend.Name = "btnDescend";
            this.btnDescend.Size = new System.Drawing.Size(134, 28);
            this.btnDescend.TabIndex = 16;
            this.btnDescend.Text = "Descend";
            this.btnDescend.UseVisualStyleBackColor = true;
            this.btnDescend.Click += new System.EventHandler(this.btnDescend_Click);
            // 
            // AnalyticData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnDescend);
            this.Controls.Add(this.btnAscend);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.btnByItem);
            this.Controls.Add(this.btnByType);
            this.Controls.Add(this.btnByBrand);
            this.Controls.Add(this.viewInventoryData);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnalyticData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Analytic Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnalyticData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewInventoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView viewInventoryData;
        private System.Windows.Forms.Button btnByBrand;
        private System.Windows.Forms.Button btnByType;
        private System.Windows.Forms.Button btnByItem;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.Button btnAscend;
        private System.Windows.Forms.Button btnDescend;
    }
}