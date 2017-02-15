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
    public partial class CustomerSearch : Form
    {

        SqlConnection Inv_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\T2G_MainDB.mdf;Integrated Security=True");
        

        public CustomerSearch()
        {
            InitializeComponent();
            Inv_con.Open();
        }

        private void CUST_SRCH_ALL_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel1.Visible = false;
            panel2.Visible = true;

            SqlDataAdapter GameList_SDA = new SqlDataAdapter("select Title, Type from Main_Inventory", Inv_con);
            DataTable GameList_DT = new DataTable();
            GameList_SDA.Fill(GameList_DT);
            BindingSource GameList_BS = new BindingSource();
            GameList_BS.DataSource = GameList_DT;
            viewGameList.DataSource = GameList_BS;
            viewGameList.Show();

        }

        private void CUST_SRCH_BOX_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel1.Visible = false;
            panel2.Visible = true;

            String userSearchString = CustomerSearchBox.Text;

            SqlDataAdapter SearchList_SDA = new SqlDataAdapter("select Title, Type from Main_Inventory where lower(Title) like lower('%" + userSearchString + "%')", Inv_con);
            DataTable SearchList_DT = new DataTable();
            SearchList_SDA.Fill(SearchList_DT);
            BindingSource SearchList_BS = new BindingSource();
            SearchList_BS.DataSource = SearchList_DT;
            viewGameList.DataSource = SearchList_BS;
            viewGameList.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Inv_con.Close();
            this.Hide();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
            panel1.Visible = true;
        }

        private void viewGameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.viewGameList.Rows[e.RowIndex];

            //places values for selected records in form for update
            gameName_Lbl.Text = row.Cells["Title"].Value.ToString();
            gamePlatform_Lbl.Text = row.Cells["Type"].Value.ToString();
        }
    }
}
