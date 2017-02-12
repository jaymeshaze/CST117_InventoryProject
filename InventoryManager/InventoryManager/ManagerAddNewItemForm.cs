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
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }
        SqlConnection Inv_List_Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Michael\Documents\CST117_InventoryProject\MASTER_DB_2_5_2017\T2G_MainDB.mdf;Integrated Security=True;Connect Timeout=30");
        StockSearch stocksearchform = new StockSearch();
        private void NewItem_Load(object sender, EventArgs e)
        {
            /*Inv_List_Con.Open();
            SqlDataAdapter NewItem_SDA = new SqlDataAdapter();
            DataTable NewItem_DT = new DataTable();
            NewItem_SDA.Fill(NewItem_DT);
            BindingSource NewItem_BS = new BindingSource();
            NewItem_BS.DataSource = NewItem_DT;
            stocksearchform.viewStock.DataSource = NewItem_BS;*/

        }

        private void btnImgBrowse_Clicked(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SqlCommand AddItemCMD = new SqlCommand("insert into Main_Inventory(Title, Details, Image, Price, Brand, Type) values (txtbx_Title.Text, rtxtbx_Details.Text, txtbx_lmgPath, txtbx_Price.Text, txtbx_Brand.Text, txtbx_Type.Text)", Inv_List_Con);
            //AddItemCMD.EndExecuteNonQuery();
            this.Close();
        }
    }
}
