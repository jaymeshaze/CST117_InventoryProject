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

namespace InventoryManager
{
    public partial class AllInventory: Form
    {
        public AllInventory()
        {
            InitializeComponent();
            connectionstring = ConfigurationManager.ConnectionStrings["C:\\USERS\\MICHAEL\\DOCUMENTS\\CST117_INVENTORYPROJECT\\MASTER_DB_2_5_2017\\T2G_MAINDB.MDF"].ConnectionString;
        }

        //static private ManagerScreen access = new ManagerScreen();
        //public string searchquery = access.CustomerSearchBox.Text;
        public string searchquery;
        SqlConnection connection1;
        string connectionstring;

        public searchquery1()
        {
            using (connection1 = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select searchquery from Main_Inventory", connectionstring))
            {
                
                adapter.Fill(viewAllInventory);

            }
        }
        

        private void AllInventory_Load(object sender, EventArgs e)
        {
            searchquery1();
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
            this.Hide();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
    }
}
