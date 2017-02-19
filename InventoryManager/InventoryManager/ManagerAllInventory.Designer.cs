namespace InventoryManager
{
    partial class AllInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllInventory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewAllInventory = new System.Windows.Forms.DataGridView();
            this.pbx_Game = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_salePrice = new System.Windows.Forms.Label();
            this.rtxtbx_Details = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Game)).BeginInit();
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
            // btnPreviousMenu
            // 
            this.btnPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreviousMenu.Location = new System.Drawing.Point(1627, 108);
            this.btnPreviousMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousMenu.Name = "btnPreviousMenu";
            this.btnPreviousMenu.Size = new System.Drawing.Size(173, 28);
            this.btnPreviousMenu.TabIndex = 14;
            this.btnPreviousMenu.Text = "Previous Menu";
            this.btnPreviousMenu.UseVisualStyleBackColor = true;
            this.btnPreviousMenu.Click += new System.EventHandler(this.btnPreviousMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1672, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 15;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.returnClick);
            // 
            // viewAllInventory
            // 
            this.viewAllInventory.AllowUserToAddRows = false;
            this.viewAllInventory.AllowUserToDeleteRows = false;
            this.viewAllInventory.AllowUserToResizeColumns = false;
            this.viewAllInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewAllInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewAllInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewAllInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAllInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewAllInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.viewAllInventory.EnableHeadersVisualStyles = false;
            this.viewAllInventory.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewAllInventory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewAllInventory.Location = new System.Drawing.Point(453, 272);
            this.viewAllInventory.MultiSelect = false;
            this.viewAllInventory.Name = "viewAllInventory";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewAllInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.viewAllInventory.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewAllInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewAllInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewAllInventory.ShowEditingIcon = false;
            this.viewAllInventory.Size = new System.Drawing.Size(1000, 400);
            this.viewAllInventory.TabIndex = 15;
            this.viewAllInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAllInventory_CellContentClick);
            // 
            // pbx_Game
            // 
            this.pbx_Game.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbx_Game.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_Game.InitialImage")));
            this.pbx_Game.Location = new System.Drawing.Point(347, 692);
            this.pbx_Game.Name = "pbx_Game";
            this.pbx_Game.Size = new System.Drawing.Size(212, 230);
            this.pbx_Game.TabIndex = 16;
            this.pbx_Game.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Neuropol", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Title.Location = new System.Drawing.Point(931, 690);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(0, 34);
            this.lbl_Title.TabIndex = 17;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Type.Location = new System.Drawing.Point(932, 748);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(0, 26);
            this.lbl_Type.TabIndex = 18;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Brand.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Brand.Location = new System.Drawing.Point(932, 793);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(0, 26);
            this.lbl_Brand.TabIndex = 19;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Price.Location = new System.Drawing.Point(933, 840);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(0, 26);
            this.lbl_Price.TabIndex = 20;
            // 
            // lbl_salePrice
            // 
            this.lbl_salePrice.AutoSize = true;
            this.lbl_salePrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salePrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_salePrice.Location = new System.Drawing.Point(934, 886);
            this.lbl_salePrice.Name = "lbl_salePrice";
            this.lbl_salePrice.Size = new System.Drawing.Size(0, 26);
            this.lbl_salePrice.TabIndex = 21;
            // 
            // rtxtbx_Details
            // 
            this.rtxtbx_Details.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rtxtbx_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbx_Details.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rtxtbx_Details.Location = new System.Drawing.Point(588, 692);
            this.rtxtbx_Details.Name = "rtxtbx_Details";
            this.rtxtbx_Details.ReadOnly = true;
            this.rtxtbx_Details.Size = new System.Drawing.Size(297, 230);
            this.rtxtbx_Details.TabIndex = 22;
            this.rtxtbx_Details.Text = "";
            // 
            // AllInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.rtxtbx_Details);
            this.Controls.Add(this.lbl_salePrice);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pbx_Game);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.viewAllInventory);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Complete Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Game)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView viewAllInventory;
        private System.Windows.Forms.PictureBox pbx_Game;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_salePrice;
        private System.Windows.Forms.RichTextBox rtxtbx_Details;
    }
}