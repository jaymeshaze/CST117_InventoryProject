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

        }

        private void ProductSearchAllButton_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void ProductSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
