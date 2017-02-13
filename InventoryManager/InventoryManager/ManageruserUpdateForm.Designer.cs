namespace InventoryManager
{
    partial class UserUpdate
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelUpdateItem = new System.Windows.Forms.Label();
            this.txtbx_FName = new System.Windows.Forms.TextBox();
            this.txtbx_LName = new System.Windows.Forms.TextBox();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.grpbx_UpdateUser = new System.Windows.Forms.GroupBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.grpbx_UpdateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(224, 454);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnUpdate";
            this.btnAdd.Size = new System.Drawing.Size(173, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Update User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labelAddItem
            // 
            this.labelUpdateItem.AutoSize = true;
            this.labelUpdateItem.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateItem.Location = new System.Drawing.Point(136, 59);
            this.labelUpdateItem.Name = "labelUpdateItem";
            this.labelUpdateItem.Size = new System.Drawing.Size(353, 25);
            this.labelUpdateItem.TabIndex = 18;
            this.labelUpdateItem.Text = "Update User Information";
            // 
            // txtbx_fName
            // 
            this.txtbx_FName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_FName.Location = new System.Drawing.Point(258, 150);
            this.txtbx_FName.Name = "txtbx_FName";
            this.txtbx_FName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_FName.TabIndex = 21;
            this.txtbx_FName.TextChanged += new System.EventHandler(this.txtbx_FName_TextChanged);
            // 
            // txtbx_lName
            // 
            this.txtbx_LName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_LName.Location = new System.Drawing.Point(258, 200);
            this.txtbx_LName.Name = "txtbx_LName";
            this.txtbx_LName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_LName.TabIndex = 22;
            this.txtbx_LName.TextChanged += new System.EventHandler(this.txtbx_LName_TextChanged);
            // 
            // comboBox_Title
            // 
            this.comboBox_Title.AllowDrop = true;
            this.comboBox_Title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Title.FormattingEnabled = true;
            this.comboBox_Title.Items.AddRange(new object[] {
            "Manager",
            "Associate",
            "Guest"});
            this.comboBox_Title.Location = new System.Drawing.Point(258, 250);
            this.comboBox_Title.Name = "comboBox_Title";
            this.comboBox_Title.Size = new System.Drawing.Size(262, 31);
            this.comboBox_Title.TabIndex = 23;
            this.comboBox_Title.SelectedIndexChanged += new System.EventHandler(this.comboBox_Title_SelectedIndexChanged);
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(258, 299);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Username.TabIndex = 24;
            this.txtbx_Username.TextChanged += new System.EventHandler(this.txtbx_Username_TextChanged);
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.Location = new System.Drawing.Point(258, 348);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Password.TabIndex = 25;
            this.txtbx_Password.TextChanged += new System.EventHandler(this.txtbx_Password_TextChanged);
            // 
            // grpbx_NewUser
            // 
            this.grpbx_UpdateUser.Controls.Add(this.lbl_Password);
            this.grpbx_UpdateUser.Controls.Add(this.lbl_Username);
            this.grpbx_UpdateUser.Controls.Add(this.lbl_Title);
            this.grpbx_UpdateUser.Controls.Add(this.lbl_LName);
            this.grpbx_UpdateUser.Controls.Add(this.lbl_FName);
            this.grpbx_UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_UpdateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_UpdateUser.Location = new System.Drawing.Point(47, 100);
            this.grpbx_UpdateUser.Name = "grpbx_UpdateUser";
            this.grpbx_UpdateUser.Size = new System.Drawing.Size(520, 324);
            this.grpbx_UpdateUser.TabIndex = 26;
            this.grpbx_UpdateUser.TabStop = false;
            this.grpbx_UpdateUser.Text = "Update User";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(92, 254);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(104, 25);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(88, 202);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(108, 25);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(35, 152);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(161, 25);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Select User Title:";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.Location = new System.Drawing.Point(84, 103);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(112, 25);
            this.lbl_LName.TabIndex = 1;
            this.lbl_LName.Text = "Last Name:";
            // 
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FName.Location = new System.Drawing.Point(84, 53);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(112, 25);
            this.lbl_FName.TabIndex = 0;
            this.lbl_FName.Text = "First Name:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(613, 544);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.comboBox_Title);
            this.Controls.Add(this.txtbx_LName);
            this.Controls.Add(this.txtbx_FName);
            this.Controls.Add(this.labelUpdateItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpbx_UpdateUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Update User";
            this.grpbx_UpdateUser.ResumeLayout(false);
            this.grpbx_UpdateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelUpdateItem;
        private System.Windows.Forms.TextBox txtbx_FName;
        private System.Windows.Forms.TextBox txtbx_LName;
        private System.Windows.Forms.ComboBox comboBox_Title;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.GroupBox grpbx_UpdateUser;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
    }
}