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
        
        private void NewItem_Load(object sender, EventArgs e)
        {

        }

        private void btnImgBrowse_Clicked(object sender, EventArgs e)
        {
            Browse.InitialDirectory = "c:\\";
            Browse.Filter = "Image Files (*.PNG; *.JPG)| *.PNG; *.JPG | All files(*.*) | *.*";
            Browse.FilterIndex = 1;

            if(Browse.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(Browse.CheckFileExists)
                {
                    imgPath = Application.StartupPath.Substring(0,(Application.StartupPath.Length - 9));
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
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(rtxtbx_Details.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_Type.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_Brand.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
            }
            else if (String.IsNullOrEmpty(txtbx_Price.Text))
            {
                //error message if new item form is incomplete
                MessageBox.Show("1 or more fields were left blank, Please complete the form!");
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
                System.IO.File.Copy(Browse.FileName, imgPath + @"\Resources\IMG_TEST\" + imgFileName);
                //user added confirmed
                MessageBox.Show("User Has Been Added Successfuflly!");
                Inventory_Con.Close();
                this.Close();
            }
        }
    }
}
