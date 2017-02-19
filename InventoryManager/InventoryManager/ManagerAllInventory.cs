using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace InventoryManager
{
    public partial class AllInventory: Form
    {
        public AllInventory()
        {
            InitializeComponent();
            
        }
        public string searchquery;

        private void AllInventory_Load(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");
            connection1.Open();
            SqlDataAdapter inventory_SDA = new SqlDataAdapter("select Title,Details,Image,Type,Brand,Price,P_Price as 'Sale Price' from Main_Inventory where Date_Out is null", connection1);
            DataTable inventory_DT = new DataTable();
            inventory_SDA.Fill(inventory_DT);
            viewAllInventory.DataSource = inventory_DT;
            viewAllInventory.Columns["Title"].Visible = true;
            viewAllInventory.Columns["Details"].Visible = true;
            viewAllInventory.Columns["Type"].Visible = true;
            viewAllInventory.Columns["Brand"].Visible = true;
            viewAllInventory.Columns["Price"].Visible = true;
            viewAllInventory.Columns["Sale Price"].Visible = true;
            viewAllInventory.Show();
            //connection1.Close();
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager InventoryManager = new InventoryManager();
            InventoryManager.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by brand");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by item");

        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by type");
        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }

        private void viewAllInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //determines row selected for update
                DataGridViewRow row = this.viewAllInventory.Rows[e.RowIndex];
                string imgPath = row.Cells["Image"].Value.ToString();
                string root = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 11));
                string absolutePath = (root + imgPath);
                pbx_Game.ImageLocation = absolutePath;
                pbx_Game.Show();
                lbl_Title.Text = row.Cells["Title"].Value.ToString();
                lbl_Type.Text = "For: " + row.Cells["Type"].Value.ToString();
                lbl_Brand.Text = "By: " + row.Cells["Brand"].Value.ToString();
                lbl_Price.Text = "$ " + row.Cells["Price"].Value.ToString();
                lbl_salePrice.Text = "On Sale: $ " + row.Cells["Sale Price"].Value.ToString();
                rtxtbx_Details.Text = row.Cells["Details"].Value.ToString();
               


            }
        }
    }
}
