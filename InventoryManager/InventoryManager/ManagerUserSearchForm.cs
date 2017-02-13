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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
        {
            InitializeComponent();
        }
        SqlConnection Emp_List_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            Emp_List_Con.Open();
            SqlDataAdapter UserList_SDA = new SqlDataAdapter("select  Id as 'Employee ID',fName as 'First Name',lName as 'Last Name',Title,Username,Password from Emp_List", Emp_List_Con);
            DataTable UserList_DT = new DataTable();
            UserList_SDA.Fill(UserList_DT);
            BindingSource UserList_BS = new BindingSource();
            UserList_BS.DataSource = UserList_DT;
            viewUserList.DataSource = UserList_BS;
            viewUserList.Show();
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            Emp_List_Con.Close();
            this.Close();
            UserManagement UserManagement = new UserManagement();
            UserManagement.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Emp_List_Con.Close();
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void viewUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //determines row selected for update
                DataGridViewRow row = this.viewUserList.Rows[e.RowIndex];

                //places values for selected records in form for update
                lbl_EmpID.Text = row.Cells["Employee ID"].Value.ToString();
                txtbx_fName.Text = row.Cells["First Name"].Value.ToString();
                txtbx_lName.Text = row.Cells["Last Name"].Value.ToString();
                comboBox_Title.Text = row.Cells["Title"].Value.ToString();
                txtbx_Username.Text = row.Cells["Username"].Value.ToString();
                txtbx_Password.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void txtbx_fName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_lName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Title_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update sql command
            SqlCommand UpdateUserCMD = new SqlCommand("update Emp_List set fName = '" + txtbx_fName.Text + "',lName='" + txtbx_lName.Text + "',Title='" + comboBox_Title.SelectedItem + "',Username='" + txtbx_Username.Text + "',Password='" + txtbx_Password.Text + "'where Id='" + lbl_EmpID.Text + "'", Emp_List_Con);
            //command executed
            UpdateUserCMD.ExecuteNonQuery();
            //successful update confirmation message
            MessageBox.Show("User " + txtbx_fName.Text + txtbx_lName.Text + " was successfully updated!!!");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //delete sql command
            SqlCommand DeleteUserCMD = new SqlCommand("delete from Emp_List where Id='" + lbl_EmpID.Text + "'", Emp_List_Con);
            //command executed
            DeleteUserCMD.ExecuteNonQuery();
            //successful update confirmation message
            MessageBox.Show("User Deleted!!!");
        }
    }
}
