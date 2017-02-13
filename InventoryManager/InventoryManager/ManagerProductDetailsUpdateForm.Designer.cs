namespace InventoryManager
{
    partial class DetailsUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsUpdate));
            this.labelUpdateDetails = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUpdateDetails
            // 
            this.labelUpdateDetails.AutoSize = true;
            this.labelUpdateDetails.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateDetails.Location = new System.Drawing.Point(54, 105);
            this.labelUpdateDetails.Name = "labelUpdateDetails";
            this.labelUpdateDetails.Size = new System.Drawing.Size(341, 25);
            this.labelUpdateDetails.TabIndex = 19;
            this.labelUpdateDetails.Text = "Update Detail Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(139, 323);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 28);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTitle.Location = new System.Drawing.Point(93, 166);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(262, 27);
            this.txtbxTitle.TabIndex = 22;
            this.txtbxTitle.Text = "User Will Fill Form";
            this.txtbxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbxTitle.Click += new System.EventHandler(this.txtbxTitle_Click);
            // 
            // DetailsUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 379);
            this.Controls.Add(this.txtbxTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelUpdateDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetailsUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Update Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpdateDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbxTitle;
    }
}