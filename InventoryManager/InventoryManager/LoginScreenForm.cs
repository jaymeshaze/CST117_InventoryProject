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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LOGIN_BUTTON_Click(object sender, EventArgs e)
        {
           
            string login = UsernameTextField.Text;
            switch (login)
            {
                case "Guest":
                    this.Hide();
                    CustomerSearch openForm1 = new CustomerSearch();
                    openForm1.Show();
                    break;
                case "Employee":
                    this.Hide();
                    EmployeeScreen openForm2 = new EmployeeScreen();
                    openForm2.Show();
                    break;
                case "Manager":
                    this.Hide();
                    ManagerScreen openForm3 = new ManagerScreen();
                    openForm3.Show();
                    break;
                default:
                    break;
            }

        }

        private void exitEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
