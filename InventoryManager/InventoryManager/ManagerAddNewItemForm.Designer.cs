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
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(141, 323);
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
            this.labelAddItem.Location = new System.Drawing.Point(51, 105);
            this.labelAddItem.Name = "labelAddItem";
            this.labelAddItem.Size = new System.Drawing.Size(348, 25);
            this.labelAddItem.TabIndex = 18;
            this.labelAddItem.Text = "Add New Item Information";
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitle.Location = new System.Drawing.Point(93, 166);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(262, 27);
            this.txtbxTitle.TabIndex = 21;
            this.txtbxTitle.Text = "User Will Fill Form";
            this.txtbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxTitle.TextChanged += new System.EventHandler(this.txtbxTitle_TextChanged);
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 379);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.labelAddItem);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Add New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelAddItem;
        private System.Windows.Forms.TextBox txtbxTitle;
    }
}