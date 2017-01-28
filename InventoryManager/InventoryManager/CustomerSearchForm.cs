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

        private void CUSTOMER_SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void CUST_SRCH_ALL_Click(object sender, EventArgs e)
        {

        }

        private void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen openForm1 = new LoginScreen();
            openForm1.Show();
        }
    }
}
