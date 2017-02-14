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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void StockSearch_Load(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\T2G_MainDB.mdf;Integrated Security=True");
            connection1.Open();
            //SqlCommand readinventory = new SqlCommand("select Title, Details, Price, Brand, Type from Main_Inventory where Main_Inventory = '" + searchquery + "'", connection1);
            //SqlDataReader inventorysearch = readinventory.ExecuteReader();
            SqlDataAdapter searchinventory = new SqlDataAdapter("select Title, Details, Price, Brand, Type from Main_Inventory where Title = '" + searchquery + "'", connection1);
            DataTable viewinventory = new DataTable();
            searchinventory.Fill(viewinventory);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = viewinventory;
            viewStock.DataSource = inventory_BS;
            viewStock.Show();
            //connection1.Close();
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            StockControl StockControl = new StockControl();
            StockControl.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by brand");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by item");
        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort stock by type");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockControl form1 = new StockControl();
            form1.Show();
        }

        public string searchquery;
        private void viewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
