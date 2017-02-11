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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void txtbx_fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_lName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Title_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //nested if statements to check for any blank or unselected fields
            if (String.IsNullOrEmpty(txtbx_fName.Text))
            {
                //error message if new user form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_lName.Text))
            {
                //error message if new user form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (comboBox_Title.SelectedItem == null)
            {
                //error message if new user form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_Username.Text))
            {
                //error message if new user form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_Password.Text))
            {
                //error message if new user form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else
            {
                //opening connection with employee table in database
                SqlConnection Emp_List_Con = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = T2G_MainDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                Emp_List_Con.Open();
                //insert data command
                SqlCommand NewUserCMD = new SqlCommand("Insert Into Emp_List(fName,lName,Title,Username,Password) Values('" + txtbx_fName.Text + "','" + txtbx_lName.Text + "','" + comboBox_Title.SelectedItem + "','" + txtbx_Username.Text + "','" + txtbx_Password.Text + "')", Emp_List_Con);
                //SqlCommand executed
                NewUserCMD.ExecuteNonQuery();
                //user added confirmed
                MessageBox.Show("User Has Been Added Successfuflly!");
                Emp_List_Con.Close();
                this.Close();
            }
        }

        
    }
}
