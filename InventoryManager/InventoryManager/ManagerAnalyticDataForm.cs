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
    public partial class AnalyticData: Form
    {
        public AnalyticData()
        {
            InitializeComponent();
        }

        

        private void AnalyticData_Load(object sender, EventArgs e)
        {

        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Analytics Analytics = new Analytics();
            Analytics.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort data by brand");
        }

        private void btnAscend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort data by ascending order");

        }

        private void btnDescend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort data by descending order");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort data by item");
        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will sort data by type");
        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Hide();
            Analytics form1 = new Analytics();
            form1.Show();
        }
    }
}
