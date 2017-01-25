namespace TEAM_TWO_GAMES_GUI_001
{
    partial class CUSTOMER_SEARCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUSTOMER_SEARCH));
            this.CUST_SRCH_BOX = new System.Windows.Forms.TextBox();
            this.SRCH_BOX_LABEL = new System.Windows.Forms.Label();
            this.CUST_SRCH_BOX_BUTTON = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CUST_SRCH_ALL_BUTTON = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CUST_SRCH_BOX
            // 
            this.CUST_SRCH_BOX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CUST_SRCH_BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CUST_SRCH_BOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUST_SRCH_BOX.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CUST_SRCH_BOX.Location = new System.Drawing.Point(714, 329);
            this.CUST_SRCH_BOX.Name = "CUST_SRCH_BOX";
            this.CUST_SRCH_BOX.Size = new System.Drawing.Size(414, 45);
            this.CUST_SRCH_BOX.TabIndex = 1;
            this.CUST_SRCH_BOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SRCH_BOX_LABEL
            // 
            this.SRCH_BOX_LABEL.AutoSize = true;
            this.SRCH_BOX_LABEL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SRCH_BOX_LABEL.Font = new System.Drawing.Font("Neuropol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRCH_BOX_LABEL.ForeColor = System.Drawing.Color.DarkGray;
            this.SRCH_BOX_LABEL.Location = new System.Drawing.Point(726, 337);
            this.SRCH_BOX_LABEL.Name = "SRCH_BOX_LABEL";
            this.SRCH_BOX_LABEL.Size = new System.Drawing.Size(390, 30);
            this.SRCH_BOX_LABEL.TabIndex = 2;
            this.SRCH_BOX_LABEL.Text = "Search Team 2 Games";
            // 
            // CUST_SRCH_BOX_BUTTON
            // 
            this.CUST_SRCH_BOX_BUTTON.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CUST_SRCH_BOX_BUTTON.BackgroundImage = global::TEAM_TWO_GAMES_GUI_001.Properties.Resources.SEARCH_ICON_75X47_002;
            this.CUST_SRCH_BOX_BUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CUST_SRCH_BOX_BUTTON.Cursor = System.Windows.Forms.Cursors.Default;
            this.CUST_SRCH_BOX_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CUST_SRCH_BOX_BUTTON.FlatAppearance.BorderSize = 0;
            this.CUST_SRCH_BOX_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CUST_SRCH_BOX_BUTTON.Location = new System.Drawing.Point(1130, 329);
            this.CUST_SRCH_BOX_BUTTON.Margin = new System.Windows.Forms.Padding(0);
            this.CUST_SRCH_BOX_BUTTON.Name = "CUST_SRCH_BOX_BUTTON";
            this.CUST_SRCH_BOX_BUTTON.Size = new System.Drawing.Size(55, 45);
            this.CUST_SRCH_BOX_BUTTON.TabIndex = 3;
            this.CUST_SRCH_BOX_BUTTON.TabStop = false;
            this.CUST_SRCH_BOX_BUTTON.UseVisualStyleBackColor = false;
            this.CUST_SRCH_BOX_BUTTON.Click += new System.EventHandler(this.CUST_SRCH_BOX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TEAM_TWO_GAMES_GUI_001.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(708, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CUST_SRCH_ALL_BUTTON
            // 
            this.CUST_SRCH_ALL_BUTTON.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CUST_SRCH_ALL_BUTTON.Font = new System.Drawing.Font("Neuropol", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUST_SRCH_ALL_BUTTON.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CUST_SRCH_ALL_BUTTON.Location = new System.Drawing.Point(716, 637);
            this.CUST_SRCH_ALL_BUTTON.Name = "CUST_SRCH_ALL_BUTTON";
            this.CUST_SRCH_ALL_BUTTON.Size = new System.Drawing.Size(471, 132);
            this.CUST_SRCH_ALL_BUTTON.TabIndex = 4;
            this.CUST_SRCH_ALL_BUTTON.Text = "SEARCH ALL GAMES";
            this.CUST_SRCH_ALL_BUTTON.UseVisualStyleBackColor = false;
            this.CUST_SRCH_ALL_BUTTON.Click += new System.EventHandler(this.CUST_SRCH_ALL_Click);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.or_label.Location = new System.Drawing.Point(926, 482);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(52, 49);
            this.or_label.TabIndex = 5;
            this.or_label.Text = "or";
            this.or_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // CUSTOMER_SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.CUST_SRCH_ALL_BUTTON);
            this.Controls.Add(this.CUST_SRCH_BOX_BUTTON);
            this.Controls.Add(this.SRCH_BOX_LABEL);
            this.Controls.Add(this.CUST_SRCH_BOX);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CUSTOMER_SEARCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CUSTOMER_SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CUST_SRCH_BOX;
        private System.Windows.Forms.Label SRCH_BOX_LABEL;
        private System.Windows.Forms.Button CUST_SRCH_BOX_BUTTON;
        private System.Windows.Forms.Button CUST_SRCH_ALL_BUTTON;
        private System.Windows.Forms.Label or_label;
    }
}