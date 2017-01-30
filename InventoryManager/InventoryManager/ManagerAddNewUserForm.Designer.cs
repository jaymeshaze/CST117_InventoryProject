namespace InventoryManager
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.labelAddUser = new System.Windows.Forms.Label();
            this.txtbxFName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddUser
            // 
            this.labelAddUser.AutoSize = true;
            this.labelAddUser.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddUser.Location = new System.Drawing.Point(51, 105);
            this.labelAddUser.Name = "labelAddUser";
            this.labelAddUser.Size = new System.Drawing.Size(353, 25);
            this.labelAddUser.TabIndex = 19;
            this.labelAddUser.Text = "Add New User Information";
            // 
            // txtbxFName
            // 
            this.txtbxFName.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFName.Location = new System.Drawing.Point(93, 166);
            this.txtbxFName.Name = "txtbxFName";
            this.txtbxFName.Size = new System.Drawing.Size(262, 27);
            this.txtbxFName.TabIndex = 22;
            this.txtbxFName.Text = "User Will Fill Form";
            this.txtbxFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(141, 323);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 28);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 379);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtbxFName);
            this.Controls.Add(this.labelAddUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddUser;
        private System.Windows.Forms.TextBox txtbxFName;
        private System.Windows.Forms.Button btnAdd;
    }
}