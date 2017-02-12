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
    public partial class ProductSearch: Form
    {
        public ProductSearch()
        {
            InitializeComponent();
        }

        private void ProductSearchBoxButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductDetailsManager ProductDetailsManager = new ProductDetailsManager();
            ProductDetailsManager.searchquery = ProductSearchBox.Text;
            ProductDetailsManager.Show();
        }

        private void ProductSearchAllButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductDetailsManager ProductDetailsManager = new ProductDetailsManager();
            ProductDetailsManager.searchquery = "*";
            ProductDetailsManager.Show();
        }

        

        private void ProductSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {

        }

        private void returnClick(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManager form1 = new InventoryManager();
            form1.Show();
        }
    }
}
