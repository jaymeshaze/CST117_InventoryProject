namespace InventoryManager
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            this.CustomerSearchBox = new System.Windows.Forms.TextBox();
            this.CustomerSearchBoxButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerSearchAllButton = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewGameList = new System.Windows.Forms.DataGridView();
            this.gameName_Lbl = new System.Windows.Forms.Label();
            this.gamePrice_Lbl = new System.Windows.Forms.Label();
            this.gamePlatform_Lbl = new System.Windows.Forms.Label();
            this.gameDesc_Lbl = new System.Windows.Forms.Label();
            this.GamePub_Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGameList)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearchBox
            // 
            this.CustomerSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchBox.Location = new System.Drawing.Point(536, 270);
            this.CustomerSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerSearchBox.Name = "CustomerSearchBox";
            this.CustomerSearchBox.Size = new System.Drawing.Size(311, 37);
            this.CustomerSearchBox.TabIndex = 1;
            this.CustomerSearchBox.Text = "Search T2 Games";
            this.CustomerSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerSearchBoxButton
            // 
            this.CustomerSearchBoxButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.BackgroundImage = global::InventoryManager.Properties.Resources.SEARCH_ICON_75X47_002;
            this.CustomerSearchBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomerSearchBoxButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerSearchBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBoxButton.FlatAppearance.BorderSize = 0;
            this.CustomerSearchBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerSearchBoxButton.Location = new System.Drawing.Point(848, 267);
            this.CustomerSearchBoxButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerSearchBoxButton.Name = "CustomerSearchBoxButton";
            this.CustomerSearchBoxButton.Size = new System.Drawing.Size(41, 37);
            this.CustomerSearchBoxButton.TabIndex = 3;
            this.CustomerSearchBoxButton.TabStop = false;
            this.CustomerSearchBoxButton.UseVisualStyleBackColor = false;
            this.CustomerSearchBoxButton.Click += new System.EventHandler(this.CUST_SRCH_BOX_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.pictureBox1.Location = new System.Drawing.Point(531, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerSearchAllButton
            // 
            this.CustomerSearchAllButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchAllButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerSearchAllButton.Location = new System.Drawing.Point(439, 231);
            this.CustomerSearchAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerSearchAllButton.Name = "CustomerSearchAllButton";
            this.CustomerSearchAllButton.Size = new System.Drawing.Size(353, 107);
            this.CustomerSearchAllButton.TabIndex = 4;
            this.CustomerSearchAllButton.Text = "SEARCH ALL GAMES";
            this.CustomerSearchAllButton.UseVisualStyleBackColor = false;
            this.CustomerSearchAllButton.Click += new System.EventHandler(this.CUST_SRCH_ALL_Click);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.or_label.Location = new System.Drawing.Point(594, 132);
            this.or_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(42, 40);
            this.or_label.TabIndex = 5;
            this.or_label.Text = "or";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLogout.Location = new System.Drawing.Point(1249, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(96, 36);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CustomerSearchAllButton);
            this.panel1.Controls.Add(this.or_label);
            this.panel1.Location = new System.Drawing.Point(67, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 392);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GamePub_Lbl);
            this.panel2.Controls.Add(this.gameDesc_Lbl);
            this.panel2.Controls.Add(this.gamePlatform_Lbl);
            this.panel2.Controls.Add(this.gamePrice_Lbl);
            this.panel2.Controls.Add(this.gameName_Lbl);
            this.panel2.Controls.Add(this.viewGameList);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(67, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 392);
            this.panel2.TabIndex = 11;
            this.panel2.UseWaitCursor = true;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(907, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(759, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 315);
            this.textBox2.TabIndex = 7;
            this.textBox2.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(439, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 107);
            this.button1.TabIndex = 4;
            this.button1.Text = "SEARCH ALL GAMES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(594, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "or";
            this.label1.UseWaitCursor = true;
            // 
            // viewGameList
            // 
            this.viewGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGameList.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewGameList.Location = new System.Drawing.Point(219, 14);
            this.viewGameList.Name = "viewGameList";
            this.viewGameList.Size = new System.Drawing.Size(510, 347);
            this.viewGameList.TabIndex = 12;
            this.viewGameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGameList_CellContentClick);
            // 
            // gameName_Lbl
            // 
            this.gameName_Lbl.AutoSize = true;
            this.gameName_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName_Lbl.Location = new System.Drawing.Point(775, 26);
            this.gameName_Lbl.Name = "gameName_Lbl";
            this.gameName_Lbl.Size = new System.Drawing.Size(86, 31);
            this.gameName_Lbl.TabIndex = 13;
            this.gameName_Lbl.Text = "Name";
            // 
            // gamePrice_Lbl
            // 
            this.gamePrice_Lbl.AutoSize = true;
            this.gamePrice_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePrice_Lbl.Location = new System.Drawing.Point(1073, 26);
            this.gamePrice_Lbl.Name = "gamePrice_Lbl";
            this.gamePrice_Lbl.Size = new System.Drawing.Size(53, 24);
            this.gamePrice_Lbl.TabIndex = 14;
            this.gamePrice_Lbl.Text = "Price";
            // 
            // gamePlatform_Lbl
            // 
            this.gamePlatform_Lbl.AutoSize = true;
            this.gamePlatform_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePlatform_Lbl.Location = new System.Drawing.Point(1032, 60);
            this.gamePlatform_Lbl.Name = "gamePlatform_Lbl";
            this.gamePlatform_Lbl.Size = new System.Drawing.Size(94, 26);
            this.gamePlatform_Lbl.TabIndex = 15;
            this.gamePlatform_Lbl.Text = "Platform";
            // 
            // gameDesc_Lbl
            // 
            this.gameDesc_Lbl.AutoSize = true;
            this.gameDesc_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesc_Lbl.Location = new System.Drawing.Point(778, 132);
            this.gameDesc_Lbl.Name = "gameDesc_Lbl";
            this.gameDesc_Lbl.Size = new System.Drawing.Size(83, 18);
            this.gameDesc_Lbl.TabIndex = 16;
            this.gameDesc_Lbl.Text = "Description";
            // 
            // GamePub_Lbl
            // 
            this.GamePub_Lbl.AutoSize = true;
            this.GamePub_Lbl.Location = new System.Drawing.Point(778, 73);
            this.GamePub_Lbl.Name = "GamePub_Lbl";
            this.GamePub_Lbl.Size = new System.Drawing.Size(50, 13);
            this.GamePub_Lbl.TabIndex = 17;
            this.GamePub_Lbl.Text = "Publisher";
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.CustomerSearchBoxButton);
            this.Controls.Add(this.CustomerSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGameList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CustomerSearchBox;
        private System.Windows.Forms.Button CustomerSearchBoxButton;
        private System.Windows.Forms.Button CustomerSearchAllButton;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView viewGameList;
        private System.Windows.Forms.Label GamePub_Lbl;
        private System.Windows.Forms.Label gameDesc_Lbl;
        private System.Windows.Forms.Label gamePlatform_Lbl;
        private System.Windows.Forms.Label gamePrice_Lbl;
        private System.Windows.Forms.Label gameName_Lbl;
    }
}