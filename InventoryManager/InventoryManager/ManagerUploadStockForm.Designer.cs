namespace InventoryManager
{
    partial class UploadStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadStock));
            this.btnUpload = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.txtbxCSVPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpload.Location = new System.Drawing.Point(126, 323);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(173, 28);
            this.btnUpload.TabIndex = 16;
            this.btnUpload.Text = "Upload Stock";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelect.Location = new System.Drawing.Point(32, 105);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(375, 25);
            this.labelSelect.TabIndex = 18;
            this.labelSelect.Text = "Please Select Your .CSV File";
            // 
            // txtbxCSVPath
            // 
            this.txtbxCSVPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCSVPath.Location = new System.Drawing.Point(37, 166);
            this.txtbxCSVPath.Name = "txtbxCSVPath";
            this.txtbxCSVPath.Size = new System.Drawing.Size(262, 38);
            this.txtbxCSVPath.TabIndex = 20;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Neuropol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBrowse.Location = new System.Drawing.Point(306, 166);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 38);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // UploadStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(429, 378);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtbxCSVPath);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.btnUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Stock Upload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.TextBox txtbxCSVPath;
        private System.Windows.Forms.Button btnBrowse;
    }
}