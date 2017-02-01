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
    public partial class UserSearch: Form
    {
        public UserSearch()
        {
            InitializeComponent();
        }

        private void UserSearch_Load(object sender, EventArgs e)
        {
            MessageBox.Show("When application is live this will show list of all employees with access to the application, they will then be able to select a user and pop a user update form requesting/saving updates");
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            UserManagement UserManagement = new UserManagement();
            UserManagement.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserManagement ss = new UserManagement();
            ss.Show();
        }
    }
}
