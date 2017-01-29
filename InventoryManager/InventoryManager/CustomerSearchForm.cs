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
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void CUST_SRCH_ALL_Click(object sender, EventArgs e)
        {

        }

        private void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
