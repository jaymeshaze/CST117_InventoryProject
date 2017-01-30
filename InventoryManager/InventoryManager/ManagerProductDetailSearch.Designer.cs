namespace InventoryManager
{
    partial class ProductSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSearch));
            this.ProductSearchBox = new System.Windows.Forms.TextBox();
            this.ProductSearchBoxButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProductSearchAllButton = new System.Windows.Forms.Button();
            this.or_label = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductSearchBox
            // 
            this.ProductSearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ProductSearchBox.Location = new System.Drawing.Point(536, 270);
            this.ProductSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchBox.Name = "ProductSearchBox";
            this.ProductSearchBox.Size = new System.Drawing.Size(311, 37);
            this.ProductSearchBox.TabIndex = 1;
            this.ProductSearchBox.Text = "Search T2 Products";
            this.ProductSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProductSearchBox.TextChanged += new System.EventHandler(this.ProductSearchBox_TextChanged);
            // 
            // ProductSearchBoxButton
            // 
            this.ProductSearchBoxButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductSearchBoxButton.BackgroundImage = global::InventoryManager.Properties.Resources.SEARCH_ICON_75X47_002;
            this.ProductSearchBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductSearchBoxButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductSearchBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ProductSearchBoxButton.FlatAppearance.BorderSize = 0;
            this.ProductSearchBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductSearchBoxButton.Location = new System.Drawing.Point(848, 267);
            this.ProductSearchBoxButton.Margin = new System.Windows.Forms.Padding(0);
            this.ProductSearchBoxButton.Name = "ProductSearchBoxButton";
            this.ProductSearchBoxButton.Size = new System.Drawing.Size(41, 37);
            this.ProductSearchBoxButton.TabIndex = 3;
            this.ProductSearchBoxButton.TabStop = false;
            this.ProductSearchBoxButton.UseVisualStyleBackColor = false;
            this.ProductSearchBoxButton.Click += new System.EventHandler(this.ProductSearchBoxButton_Click);
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
            // ProductSearchAllButton
            // 
            this.ProductSearchAllButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ProductSearchAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchAllButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProductSearchAllButton.Location = new System.Drawing.Point(537, 518);
            this.ProductSearchAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProductSearchAllButton.Name = "ProductSearchAllButton";
            this.ProductSearchAllButton.Size = new System.Drawing.Size(353, 107);
            this.ProductSearchAllButton.TabIndex = 4;
            this.ProductSearchAllButton.Text = "SEARCH ALL PRODUCTS";
            this.ProductSearchAllButton.UseVisualStyleBackColor = false;
            this.ProductSearchAllButton.Click += new System.EventHandler(this.ProductSearchAllButton_Click);
            // 
            // or_label
            // 
            this.or_label.AutoSize = true;
            this.or_label.Font = new System.Drawing.Font("Arial Narrow", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.or_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.or_label.Location = new System.Drawing.Point(694, 392);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1146, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.returnClick);
            // 
            // ProductSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.or_label);
            this.Controls.Add(this.ProductSearchAllButton);
            this.Controls.Add(this.ProductSearchBoxButton);
            this.Controls.Add(this.ProductSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Product Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ProductSearchBox;
        private System.Windows.Forms.Button ProductSearchBoxButton;
        private System.Windows.Forms.Button ProductSearchAllButton;
        private System.Windows.Forms.Label or_label;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
    }
}