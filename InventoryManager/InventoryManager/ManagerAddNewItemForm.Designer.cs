namespace InventoryManager
{
    partial class NewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAddItem = new System.Windows.Forms.Label();
            this.txtbx_Title = new System.Windows.Forms.TextBox();
            this.txtbx_lmgPath = new System.Windows.Forms.TextBox();
            this.txtbx_Price = new System.Windows.Forms.TextBox();
            this.txtbx_Brand = new System.Windows.Forms.TextBox();
            this.grpbx_NewUser = new System.Windows.Forms.GroupBox();
            this.rtxtbx_Details = new System.Windows.Forms.RichTextBox();
            this.btnImgBrowse = new System.Windows.Forms.Button();
            this.txtbx_Type = new System.Windows.Forms.TextBox();
            this.grpbx_NewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(220, 485);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAddItem
            // 
            this.labelAddItem.AutoSize = true;
            this.labelAddItem.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddItem.Location = new System.Drawing.Point(136, 29);
            this.labelAddItem.Name = "labelAddItem";
            this.labelAddItem.Size = new System.Drawing.Size(348, 25);
            this.labelAddItem.TabIndex = 18;
            this.labelAddItem.Text = "Add New Item Information";
            // 
            // txtbx_Title
            // 
            this.txtbx_Title.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Title.Location = new System.Drawing.Point(93, 110);
            this.txtbx_Title.Name = "txtbx_Title";
            this.txtbx_Title.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Title.TabIndex = 21;
            this.txtbx_Title.Text = "Title";
            // 
            // txtbx_lmgPath
            // 
            this.txtbx_lmgPath.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lmgPath.Location = new System.Drawing.Point(93, 285);
            this.txtbx_lmgPath.Name = "txtbx_lmgPath";
            this.txtbx_lmgPath.Size = new System.Drawing.Size(296, 27);
            this.txtbx_lmgPath.TabIndex = 22;
            this.txtbx_lmgPath.Text = "Upload Image";
            // 
            // txtbx_Price
            // 
            this.txtbx_Price.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Price.Location = new System.Drawing.Point(93, 326);
            this.txtbx_Price.Name = "txtbx_Price";
            this.txtbx_Price.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Price.TabIndex = 24;
            this.txtbx_Price.Text = "Price";
            // 
            // txtbx_Brand
            // 
            this.txtbx_Brand.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Brand.Location = new System.Drawing.Point(93, 367);
            this.txtbx_Brand.Name = "txtbx_Brand";
            this.txtbx_Brand.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Brand.TabIndex = 25;
            this.txtbx_Brand.Text = "Brand";
            // 
            // grpbx_NewUser
            // 
            this.grpbx_NewUser.Controls.Add(this.btnImgBrowse);
            this.grpbx_NewUser.Controls.Add(this.rtxtbx_Details);
            this.grpbx_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_NewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_NewUser.Location = new System.Drawing.Point(73, 82);
            this.grpbx_NewUser.Name = "grpbx_NewUser";
            this.grpbx_NewUser.Size = new System.Drawing.Size(470, 371);
            this.grpbx_NewUser.TabIndex = 26;
            this.grpbx_NewUser.TabStop = false;
            this.grpbx_NewUser.Text = "New Inventory Item";
            // 
            // rtxtbx_Details
            // 
            this.rtxtbx_Details.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtbx_Details.Location = new System.Drawing.Point(20, 67);
            this.rtxtbx_Details.Name = "rtxtbx_Details";
            this.rtxtbx_Details.Size = new System.Drawing.Size(432, 122);
            this.rtxtbx_Details.TabIndex = 0;
            this.rtxtbx_Details.Text = "Details";
            // 
            // btnImgBrowse
            // 
            this.btnImgBrowse.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgBrowse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnImgBrowse.Location = new System.Drawing.Point(323, 202);
            this.btnImgBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnImgBrowse.Name = "btnImgBrowse";
            this.btnImgBrowse.Size = new System.Drawing.Size(129, 28);
            this.btnImgBrowse.TabIndex = 27;
            this.btnImgBrowse.Text = "Browse";
            this.btnImgBrowse.UseVisualStyleBackColor = true;
            this.btnImgBrowse.Click += new System.EventHandler(this.btnImgBrowse_Clicked);
            // 
            // txtbx_Type
            // 
            this.txtbx_Type.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Type.Location = new System.Drawing.Point(93, 409);
            this.txtbx_Type.Name = "txtbx_Type";
            this.txtbx_Type.Size = new System.Drawing.Size(432, 27);
            this.txtbx_Type.TabIndex = 27;
            this.txtbx_Type.Text = "Type";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(613, 544);
            this.Controls.Add(this.txtbx_Type);
            this.Controls.Add(this.txtbx_Brand);
            this.Controls.Add(this.txtbx_Price);
            this.Controls.Add(this.txtbx_lmgPath);
            this.Controls.Add(this.txtbx_Title);
            this.Controls.Add(this.labelAddItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpbx_NewUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Add New Item";
            this.grpbx_NewUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelAddItem;
        private System.Windows.Forms.TextBox txtbx_Title;
        private System.Windows.Forms.TextBox txtbx_lmgPath;
        private System.Windows.Forms.TextBox txtbx_Price;
        private System.Windows.Forms.TextBox txtbx_Brand;
        private System.Windows.Forms.GroupBox grpbx_NewUser;
        private System.Windows.Forms.RichTextBox rtxtbx_Details;
        private System.Windows.Forms.Button btnImgBrowse;
        private System.Windows.Forms.TextBox txtbx_Type;
    }
}