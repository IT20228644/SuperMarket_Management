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

namespace SuperMarket_Management_Syatem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string SellerName = "";

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3B3RLIP\SQLEXPRESS;Initial Catalog=SuperMarktDB;Integrated Security=True");


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            SellerUserNameTb.Text = "";
            SellerPasswordTb.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(SellerUserNameTb.Text == "" || SellerPasswordTb.Text == "" )
            {
                MessageBox.Show("Enter Username & Password");
            }
            else
            {
                if(CbUserRole.SelectedIndex > -1)
                {
                    if (CbUserRole.SelectedItem.ToString() == "ADMIN")
                    {
                        if (SellerUserNameTb.Text == "Admin" && SellerPasswordTb.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show(); 
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the admin, Please enter your Corrrect ID & Password!");
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Seller Section");
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from SellerTbl where SellerName='" + SellerUserNameTb.Text+ "'and SellerPass='" +SellerPasswordTb.Text+ "'", Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            SellerName = SellerUserNameTb.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password");
                        }
                        Con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role");
                }
            }
        }
    }
}
