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
            this.txtbx_fName = new System.Windows.Forms.TextBox();
            this.txtbx_lName = new System.Windows.Forms.TextBox();
            this.comboBox_Title = new System.Windows.Forms.ComboBox();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.grpbx_NewUser = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Neuropol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(141, 447);
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
            this.labelAddItem.Location = new System.Drawing.Point(51, 59);
            this.labelAddItem.Name = "labelAddItem";
            this.labelAddItem.Size = new System.Drawing.Size(348, 25);
            this.labelAddItem.TabIndex = 18;
            this.labelAddItem.Text = "Add New Item Information";
            // 
            // txtbx_fName
            // 
            this.txtbx_fName.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_fName.Location = new System.Drawing.Point(93, 150);
            this.txtbx_fName.Name = "txtbx_fName";
            this.txtbx_fName.Size = new System.Drawing.Size(262, 27);
            this.txtbx_fName.TabIndex = 21;
            this.txtbx_fName.Text = "First Name";
            this.txtbx_fName.TextChanged += new System.EventHandler(this.txtbx_fName_TextChanged);
            // 
            // txtbx_lName
            // 
            this.txtbx_lName.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_lName.Location = new System.Drawing.Point(93, 200);
            this.txtbx_lName.Name = "txtbx_lName";
            this.txtbx_lName.Size = new System.Drawing.Size(262, 27);
            this.txtbx_lName.TabIndex = 22;
            this.txtbx_lName.Text = "Last Name";
            this.txtbx_lName.TextChanged += new System.EventHandler(this.txtbx_lName_TextChanged);
            // 
            // comboBox_Title
            // 
            this.comboBox_Title.AllowDrop = true;
            this.comboBox_Title.Font = new System.Drawing.Font("Neuropol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Title.FormattingEnabled = true;
            this.comboBox_Title.Items.AddRange(new object[] {
            "Manager",
            "Associate",
            "Guest"});
            this.comboBox_Title.Location = new System.Drawing.Point(93, 250);
            this.comboBox_Title.Name = "comboBox_Title";
            this.comboBox_Title.Size = new System.Drawing.Size(262, 27);
            this.comboBox_Title.TabIndex = 23;
            this.comboBox_Title.Text = "Select User Title";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.Location = new System.Drawing.Point(93, 299);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(262, 27);
            this.txtbx_Username.TabIndex = 24;
            this.txtbx_Username.Text = "Username";
            this.txtbx_Username.TextChanged += new System.EventHandler(this.txtbx_Username_TextChanged);
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.Location = new System.Drawing.Point(93, 348);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(262, 27);
            this.txtbx_Password.TabIndex = 25;
            this.txtbx_Password.Text = "Password";
            this.txtbx_Password.TextChanged += new System.EventHandler(this.txtbx_Password_TextChanged);
            // 
            // grpbx_NewUser
            // 
            this.grpbx_NewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_NewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbx_NewUser.Location = new System.Drawing.Point(73, 118);
            this.grpbx_NewUser.Name = "grpbx_NewUser";
            this.grpbx_NewUser.Size = new System.Drawing.Size(300, 280);
            this.grpbx_NewUser.TabIndex = 26;
            this.grpbx_NewUser.TabStop = false;
            this.grpbx_NewUser.Text = "New User";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(448, 527);
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
            this.Name = "NewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Add New Item";
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
    }
}