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
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        OpenFileDialog Browse = new OpenFileDialog();
        string imgPath;
        string imgFileName;
        int ParsedValue;


        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void btnImgBrowse_Clicked(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
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
                //error message if new price is not a number
                MessageBox.Show("Please enter a currency value for price");
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
                    //opening connection with inventory table in database
                    SqlConnection Inventory_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    Inventory_Con.Open();
                    //insert data command
                    SqlCommand NewItemCMD = new SqlCommand("Insert Into Main_Inventory(Title,Details,Image,Type,Brand,Price,Date_In) Values('" + txtbx_Title.Text + "','" + rtxtbx_Details.Text + "','" + txtbx_imgPath.Text + "','" + txtbx_Type.Text + "','" + txtbx_Brand.Text + "','" + txtbx_Price.Text + "',GETDATE())", Inventory_Con);
                    //SqlCommand executed
                    NewItemCMD.ExecuteNonQuery();
                    //image copied to folder
                    if (File.Exists(imgPath + @"\Resources\IMG_TEST\" + imgFileName))
                    {
                        File.Delete(imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                        File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                        //user added confirmed
                        MessageBox.Show("User Has Been Added Successfuflly!");
                        Inventory_Con.Close();
                        this.Close();
                    }
                    else
                    {
                        File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                        //user added confirmed
                        MessageBox.Show("User Has Been Added Successfuflly!");
                        Inventory_Con.Close();
                        this.Close();
                    }
                }
            }
            else
            {
                //opening connection with inventory table in database
                SqlConnection Inventory_Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=T2G_MainDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                Inventory_Con.Open();
                //insert data command
                SqlCommand NewItemCMD = new SqlCommand("Insert Into Main_Inventory(Title,Details,Type,Brand,Price,Date_In) Values('" + txtbx_Title.Text + "','" + rtxtbx_Details.Text + "','" + txtbx_Type.Text + "','" + txtbx_Brand.Text + "','" + txtbx_Price.Text + "',GETDATE())", Inventory_Con);
                //SqlCommand executed
                NewItemCMD.ExecuteNonQuery();
                //user added confirmed
                MessageBox.Show("User Has Been Added Successfuflly!");
                Inventory_Con.Close();
                this.Close();
            }
           
        }
    }
}
