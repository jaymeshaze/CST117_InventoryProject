namespace TEAM_TWO_GAMES_GUI_001
{
    partial class LOGIN_SCREEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_SCREEN));
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.PASSWORD = new System.Windows.Forms.TextBox();
            this.LOGIN_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOG_IN_groupBox = new System.Windows.Forms.GroupBox();
            this.LOGIN_LOGO = new System.Windows.Forms.PictureBox();
            this.LOG_IN_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.USERNAME.BackColor = System.Drawing.Color.WhiteSmoke;
            this.USERNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.USERNAME.Location = new System.Drawing.Point(180, 60);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.USERNAME.Size = new System.Drawing.Size(256, 30);
            this.USERNAME.TabIndex = 0;
            this.USERNAME.Text = "Guest";
            // 
            // PASSWORD
            // 
            this.PASSWORD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PASSWORD.Location = new System.Drawing.Point(180, 100);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(256, 30);
            this.PASSWORD.TabIndex = 1;
            this.PASSWORD.Text = "password";
            // 
            // LOGIN_BUTTON
            // 
            this.LOGIN_BUTTON.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BUTTON.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LOGIN_BUTTON.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LOGIN_BUTTON.Location = new System.Drawing.Point(214, 153);
            this.LOGIN_BUTTON.Name = "LOGIN_BUTTON";
            this.LOGIN_BUTTON.Size = new System.Drawing.Size(188, 38);
            this.LOGIN_BUTTON.TabIndex = 2;
            this.LOGIN_BUTTON.Text = "LOGIN";
            this.LOGIN_BUTTON.UseVisualStyleBackColor = true;
            this.LOGIN_BUTTON.Click += new System.EventHandler(this.LOGIN_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD:";
            // 
            // LOG_IN_groupBox
            // 
            this.LOG_IN_groupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LOG_IN_groupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LOG_IN_groupBox.Controls.Add(this.PASSWORD);
            this.LOG_IN_groupBox.Controls.Add(this.label2);
            this.LOG_IN_groupBox.Controls.Add(this.USERNAME);
            this.LOG_IN_groupBox.Controls.Add(this.label1);
            this.LOG_IN_groupBox.Controls.Add(this.LOGIN_BUTTON);
            this.LOG_IN_groupBox.Font = new System.Drawing.Font("Neuropol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOG_IN_groupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LOG_IN_groupBox.Location = new System.Drawing.Point(903, 315);
            this.LOG_IN_groupBox.Name = "LOG_IN_groupBox";
            this.LOG_IN_groupBox.Size = new System.Drawing.Size(467, 245);
            this.LOG_IN_groupBox.TabIndex = 5;
            this.LOG_IN_groupBox.TabStop = false;
            this.LOG_IN_groupBox.Text = "SIGN IN";
            // 
            // LOGIN_LOGO
            // 
            this.LOGIN_LOGO.Image = global::TEAM_TWO_GAMES_GUI_001.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.LOGIN_LOGO.Location = new System.Drawing.Point(382, 315);
            this.LOGIN_LOGO.Name = "LOGIN_LOGO";
            this.LOGIN_LOGO.Size = new System.Drawing.Size(493, 363);
            this.LOGIN_LOGO.TabIndex = 6;
            this.LOGIN_LOGO.TabStop = false;
            // 
            // LOGIN_SCREEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.LOGIN_LOGO);
            this.Controls.Add(this.LOG_IN_groupBox);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN_SCREEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_SCREEN_Load);
            this.LOG_IN_groupBox.ResumeLayout(false);
            this.LOG_IN_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGIN_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.TextBox PASSWORD;
        private System.Windows.Forms.Button LOGIN_BUTTON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LOG_IN_groupBox;
        private System.Windows.Forms.PictureBox LOGIN_LOGO;
    }
}

