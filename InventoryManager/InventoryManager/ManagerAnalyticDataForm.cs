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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void AnalyticData_Load(object sender, EventArgs e)
        {

        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {

        }

        private void btnAscend_Click(object sender, EventArgs e)
        {

        }

        private void btnDescend_Click(object sender, EventArgs e)
        {

        }

        private void btnByItem_Click(object sender, EventArgs e)
        {

        }

        private void btnByType_Click(object sender, EventArgs e)
        {

        }
    }
}
