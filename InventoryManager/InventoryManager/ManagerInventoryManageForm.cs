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

        

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllInventory AllInventory = new AllInventory();
            AllInventory.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Analytics Analytics = new Analytics();
            Analytics.Show();
        }

        private void btnManageDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductSearch ProductSearch = new ProductSearch();
            ProductSearch.Show();
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockControl StockControl = new StockControl();
            StockControl.Show();
        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Hide();
            ManagerScreen screen1 = new ManagerScreen();
            screen1.Show();
        }
    }
}
