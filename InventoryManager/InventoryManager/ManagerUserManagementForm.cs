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
    public partial class UserManagement: Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            AddUser AddUser = new AddUser();
            AddUser.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSearch UserSearch = new UserSearch();
            UserSearch.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerScreen ss = new ManagerScreen();
            ss.Show();
        }
    }
}
