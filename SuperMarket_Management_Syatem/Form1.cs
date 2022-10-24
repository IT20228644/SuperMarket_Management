using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Management_Syatem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

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
            UserNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(UserNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Username & Password");
            }
            else
            {
                if (CbUserRole.SelectedItem.ToString() == "ADMIN")
                {
                    if (UserNameTb.Text == "Admin" && PasswordTb.Text == "Admin")
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
                else if (CbUserRole.SelectedItem.ToString() == "SELLER")
                {
                    MessageBox.Show("Seller Section");
                }
            }
        }
    }
}
