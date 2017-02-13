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
    public partial class StockControl : Form
    {
        public StockControl()
        {
            InitializeComponent();
        }

        private void StockControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            NewItem NewItem = new NewItem();
            NewItem.Show();
        }

        private void btnUploadNew_Click(object sender, EventArgs e)
        {
            UploadStock UploadStock = new UploadStock();
            UploadStock.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockSearch StockSearch = new StockSearch();
            StockSearch.searchquery = "*";
            StockSearch.Show();
        }

        

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
    }
}
