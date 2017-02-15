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
            this.gameName_txtbox = new System.Windows.Forms.TextBox();
            this.viewGameList = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gamePlatform_txtbox = new System.Windows.Forms.TextBox();
            this.gamePub_txtbox = new System.Windows.Forms.TextBox();
            this.gameDesc_txtbox = new System.Windows.Forms.TextBox();
            this.masterGameView = new System.Windows.Forms.DataGridView();
            this.gamePrice_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewGameList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGameView)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(76, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 392);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gamePrice_txtbox);
            this.panel2.Controls.Add(this.gameDesc_txtbox);
            this.panel2.Controls.Add(this.gamePub_txtbox);
            this.panel2.Controls.Add(this.gamePlatform_txtbox);
            this.panel2.Controls.Add(this.gameName_txtbox);
            this.panel2.Controls.Add(this.viewGameList);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.masterGameView);
            this.panel2.Location = new System.Drawing.Point(46, 337);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 392);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // gameName_txtbox
            // 
            this.gameName_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.gameName_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameName_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameName_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName_txtbox.Location = new System.Drawing.Point(781, 26);
            this.gameName_txtbox.Multiline = true;
            this.gameName_txtbox.Name = "gameName_txtbox";
            this.gameName_txtbox.ReadOnly = true;
            this.gameName_txtbox.Size = new System.Drawing.Size(255, 56);
            this.gameName_txtbox.TabIndex = 18;
            // 
            // viewGameList
            // 
            this.viewGameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.viewGameList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.viewGameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewGameList.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewGameList.Location = new System.Drawing.Point(263, 14);
            this.viewGameList.MultiSelect = false;
            this.viewGameList.Name = "viewGameList";
            this.viewGameList.ReadOnly = true;
            this.viewGameList.Size = new System.Drawing.Size(442, 347);
            this.viewGameList.TabIndex = 12;
            this.viewGameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewGameList_CellContentClick);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(907, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 39);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back to Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(759, 14);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 315);
            this.textBox2.TabIndex = 7;
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
            // 
            // gamePlatform_txtbox
            // 
            this.gamePlatform_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.gamePlatform_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamePlatform_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gamePlatform_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePlatform_txtbox.Location = new System.Drawing.Point(1093, 65);
            this.gamePlatform_txtbox.Name = "gamePlatform_txtbox";
            this.gamePlatform_txtbox.ReadOnly = true;
            this.gamePlatform_txtbox.Size = new System.Drawing.Size(100, 17);
            this.gamePlatform_txtbox.TabIndex = 19;
            // 
            // gamePub_txtbox
            // 
            this.gamePub_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.gamePub_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamePub_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gamePub_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePub_txtbox.Location = new System.Drawing.Point(781, 88);
            this.gamePub_txtbox.Name = "gamePub_txtbox";
            this.gamePub_txtbox.ReadOnly = true;
            this.gamePub_txtbox.Size = new System.Drawing.Size(255, 17);
            this.gamePub_txtbox.TabIndex = 20;
            // 
            // gameDesc_txtbox
            // 
            this.gameDesc_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.gameDesc_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameDesc_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameDesc_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDesc_txtbox.Location = new System.Drawing.Point(781, 132);
            this.gameDesc_txtbox.Multiline = true;
            this.gameDesc_txtbox.Name = "gameDesc_txtbox";
            this.gameDesc_txtbox.ReadOnly = true;
            this.gameDesc_txtbox.Size = new System.Drawing.Size(412, 180);
            this.gameDesc_txtbox.TabIndex = 21;
            // 
            // masterGameView
            // 
            this.masterGameView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.masterGameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.masterGameView.Cursor = System.Windows.Forms.Cursors.Default;
            this.masterGameView.Location = new System.Drawing.Point(126, 14);
            this.masterGameView.MultiSelect = false;
            this.masterGameView.Name = "masterGameView";
            this.masterGameView.ReadOnly = true;
            this.masterGameView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.masterGameView.Size = new System.Drawing.Size(103, 51);
            this.masterGameView.TabIndex = 22;
            this.masterGameView.Visible = false;
            // 
            // gamePrice_txtbox
            // 
            this.gamePrice_txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.gamePrice_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gamePrice_txtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gamePrice_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePrice_txtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gamePrice_txtbox.Location = new System.Drawing.Point(1093, 26);
            this.gamePrice_txtbox.Name = "gamePrice_txtbox";
            this.gamePrice_txtbox.ReadOnly = true;
            this.gamePrice_txtbox.Size = new System.Drawing.Size(100, 19);
            this.gamePrice_txtbox.TabIndex = 23;
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
            ((System.ComponentModel.ISupportInitialize)(this.masterGameView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView viewGameList;
        private System.Windows.Forms.TextBox gameName_txtbox;
        private System.Windows.Forms.TextBox gamePlatform_txtbox;
        private System.Windows.Forms.TextBox gameDesc_txtbox;
        private System.Windows.Forms.TextBox gamePub_txtbox;
        private System.Windows.Forms.DataGridView masterGameView;
        private System.Windows.Forms.TextBox gamePrice_txtbox;
    }
}