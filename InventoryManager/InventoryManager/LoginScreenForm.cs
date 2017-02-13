using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
    
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
            //connection is made to T2G_MainDB
            SqlConnection Emp_List_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\T2G_MainDB.mdf;Integrated Security=True");
            Emp_List_Con.Open();
            //Query Employee Table verify username and password exists
            SqlCommand UserValidate_command = new SqlCommand("select Username, Password, Title from Emp_List where Username = '" + UsernameTextField.Text + "' and Password = '" + PasswordTextField.Text + "'", Emp_List_Con);
            
            
            /*SqlCommand UserValidate_command = new SqlCommand("select Username, Password, Title from Emp_List where Username = ? and Password = ? ", Emp_List_Con);
            SqlParameter par = new SqlParameter();
            par.ParameterName = "Name";
            par.Value = UsernameTextField.Text;
            par.Parameters.Add(par);
            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "Password";
            par2.Value = PasswordTextField.Text;
            par2.Parameters.Add(par2);*/


            //Query results are read into application
            SqlDataReader UserValidate_reader = UserValidate_command.ExecuteReader();

            //if statement to validate
            if (UserValidate_reader != null)
            {
                //data reader initialized
                if (UserValidate_reader.Read())
                {
                    //check for manager access, if true...manager screen opens
                    if (UserValidate_reader.GetString(2) == "Manager")
                    {
                        this.Hide();
                        ManagerScreen Manager = new ManagerScreen();
                        Manager.Show();
                    }
                    //check for associate access, if true...employee screen opens
                    else if (UserValidate_reader.GetString(2) == "Associate")
                    {
                        this.Hide();
                        EmployeeScreen Associate = new EmployeeScreen();
                        Associate.Show();
                    }
                    //no manager, no associate, guest screen opens
                    else
                    {
                        this.Hide();
                        CustomerSearch Customer = new CustomerSearch();
                        Customer.Show();
                    }
                }
                else
                {
                    //Error message for invalid or non-input username and/ or password from user
                    MessageBox.Show("Username and/or Password are missing or incorrect, Please Try Again.");
                }
            }
            //Close data connection
            Emp_List_Con.Close();
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
