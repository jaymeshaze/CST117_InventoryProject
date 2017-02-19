namespace InventoryManager
{
    partial class ProductDetailsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDetailsManager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.viewProductList = new System.Windows.Forms.DataGridView();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.txtbx_Title = new System.Windows.Forms.TextBox();
            this.rtxtbx_Details = new System.Windows.Forms.RichTextBox();
            this.txtbx_imgPath = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbx_UpdateProduct = new System.Windows.Forms.GroupBox();
            this.txtbx_Type = new System.Windows.Forms.TextBox();
            this.txtbx_Brand = new System.Windows.Forms.TextBox();
            this.txtbx_salePrice = new System.Windows.Forms.TextBox();
            this.txtbx_Price = new System.Windows.Forms.TextBox();
            this.btnImgBrowse = new System.Windows.Forms.Button();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.lbl_Item_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductList)).BeginInit();
            this.grpbx_UpdateProduct.SuspendLayout();
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
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(1667, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 28);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // viewProductList
            // 
            this.viewProductList.AllowUserToAddRows = false;
            this.viewProductList.AllowUserToDeleteRows = false;
            this.viewProductList.AllowUserToResizeColumns = false;
            this.viewProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProductList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.viewProductList.EnableHeadersVisualStyles = false;
            this.viewProductList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewProductList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewProductList.Location = new System.Drawing.Point(690, 386);
            this.viewProductList.MultiSelect = false;
            this.viewProductList.Name = "viewProductList";
            this.viewProductList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewProductList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewProductList.ShowEditingIcon = false;
            this.viewProductList.Size = new System.Drawing.Size(1000, 300);
            this.viewProductList.TabIndex = 15;
            this.viewProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewProductList_CellContentClick);
            // 
            // btnPreviousMenu
            // 
            this.btnPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // txtbx_Title
            // 
            this.txtbx_Title.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Title.Location = new System.Drawing.Point(20, 106);
            this.txtbx_Title.Name = "txtbx_Title";
            this.txtbx_Title.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Title.TabIndex = 34;
            this.txtbx_Title.Text = "Title";
            // 
            // rtxtbx_Details
            // 
            this.rtxtbx_Details.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbx_Details.Location = new System.Drawing.Point(20, 149);
            this.rtxtbx_Details.Name = "rtxtbx_Details";
            this.rtxtbx_Details.Size = new System.Drawing.Size(432, 122);
            this.rtxtbx_Details.TabIndex = 23;
            this.rtxtbx_Details.Text = "Details";
            // 
            // txtbx_imgPath
            // 
            this.txtbx_imgPath.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_imgPath.Location = new System.Drawing.Point(20, 288);
            this.txtbx_imgPath.Name = "txtbx_imgPath";
            this.txtbx_imgPath.Size = new System.Drawing.Size(296, 27);
            this.txtbx_imgPath.TabIndex = 29;
            this.txtbx_imgPath.Text = "Upload New Image";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(146, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 28);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpbx_UpdateProduct
            // 
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_Title);
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_Type);
            this.grpbx_UpdateProduct.Controls.Add(this.btnUpdate);
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_Brand);
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_salePrice);
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_Price);
            this.grpbx_UpdateProduct.Controls.Add(this.btnImgBrowse);
            this.grpbx_UpdateProduct.Controls.Add(this.lbl_ItemID);
            this.grpbx_UpdateProduct.Controls.Add(this.rtxtbx_Details);
            this.grpbx_UpdateProduct.Controls.Add(this.lbl_Item_ID);
            this.grpbx_UpdateProduct.Controls.Add(this.txtbx_imgPath);
            this.grpbx_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_UpdateProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_UpdateProduct.Location = new System.Drawing.Point(202, 255);
            this.grpbx_UpdateProduct.Name = "grpbx_UpdateProduct";
            this.grpbx_UpdateProduct.Size = new System.Drawing.Size(470, 579);
            this.grpbx_UpdateProduct.TabIndex = 33;
            this.grpbx_UpdateProduct.TabStop = false;
            this.grpbx_UpdateProduct.Text = "Update Item";
            // 
            // txtbx_Type
            // 
            this.txtbx_Type.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Type.Location = new System.Drawing.Point(19, 465);
            this.txtbx_Type.Name = "txtbx_Type";
            this.txtbx_Type.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Type.TabIndex = 41;
            this.txtbx_Type.Text = "Type";
            // 
            // txtbx_Brand
            // 
            this.txtbx_Brand.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Brand.Location = new System.Drawing.Point(19, 420);
            this.txtbx_Brand.Name = "txtbx_Brand";
            this.txtbx_Brand.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Brand.TabIndex = 40;
            this.txtbx_Brand.Text = "Brand";
            // 
            // txtbx_salePrice
            // 
            this.txtbx_salePrice.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_salePrice.Location = new System.Drawing.Point(19, 376);
            this.txtbx_salePrice.Name = "txtbx_salePrice";
            this.txtbx_salePrice.Size = new System.Drawing.Size(432, 27);
            this.txtbx_salePrice.TabIndex = 39;
            this.txtbx_salePrice.Text = "Sale Price";
            // 
            // txtbx_Price
            // 
            this.txtbx_Price.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Price.Location = new System.Drawing.Point(19, 332);
            this.txtbx_Price.Name = "txtbx_Price";
            this.txtbx_Price.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Price.TabIndex = 38;
            this.txtbx_Price.Text = "Price";
            // 
            // btnImgBrowse
            // 
            this.btnImgBrowse.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgBrowse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnImgBrowse.Location = new System.Drawing.Point(323, 288);
            this.btnImgBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnImgBrowse.Name = "btnImgBrowse";
            this.btnImgBrowse.Size = new System.Drawing.Size(129, 28);
            this.btnImgBrowse.TabIndex = 37;
            this.btnImgBrowse.Text = "Browse";
            this.btnImgBrowse.UseVisualStyleBackColor = true;
            this.btnImgBrowse.Click += new System.EventHandler(this.btnImgBrowse_Click);
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ItemID.Location = new System.Drawing.Point(15, 71);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(0, 25);
            this.lbl_ItemID.TabIndex = 36;
            // 
            // lbl_Item_ID
            // 
            this.lbl_Item_ID.AutoSize = true;
            this.lbl_Item_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Item_ID.Location = new System.Drawing.Point(15, 39);
            this.lbl_Item_ID.Name = "lbl_Item_ID";
            this.lbl_Item_ID.Size = new System.Drawing.Size(79, 25);
            this.lbl_Item_ID.TabIndex = 34;
            this.lbl_Item_ID.Text = "Item ID:";
            // 
            // ProductDetailsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.viewProductList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbx_UpdateProduct);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductDetailsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games User Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductList)).EndInit();
            this.grpbx_UpdateProduct.ResumeLayout(false);
            this.grpbx_UpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView viewProductList;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.TextBox txtbx_Title;
        private System.Windows.Forms.RichTextBox rtxtbx_Details;
        private System.Windows.Forms.TextBox txtbx_imgPath;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpbx_UpdateProduct;
        private System.Windows.Forms.Label lbl_Item_ID;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.Button btnImgBrowse;
        private System.Windows.Forms.TextBox txtbx_salePrice;
        private System.Windows.Forms.TextBox txtbx_Price;
        private System.Windows.Forms.TextBox txtbx_Brand;
        private System.Windows.Forms.TextBox txtbx_Type;
    }
}