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
    public partial class EmployeeScreen : Form
    {
        public EmployeeScreen()
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel4.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen openForm1 = new LoginScreen();
            openForm1.Show();
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel1.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInventory_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel2.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnListInventory_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel3.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ListStockSearch_btn_Click(object sender, EventArgs e)
        {

            string store = ListStoreText.Text;
            if (!IsAllDigits(store))
            {
                MessageBox.Show("Only digits are allowed for store number");
            }
            else if (store.Length != 6)
            {
                MessageBox.Show("Store code must be 6 digits long");
            }
            else
            {
                string message = String.Format("The stock list for store {0} will be displayed here. ", store);
                MessageBox.Show(message);
            }
        }

        public bool IsAllDigits(string s)
        {
            return s.All(char.IsDigit);
        }
    }

}
