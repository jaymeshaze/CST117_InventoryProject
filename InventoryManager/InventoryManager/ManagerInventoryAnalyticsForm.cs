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
    public partial class Analytics: Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {

        }

        private void btnPopular_Click(object sender, EventArgs e)
        {

        }

        private void btnHighSellers_Click(object sender, EventArgs e)
        {

        }

        private void btnLowSellers_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }
    }
}
