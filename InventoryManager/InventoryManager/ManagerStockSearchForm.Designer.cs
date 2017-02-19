namespace InventoryManager
{
    partial class StockSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockSearch));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.viewStock = new System.Windows.Forms.DataGridView();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPreviousMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).BeginInit();
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
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReturn.Location = new System.Drawing.Point(1672, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(128, 44);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // viewStock
            // 
            this.viewStock.AllowUserToAddRows = false;
            this.viewStock.AllowUserToDeleteRows = false;
            this.viewStock.AllowUserToResizeColumns = false;
            this.viewStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.viewStock.EnableHeadersVisualStyles = false;
            this.viewStock.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewStock.Location = new System.Drawing.Point(461, 283);
            this.viewStock.MultiSelect = false;
            this.viewStock.Name = "viewStock";
            this.viewStock.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.viewStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.viewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewStock.ShowEditingIcon = false;
            this.viewStock.Size = new System.Drawing.Size(1000, 379);
            this.viewStock.TabIndex = 15;
            this.viewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewStock_CellContentClick);
            // 
            // btnSold
            // 
            this.btnSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSold.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSold.Location = new System.Drawing.Point(461, 683);
            this.btnSold.Margin = new System.Windows.Forms.Padding(4);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(133, 28);
            this.btnSold.TabIndex = 11;
            this.btnSold.Text = "Sold";
            this.btnSold.UseVisualStyleBackColor = true;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Location = new System.Drawing.Point(596, 683);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPreviousMenu
            // 
            this.btnPreviousMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreviousMenu.Location = new System.Drawing.Point(1288, 683);
            this.btnPreviousMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviousMenu.Name = "btnPreviousMenu";
            this.btnPreviousMenu.Size = new System.Drawing.Size(173, 28);
            this.btnPreviousMenu.TabIndex = 14;
            this.btnPreviousMenu.Text = "Previous Menu";
            this.btnPreviousMenu.UseVisualStyleBackColor = true;
            this.btnPreviousMenu.Click += new System.EventHandler(this.btnPreviousMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neuropol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(606, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Stock Item Then Update Status By Clicking Sold or Delete";
            // 
            // StockSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1816, 912);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousMenu);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.viewStock);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StockSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 Games Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPreviousMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewStock;
    }
}