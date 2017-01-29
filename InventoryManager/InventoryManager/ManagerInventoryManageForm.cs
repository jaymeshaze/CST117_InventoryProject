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
    public partial class InventoryManager: Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void btnManageDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {

        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }
    }
}
