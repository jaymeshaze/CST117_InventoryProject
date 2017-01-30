namespace InventoryManager
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPopular = new System.Windows.Forms.Button();
            this.btnHighSellers = new System.Windows.Forms.Button();
            this.btnLowSellers = new System.Windows.Forms.Button();
            this.grpbxNavButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbxNavButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(531, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(1250, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPopular
            // 
            this.btnPopular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopular.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPopular.Location = new System.Drawing.Point(16, 22);
            this.btnPopular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(337, 59);
            this.btnPopular.TabIndex = 10;
            this.btnPopular.Text = "POPULAR ITEMS";
            this.btnPopular.UseVisualStyleBackColor = false;
            this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
            // 
            // btnHighSellers
            // 
            this.btnHighSellers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHighSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighSellers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnHighSellers.Location = new System.Drawing.Point(16, 92);
            this.btnHighSellers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHighSellers.Name = "btnHighSellers";
            this.btnHighSellers.Size = new System.Drawing.Size(337, 59);
            this.btnHighSellers.TabIndex = 11;
            this.btnHighSellers.Text = "HIGHEST SELLERS";
            this.btnHighSellers.UseVisualStyleBackColor = false;
            this.btnHighSellers.Click += new System.EventHandler(this.btnHighSellers_Click);
            // 
            // btnLowSellers
            // 
            this.btnLowSellers.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLowSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowSellers.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLowSellers.Location = new System.Drawing.Point(16, 162);
            this.btnLowSellers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLowSellers.Name = "btnLowSellers";
            this.btnLowSellers.Size = new System.Drawing.Size(337, 59);
            this.btnLowSellers.TabIndex = 12;
            this.btnLowSellers.Text = "Lowest Sellers";
            this.btnLowSellers.UseVisualStyleBackColor = false;
            this.btnLowSellers.Click += new System.EventHandler(this.btnLowSellers_Click);
            // 
            // grpbxNavButtons
            // 
            this.grpbxNavButtons.BackColor = System.Drawing.Color.DimGray;
            this.grpbxNavButtons.Controls.Add(this.btnPopular);
            this.grpbxNavButtons.Controls.Add(this.btnHighSellers);
            this.grpbxNavButtons.Controls.Add(this.btnLowSellers);
            this.grpbxNavButtons.Location = new System.Drawing.Point(536, 321);
            this.grpbxNavButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxNavButtons.Name = "grpbxNavButtons";
            this.grpbxNavButtons.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxNavButtons.Size = new System.Drawing.Size(368, 239);
            this.grpbxNavButtons.TabIndex = 13;
            this.grpbxNavButtons.TabStop = false;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.grpbxNavButtons);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Analytics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Analytics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbxNavButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.Button btnHighSellers;
        private System.Windows.Forms.Button btnLowSellers;
        private System.Windows.Forms.GroupBox grpbxNavButtons;
    }
}