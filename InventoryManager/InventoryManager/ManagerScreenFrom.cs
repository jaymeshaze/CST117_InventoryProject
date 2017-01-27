using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class ManagerScreen : Form
    {
        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void CUSTOMER_SEARCH_Load(object sender, EventArgs e)
        {

        }

        

        private void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This searches the store inventory and displays the desired item.");
        }

        

        private void btnClickLogout(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen login = new LoginScreen();
            login.Show();
        }

        private void CustomerSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void manageUsersEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This is where User Data is managed.");
        }

        private void inventoryDisplayEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This retrieves the List of store inventory.");
        }

        private void inventoryOptimizationEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This Optomizes the Inventory.");
        }

        private void inventoryOrderEvent(object sender, EventArgs e)
        {
            MessageBox.Show("This Orders new Inventory.");
        }
    }
}
