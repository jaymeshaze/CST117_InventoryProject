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

        private void ManagerNotice(object sender, EventArgs e)
        {
            if(GlobalVariables.ManagerNotice == true)
            {
                MessageBox.Show("There is low stock that needs to be reordered.");
                GlobalVariables.ManagerNotice = false;
            }
            return;
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
            this.Close();
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
            this.Close();
            UserManagement UserManagement  = new UserManagement();
            UserManagement.Show();
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager InventoryManagement = new InventoryManager();
            InventoryManagement.Show();
        }
        
    }
}
