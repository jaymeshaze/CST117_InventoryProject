using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManager
{
    public partial class StockSearch: Form
    {
        public StockSearch()
        {
            InitializeComponent();
        }

        string ID;

        SqlConnection Inventory_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Inventory_Con.Close();
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void StockSearch_Load(object sender, EventArgs e)
        {
            Inventory_Con.Open();
            SqlDataAdapter inventory_SDA = new SqlDataAdapter("select Id as'Item ID', Title, Details, Price, Brand, Type from Main_Inventory where Date_Out is null", Inventory_Con);
            DataTable inventory_DT = new DataTable();
            inventory_SDA.Fill(inventory_DT);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = inventory_DT;
            viewStock.DataSource = inventory_BS;
            viewStock.Show();
            Inventory_Con.Close();
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            Inventory_Con.Close();
            this.Close();
            StockControl StockControl = new StockControl();
            StockControl.Show();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            Inventory_Con.Open();
            //insert data command
            SqlCommand SoldItemCMD = new SqlCommand("update Main_Inventory set Date_Out = GETDATE() where Id='" + ID + "'", Inventory_Con);
            //SqlCommand executed
            SoldItemCMD.ExecuteNonQuery();
            //successful update confirmation message
            MessageBox.Show("Item Has Been Recorded As SOLD!");
            SqlDataAdapter inventory_SDA = new SqlDataAdapter("select Id as'Item ID', Title, Details, Price, Brand, Type from Main_Inventory where Date_Out is null", Inventory_Con);
            DataTable inventory_DT = new DataTable();
            inventory_SDA.Fill(inventory_DT);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = inventory_DT;
            viewStock.DataSource = inventory_BS;
            viewStock.Show();
            Inventory_Con.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Inventory_Con.Open();
            //delete sql command
            SqlCommand DeleteItemCMD = new SqlCommand("delete from Main_Inventory where Id='" + ID + "'", Inventory_Con);
            //command executed
            DeleteItemCMD.ExecuteNonQuery();
            //successful delete confirmation message
            MessageBox.Show("Item Deleted!!!");
            SqlDataAdapter inventory_SDA = new SqlDataAdapter("select Id as'Item ID', Title, Details, Price, Brand, Type from Main_Inventory where Date_Out is null", Inventory_Con);
            DataTable inventory_DT = new DataTable();
            inventory_SDA.Fill(inventory_DT);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = inventory_DT;
            viewStock.DataSource = inventory_BS;
            viewStock.Show();
            Inventory_Con.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockControl form1 = new StockControl();
            form1.Show();
        }

        private void viewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //determines row selected for update
                DataGridViewRow row = this.viewStock.Rows[e.RowIndex];

                //places values for selected record in variable
                ID = row.Cells["Item ID"].Value.ToString();

            }
        }
    }
}
