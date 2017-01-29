namespace InventoryManager
{
    partial class StockControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUploadNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddNew.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddNew.Location = new System.Drawing.Point(21, 27);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(449, 73);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "ADD NEW ITEM";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUploadNew
            // 
            this.btnUploadNew.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUploadNew.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUploadNew.Location = new System.Drawing.Point(21, 113);
            this.btnUploadNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUploadNew.Name = "btnUploadNew";
            this.btnUploadNew.Size = new System.Drawing.Size(449, 73);
            this.btnUploadNew.TabIndex = 11;
            this.btnUploadNew.Text = "UPLOAD NEW STOCK LIST";
            this.btnUploadNew.UseVisualStyleBackColor = false;
            this.btnUploadNew.Click += new System.EventHandler(this.btnUploadNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRemove.Font = new System.Drawing.Font("Neuropol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemove.Location = new System.Drawing.Point(21, 199);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(449, 73);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "REMOVE STOCK";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpbxNavButtons
            // 
            this.grpbxNavButtons.BackColor = System.Drawing.Color.DimGray;
            this.grpbxNavButtons.Controls.Add(this.btnAddNew);
            this.grpbxNavButtons.Controls.Add(this.btnUploadNew);
            this.grpbxNavButtons.Controls.Add(this.btnRemove);
            this.grpbxNavButtons.Location = new System.Drawing.Point(714, 395);
            this.grpbxNavButtons.Name = "grpbxNavButtons";
            this.grpbxNavButtons.Size = new System.Drawing.Size(490, 294);
            this.grpbxNavButtons.TabIndex = 13;
            this.grpbxNavButtons.TabStop = false;
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.grpbxNavButtons);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Stock Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxNavButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUploadNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpbxNavButtons;
    }
}