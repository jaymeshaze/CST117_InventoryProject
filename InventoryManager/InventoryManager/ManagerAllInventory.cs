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
    public partial class AllInventory: Form
    {
        public AllInventory()
        {
            InitializeComponent();
        }

        

        private void AllInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager InventoryManager = new InventoryManager();
            InventoryManager.Show();
        }

        private void btnByBrand_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by brand");
        }

        private void btnByItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by item");

        }

        private void btnByType_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Will sort inventory by type");
        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
    }
}
