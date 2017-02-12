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

            try
            {
                string search = CustomerSearchBox.Text;
            }
            catch (Exception )
            {
                MessageBox.Show("Invalid Search");
                return;
            }

        }
        public void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {
            AllInventory s = new AllInventory();
            s.searchquery = CustomerSearchBox.Text;
            s.Show();
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
            this.Hide();
            UserManagement UserManagement  = new UserManagement();
            UserManagement.Show();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManager InventoryManagement = new InventoryManager();
            InventoryManagement.Show();
        }

        

        
    }
}
