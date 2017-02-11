namespace InventoryManager
{
    partial class UpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.viewUserList = new System.Windows.Forms.DataGridView();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.lbl_FName = new System.Windows.Forms.Label();
            this.txtbx_fName = new System.Windows.Forms.TextBox();
            this.txtbx_lName = new System.Windows.Forms.TextBox();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpbx_UpdateUser = new System.Windows.Forms.GroupBox();
            this.lbl_EmpID = new System.Windows.Forms.Label();
            this.lbl_EmployeeID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserList)).BeginInit();
            this.grpbx_UpdateUser.SuspendLayout();
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
            // viewUserList
            // 
            this.viewUserList.AllowUserToAddRows = false;
            this.viewUserList.AllowUserToDeleteRows = false;
            this.viewUserList.AllowUserToResizeColumns = false;
            this.viewUserList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewUserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewUserList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.viewUserList.EnableHeadersVisualStyles = false;
            this.viewUserList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewUserList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewUserList.Location = new System.Drawing.Point(627, 386);
            this.viewUserList.MultiSelect = false;
            this.viewUserList.Name = "viewUserList";
            this.viewUserList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewUserList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewUserList.ShowEditingIcon = false;
            this.viewUserList.Size = new System.Drawing.Size(1000, 300);
            this.viewUserList.TabIndex = 15;
            this.viewUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUserList_CellContentClick);
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
            // lbl_FName
            // 
            this.lbl_FName.AutoSize = true;
            this.lbl_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_FName.Location = new System.Drawing.Point(294, 371);
            this.lbl_FName.Name = "lbl_FName";
            this.lbl_FName.Size = new System.Drawing.Size(112, 25);
            this.lbl_FName.TabIndex = 22;
            this.lbl_FName.Text = "First Name:";
            // 
            // txtbx_fName
            // 
            this.txtbx_fName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fName.Location = new System.Drawing.Point(299, 399);
            this.txtbx_fName.Name = "txtbx_fName";
            this.txtbx_fName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_fName.TabIndex = 23;
            this.txtbx_fName.TextChanged += new System.EventHandler(this.txtbx_fName_TextChanged);
            // 
            // txtbx_lName
            // 
            this.txtbx_lName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lName.Location = new System.Drawing.Point(299, 471);
            this.txtbx_lName.Name = "txtbx_lName";
            this.txtbx_lName.Size = new System.Drawing.Size(262, 32);
            this.txtbx_lName.TabIndex = 25;
            this.txtbx_lName.TextChanged += new System.EventHandler(this.txtbx_lName_TextChanged);
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_LName.Location = new System.Drawing.Point(294, 443);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(112, 25);
            this.lbl_LName.TabIndex = 24;
            this.lbl_LName.Text = "Last Name:";
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
            this.comboBox_Title.Location = new System.Drawing.Point(299, 543);
            this.comboBox_Title.Name = "comboBox_Title";
            this.comboBox_Title.Size = new System.Drawing.Size(262, 31);
            this.comboBox_Title.TabIndex = 27;
            this.comboBox_Title.SelectedIndexChanged += new System.EventHandler(this.comboBox_Title_SelectedIndexChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Title.Location = new System.Drawing.Point(294, 515);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(161, 25);
            this.lbl_Title.TabIndex = 26;
            this.lbl_Title.Text = "Select User Title:";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(299, 613);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Username.TabIndex = 29;
            this.txtbx_Username.TextChanged += new System.EventHandler(this.txtbx_Username_TextChanged);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Username.Location = new System.Drawing.Point(294, 585);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(108, 25);
            this.lbl_Username.TabIndex = 28;
            this.lbl_Username.Text = "Username:";
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.Location = new System.Drawing.Point(299, 686);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(262, 32);
            this.txtbx_Password.TabIndex = 31;
            this.txtbx_Password.TextChanged += new System.EventHandler(this.txtbx_Password_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password.Location = new System.Drawing.Point(294, 658);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(104, 25);
            this.lbl_Password.TabIndex = 30;
            this.lbl_Password.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.Location = new System.Drawing.Point(344, 749);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 28);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpbx_UpdateUser
            // 
            this.grpbx_UpdateUser.Controls.Add(this.lbl_EmpID);
            this.grpbx_UpdateUser.Controls.Add(this.lbl_EmployeeID);
            this.grpbx_UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_UpdateUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_UpdateUser.Location = new System.Drawing.Point(250, 255);
            this.grpbx_UpdateUser.Name = "grpbx_UpdateUser";
            this.grpbx_UpdateUser.Size = new System.Drawing.Size(359, 549);
            this.grpbx_UpdateUser.TabIndex = 33;
            this.grpbx_UpdateUser.TabStop = false;
            this.grpbx_UpdateUser.Text = "Update User";
            // 
            // lbl_EmpID
            // 
            this.lbl_EmpID.AutoSize = true;
            this.lbl_EmpID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_EmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_EmpID.Location = new System.Drawing.Point(47, 78);
            this.lbl_EmpID.Name = "lbl_EmpID";
            this.lbl_EmpID.Size = new System.Drawing.Size(0, 25);
            this.lbl_EmpID.TabIndex = 36;
            // 
            // lbl_EmployeeID
            // 
            this.lbl_EmployeeID.AutoSize = true;
            this.lbl_EmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmployeeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EmployeeID.Location = new System.Drawing.Point(44, 46);
            this.lbl_EmployeeID.Name = "lbl_EmployeeID";
            this.lbl_EmployeeID.Size = new System.Drawing.Size(129, 25);
            this.lbl_EmployeeID.TabIndex = 34;
            this.lbl_EmployeeID.Text = "Employee ID:";
            this.lbl_EmployeeID.Click += new System.EventHandler(this.lbl_EmployeeID_Click);
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.comboBox_Title);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txtbx_lName);
            this.Controls.Add(this.lbl_LName);
            this.Controls.Add(this.lbl_FName);
            this.Controls.Add(this.txtbx_fName);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.viewUserList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbx_UpdateUser);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games User Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserList)).EndInit();
            this.grpbx_UpdateUser.ResumeLayout(false);
            this.grpbx_UpdateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView viewUserList;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.Label lbl_FName;
        private System.Windows.Forms.TextBox txtbx_fName;
        private System.Windows.Forms.TextBox txtbx_lName;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.ComboBox comboBox_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txtbx_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpbx_UpdateUser;
        private System.Windows.Forms.Label lbl_EmpID;
        private System.Windows.Forms.Label lbl_EmployeeID;
    }
}