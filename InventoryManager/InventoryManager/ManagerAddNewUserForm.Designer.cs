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
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelAddItem = new System.Windows.Forms.Label();
            this.txtbx_fName = new System.Windows.Forms.TextBox();
            this.txtbx_lName = new System.Windows.Forms.TextBox();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.grpbx_NewUser = new System.Windows.Forms.GroupBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.grpbx_NewUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(224, 454);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAddItem
            // 
            this.labelAddItem.AutoSize = true;
            this.labelAddItem.Font = new System.Drawing.Font("Neuropol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddItem.Location = new System.Drawing.Point(136, 59);
            this.labelAddItem.Name = "labelAddItem";
            this.labelAddItem.Size = new System.Drawing.Size(353, 25);
            this.labelAddItem.TabIndex = 18;
            this.labelAddItem.Text = "Add New User Information";
            // 
            // txtbx_fName
            // 
            this.txtbx_fName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fName.Location = new System.Drawing.Point(258, 150);
            this.txtbx_fName.Name = "txtbx_fName";
            this.txtbx_fName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_fName.TabIndex = 21;
            // 
            // txtbx_lName
            // 
            this.txtbx_lName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lName.Location = new System.Drawing.Point(258, 200);
            this.txtbx_lName.Name = "txtbx_lName";
            this.txtbx_lName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_lName.TabIndex = 22;
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
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(258, 299);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Username.TabIndex = 24;
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.Location = new System.Drawing.Point(258, 348);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Password.TabIndex = 25;
            // 
            // grpbx_NewUser
            // 
            this.grpbx_NewUser.Controls.Add(this.lbl_Password);
            this.grpbx_NewUser.Controls.Add(this.lbl_Username);
            this.grpbx_NewUser.Controls.Add(this.lbl_Title);
            this.grpbx_NewUser.Controls.Add(this.lbl_LName);
            this.grpbx_NewUser.Controls.Add(this.lbl_FName);
            this.grpbx_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_NewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_NewUser.Location = new System.Drawing.Point(47, 100);
            this.grpbx_NewUser.Name = "grpbx_NewUser";
            this.grpbx_NewUser.Size = new System.Drawing.Size(520, 324);
            this.grpbx_NewUser.TabIndex = 26;
            this.grpbx_NewUser.TabStop = false;
            this.grpbx_NewUser.Text = "New User";
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
            this.Controls.Add(this.txtbx_lName);
            this.Controls.Add(this.txtbx_fName);
            this.Controls.Add(this.labelAddItem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpbx_NewUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Add New User";
            this.grpbx_NewUser.ResumeLayout(false);
            this.grpbx_NewUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelAddItem;
        private System.Windows.Forms.TextBox txtbx_fName;
        private System.Windows.Forms.TextBox txtbx_lName;
        private System.Windows.Forms.ComboBox comboBox_Title;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.GroupBox grpbx_NewUser;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
    }
}