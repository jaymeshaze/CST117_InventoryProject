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
            this.CustomerSearchBox = new System.Windows.Forms.TextBox();
            this.SearchBoxLabel = new System.Windows.Forms.Label();
            this.CustomerSearchBoxButton = new System.Windows.Forms.Button();
            this.CustomerSearchAllButton = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerSearchBox
            // 
            this.CustomerSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchBox.Location = new System.Drawing.Point(465, 310);
            this.CustomerSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.CustomerSearchBox.Name = "CustomerSearchBox";
            this.CustomerSearchBox.Size = new System.Drawing.Size(311, 37);
            this.CustomerSearchBox.TabIndex = 1;
            this.CustomerSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchBoxLabel
            // 
            this.SearchBoxLabel.AutoSize = true;
            this.SearchBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBoxLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.SearchBoxLabel.Location = new System.Drawing.Point(475, 314);
            this.SearchBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchBoxLabel.Name = "SearchBoxLabel";
            this.SearchBoxLabel.Size = new System.Drawing.Size(260, 29);
            this.SearchBoxLabel.TabIndex = 2;
            this.SearchBoxLabel.Text = "Search Team 2 Games";
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
            this.CustomerSearchBoxButton.Location = new System.Drawing.Point(780, 310);
            this.CustomerSearchBoxButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomerSearchBoxButton.Name = "CustomerSearchBoxButton";
            this.CustomerSearchBoxButton.Size = new System.Drawing.Size(41, 37);
            this.CustomerSearchBoxButton.TabIndex = 3;
            this.CustomerSearchBoxButton.TabStop = false;
            this.CustomerSearchBoxButton.UseVisualStyleBackColor = false;
            this.CustomerSearchBoxButton.Click += new System.EventHandler(this.CUST_SRCH_BOX_Click);
            // 
            // CustomerSearchAllButton
            // 
            this.CustomerSearchAllButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CustomerSearchAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchAllButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerSearchAllButton.Location = new System.Drawing.Point(600, 440);
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
            this.or_label.Location = new System.Drawing.Point(693, 381);
            this.or_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.or_label.Name = "or_label";
            this.or_label.Size = new System.Drawing.Size(42, 40);
            this.or_label.TabIndex = 5;
            this.or_label.Text = "or";
            this.or_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(773, 205);
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
            this.LoginLogo.Location = new System.Drawing.Point(465, 11);
            this.LoginLogo.Margin = new System.Windows.Forms.Padding(2);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(488, 295);
            this.LoginLogo.TabIndex = 7;
            this.LoginLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EmployeeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.CustomerSearchAllButton);
            this.Controls.Add(this.CustomerSearchBoxButton);
            this.Controls.Add(this.SearchBoxLabel);
            this.Controls.Add(this.CustomerSearchBox);
            this.Controls.Add(this.LoginLogo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Customer Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CUSTOMER_SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CustomerSearchBox;
        private System.Windows.Forms.Label SearchBoxLabel;
        private System.Windows.Forms.Button CustomerSearchBoxButton;
        private System.Windows.Forms.Button CustomerSearchAllButton;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Button button1;
    }
}