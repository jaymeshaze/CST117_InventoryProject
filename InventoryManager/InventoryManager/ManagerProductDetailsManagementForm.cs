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
using System.IO;


namespace InventoryManager
{
    public partial class ProductDetailsManager : Form
    {
        public ProductDetailsManager()
        {
            InitializeComponent();
        }

        public string searchquery;

        OpenFileDialog Browse = new OpenFileDialog();
        string imgPath;
        string imgFileName;
        int ParsedValue;
        SqlConnection Prod_List_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");

        private void UpdateUser_Load(object sender, EventArgs e)
        {


            if (searchquery == "*")
            {
                Prod_List_Con.Open();
                SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                DataTable ProdList_DT = new DataTable();
                ProdList_SDA.Fill(ProdList_DT);
                BindingSource ProdList_BS = new BindingSource();
                ProdList_BS.DataSource = ProdList_DT;
                viewProductList.DataSource = ProdList_BS;
                viewProductList.Show();
                Prod_List_Con.Close();
            }
            else
            {
                SqlConnection Prod_List_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30");
                Prod_List_Con.Open();
                SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null and Title like '%" + searchquery +  "%'", Prod_List_Con);
                DataTable ProdList_DT = new DataTable();
                ProdList_SDA.Fill(ProdList_DT);
                BindingSource ProdList_BS = new BindingSource();
                ProdList_BS.DataSource = ProdList_DT;
                viewProductList.DataSource = ProdList_BS;
                viewProductList.Show();
                Prod_List_Con.Close();
            }
        }
        private void btnImgBrowse_Click(object sender, EventArgs e)
        {
            Browse.InitialDirectory = "c:\\";
            Browse.Filter = "Image Files (*.PNG; *.JPG)| *.PNG; *.JPG | All files(*.*) | *.*";
            Browse.FilterIndex = 2;

            if (Browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Browse.CheckFileExists)
                {
                    imgPath = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 9));
                    imgFileName = System.IO.Path.GetFileName(Browse.FileName);
                    txtbx_imgPath.Text = @"\Resources\IMG_TEST\" + imgFileName;
                }
            }
        }

        private void btnPreviousMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            ProductSearch ProductSearch = new ProductSearch();
            ProductSearch.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreen ss = new LoginScreen();
            ss.Show();
        }

        private void viewProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                //determines row selected for update
                DataGridViewRow row = this.viewProductList.Rows[e.RowIndex];

                //places values for selected records in form for update
                lbl_ItemID.Text = row.Cells["Item ID"].Value.ToString();
                txtbx_Title.Text = row.Cells["Title"].Value.ToString();
                rtxtbx_Details.Text = row.Cells["Details"].Value.ToString();
                txtbx_imgPath.Text = row.Cells["Image"].Value.ToString();
                txtbx_Price.Text = row.Cells["Price"].Value.ToString();
                txtbx_salePrice.Text = row.Cells["Sale Price"].Value.ToString();
                txtbx_Brand.Text = row.Cells["Brand"].Value.ToString();
                txtbx_Type.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //nested if statements to check for any blank or unselected fields
            if (String.IsNullOrEmpty(txtbx_Title.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please enter an Item Title");
            }
            else if (String.IsNullOrEmpty(rtxtbx_Details.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please enter Item Details");
            }
            else if (String.IsNullOrEmpty(txtbx_Type.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please eneter a Type");
            }
            else if (String.IsNullOrEmpty(txtbx_Brand.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please enter a Brand");
            }
            else if (String.IsNullOrEmpty(txtbx_Price.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please enter a price");
            }
            else if (!int.TryParse(txtbx_Price.Text, out ParsedValue))
            {
                //error message if new item form is incomplete
                MessageBox.Show("Please enter a currency value for price");
            }
            else if (!String.IsNullOrEmpty(txtbx_salePrice.Text) && !int.TryParse(txtbx_salePrice.Text, out ParsedValue))
            {
                //error message if sale price is not a number value
                MessageBox.Show("Please enter a currency value for sale price");
            }
            else if (!String.IsNullOrEmpty(txtbx_imgPath.Text))
            {
                if (Browse.FileName.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
                {
                    //error message if new item img selection is invalid
                    MessageBox.Show("Image or File selected is invalid");
                }
                else
                {
                    Prod_List_Con.Open();
                    if (txtbx_salePrice.Text == "")
                    {
                        //update sql command
                        SqlCommand UpdateDetailsCMD = new SqlCommand("update Main_Inventory set Title = '" + txtbx_Title.Text + "',Details='" + rtxtbx_Details.Text + "',Image='" + txtbx_imgPath.Text + "',Price='" + txtbx_Price.Text + "',P_Price = null,Brand='" + txtbx_Brand.Text + "',Type='" + txtbx_Type.Text + "'where Id='" + lbl_ItemID.Text + "'", Prod_List_Con);
                        //command executed
                        UpdateDetailsCMD.ExecuteNonQuery();
                        //image copied to folder
                        if (File.Exists(imgPath + @"\Resources\IMG_TEST\" + imgFileName))
                        {
                            File.Delete(imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            //user added confirmed
                            MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                            SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                            DataTable ProdList_DT = new DataTable();
                            ProdList_SDA.Fill(ProdList_DT);
                            BindingSource ProdList_BS = new BindingSource();
                            ProdList_BS.DataSource = ProdList_DT;
                            viewProductList.DataSource = ProdList_BS;
                            viewProductList.Show();
                            Prod_List_Con.Close();
                        }
                        else
                        {
                            File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            //user added confirmed
                            MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                            SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                            DataTable ProdList_DT = new DataTable();
                            ProdList_SDA.Fill(ProdList_DT);
                            BindingSource ProdList_BS = new BindingSource();
                            ProdList_BS.DataSource = ProdList_DT;
                            viewProductList.DataSource = ProdList_BS;
                            viewProductList.Show();
                            Prod_List_Con.Close();
                        }
                    }
                    else
                    {
                        //update sql command
                        SqlCommand UpdateDetailsCMD = new SqlCommand("update Main_Inventory set Title = '" + txtbx_Title.Text + "',Details='" + rtxtbx_Details.Text + "',Image='" + txtbx_imgPath.Text + "',Price='" + txtbx_Price.Text + "',P_Price ='" + txtbx_salePrice.Text + "',Brand='" + txtbx_Brand.Text + "',Type='" + txtbx_Type.Text + "'where Id='" + lbl_ItemID.Text + "'", Prod_List_Con);
                        //command executed
                        UpdateDetailsCMD.ExecuteNonQuery();
                        //image copied to folder
                        if (File.Exists(imgPath + @"\Resources\IMG_TEST\" + imgFileName))
                        {
                            File.Delete(imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            //user added confirmed
                            MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                            SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                            DataTable ProdList_DT = new DataTable();
                            ProdList_SDA.Fill(ProdList_DT);
                            BindingSource ProdList_BS = new BindingSource();
                            ProdList_BS.DataSource = ProdList_DT;
                            viewProductList.DataSource = ProdList_BS;
                            viewProductList.Show();
                            Prod_List_Con.Close();
                        }
                        else
                        {
                            File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                            //user added confirmed
                            MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                            SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                            DataTable ProdList_DT = new DataTable();
                            ProdList_SDA.Fill(ProdList_DT);
                            BindingSource ProdList_BS = new BindingSource();
                            ProdList_BS.DataSource = ProdList_DT;
                            viewProductList.DataSource = ProdList_BS;
                            viewProductList.Show();
                            Prod_List_Con.Close();
                        }
                    }
                }
            }
            else
            {
                Prod_List_Con.Open();
                if (txtbx_salePrice.Text == "")
                {
                    //update sql command
                    SqlCommand UpdateDetailsCMD = new SqlCommand("update Main_Inventory set Title = '" + txtbx_Title.Text + "',Details='" + rtxtbx_Details.Text + "',Image= null,Price='" + txtbx_Price.Text + "',P_Price = null,Brand='" + txtbx_Brand.Text + "',Type='" + txtbx_Type.Text + "'where Id='" + lbl_ItemID.Text + "'", Prod_List_Con);
                    //command executed
                    UpdateDetailsCMD.ExecuteNonQuery();
                    //successful update message
                    MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                    SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                    DataTable ProdList_DT = new DataTable();
                    ProdList_SDA.Fill(ProdList_DT);
                    BindingSource ProdList_BS = new BindingSource();
                    ProdList_BS.DataSource = ProdList_DT;
                    viewProductList.DataSource = ProdList_BS;
                    viewProductList.Show();
                    Prod_List_Con.Close();
                }
                else
                {
                    //update sql command
                    SqlCommand UpdateDetailsCMD = new SqlCommand("update Main_Inventory set Title = '" + txtbx_Title.Text + "',Details='" + rtxtbx_Details.Text + "',Image = null,Price='" + txtbx_Price.Text + "',P_Price ='" + txtbx_salePrice.Text + "',Brand='" + txtbx_Brand.Text + "',Type='" + txtbx_Type.Text + "'where Id='" + lbl_ItemID.Text + "'", Prod_List_Con);
                    //command executed
                    UpdateDetailsCMD.ExecuteNonQuery();
                    //successful update message
                    MessageBox.Show("Item " + txtbx_Title.Text + " was successfully updated!!!");
                    SqlDataAdapter ProdList_SDA = new SqlDataAdapter("select  Id as 'Item ID',Title,Details,Image,Price,P_Price as 'Sale Price',Brand,Type from Main_Inventory where Date_Out is null ", Prod_List_Con);
                    DataTable ProdList_DT = new DataTable();
                    ProdList_SDA.Fill(ProdList_DT);
                    BindingSource ProdList_BS = new BindingSource();
                    ProdList_BS.DataSource = ProdList_DT;
                    viewProductList.DataSource = ProdList_BS;
                    viewProductList.Show();
                    Prod_List_Con.Close();
                }
            }
        }
    }
}
