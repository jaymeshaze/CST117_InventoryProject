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
    public partial class ProductDetailsManager: Form
    {
        public ProductDetailsManager()
        {
            InitializeComponent();
        }

        

        private void ProductDetailsManager_Load(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Michael\Documents\CST117_InventoryProject\MASTER_DB_2_5_2017\T2G_MainDB.mdf;Integrated Security=True;Connect Timeout=30");
            connection1.Open();
            //SqlCommand readinventory = new SqlCommand("select Title, Details, Price, Brand, Type from Main_Inventory where Main_Inventory = '" + searchquery + "'", connection1);
            //SqlDataReader inventorysearch = readinventory.ExecuteReader();
            SqlDataAdapter searchinventory = new SqlDataAdapter("select Title, Details, Price, Brand, Type from Main_Inventory where Title = '" + searchquery + "'", connection1);
            DataTable viewinventory = new DataTable();
            searchinventory.Fill(viewinventory);
            BindingSource inventory_BS = new BindingSource();
            inventory_BS.DataSource = viewinventory;
            viewProductList.DataSource = inventory_BS;
            viewProductList.Show();
            //connection1.Close();
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductSearch ProductSearch = new ProductSearch();
            ProductSearch.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort products by brand");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort products by item");
        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort products by type");
        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
        public string searchquery;
        private void viewProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
