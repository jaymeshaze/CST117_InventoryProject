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

        private void UsernameTextField_Leave(object sender, EventArgs e)
        {

            if (UsernameTextField.Text == "")
            {
                UsernameTextField.Text = "username";
            }
        }

        private void UsernameTextField_Enter(object sender, EventArgs e)
        {
            if (UsernameTextField.Text == "username")
            {
                UsernameTextField.Text = "";
            }
        }

        private void UsernameTextField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LOGIN_BUTTON_Click(this, new EventArgs());
            }
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
                    MessageBox.Show("Incorrect Username: Please enter one of the flowwing Guest, Employee, Manager...case sensitive");
                    break;
            }

        }

        private void exitEvent(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            MessageBox.Show("the Password will not change, but you will need to enter one of 3 usernames, each taking you to a different instance of the application:  Guest, Employee, Manager...case sensitive");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
