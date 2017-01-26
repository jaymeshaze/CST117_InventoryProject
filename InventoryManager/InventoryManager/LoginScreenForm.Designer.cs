﻿namespace InventoryManager
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UsernameTextField = new System.Windows.Forms.TextBox();
            this.PasswordTextField = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // USERNAME
            // 
            this.UsernameTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsernameTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextField.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UsernameTextField.Location = new System.Drawing.Point(180, 60);
            this.UsernameTextField.Name = "USERNAME";
            this.UsernameTextField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UsernameTextField.Size = new System.Drawing.Size(256, 30);
            this.UsernameTextField.TabIndex = 0;
            this.UsernameTextField.Text = "Guest";
            // 
            // PASSWORD
            // 
            this.PasswordTextField.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextField.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordTextField.Location = new System.Drawing.Point(180, 100);
            this.PasswordTextField.Name = "PASSWORD";
            this.PasswordTextField.Size = new System.Drawing.Size(256, 30);
            this.PasswordTextField.TabIndex = 1;
            this.PasswordTextField.Text = "password";
            // 
            // LOGIN_BUTTON
            // 
            this.LoginButton.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LoginButton.Location = new System.Drawing.Point(214, 153);
            this.LoginButton.Name = "LOGIN_BUTTON";
            this.LoginButton.Size = new System.Drawing.Size(188, 38);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LOGIN_BUTTON_Click);
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
            this.LoginGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginGroupBox.Controls.Add(this.PasswordTextField);
            this.LoginGroupBox.Controls.Add(this.label2);
            this.LoginGroupBox.Controls.Add(this.UsernameTextField);
            this.LoginGroupBox.Controls.Add(this.label1);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Font = new System.Drawing.Font("Neuropol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginGroupBox.Location = new System.Drawing.Point(903, 315);
            this.LoginGroupBox.Name = "LOG_IN_groupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(467, 245);
            this.LoginGroupBox.TabIndex = 5;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "SIGN IN";
            // 
            // LOGIN_LOGO
            // 
            this.LoginLogo.Image = global::InventoryManager.Properties.Resources.TTG_LOGO_LOGIN_SCREEN_WIDTH_477PX;
            this.LoginLogo.Location = new System.Drawing.Point(382, 315);
            this.LoginLogo.Name = "LOGIN_LOGO";
            this.LoginLogo.Size = new System.Drawing.Size(493, 363);
            this.LoginLogo.TabIndex = 6;
            this.LoginLogo.TabStop = false;
            // 
            // LOGIN_SCREEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.LoginLogo);
            this.Controls.Add(this.LoginGroupBox);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN_SCREEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LOGIN_SCREEN_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextField;
        private System.Windows.Forms.TextBox PasswordTextField;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.PictureBox LoginLogo;
    }
}
