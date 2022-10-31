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
    public partial class CategotyForm : Form
    {
        public CategotyForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3B3RLIP\SQLEXPRESS;Initial Catalog=SuperMarktDB;Integrated Security=True");
        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into CategoryTbl values(" + CatIDTb.Text + ", '" + CatNameTb.Text + "', '" + CatDescriptionTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully!");
                Con.Close();
                populate();

                CatIDTb.Text = "";
                CatNameTb.Text = "";
                CatDescriptionTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "Select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoryDesGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategotyForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CategoryDesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIDTb.Text = CategoryDesGridView.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CategoryDesGridView.SelectedRows[0].Cells[1].Value.ToString();
            CatDescriptionTb.Text = CategoryDesGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnNavProduct_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void btnNavSeller_Click(object sender, EventArgs e)
        {
            SellerForm cat = new SellerForm();
            cat.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIDTb.Text == "")
                {
                    MessageBox.Show("Select the category to delete!");
                }
                else
                {
                    Con.Open();
                    String query = "delete from CategoryTbl where CatId=" + CatIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully!");
                    Con.Close();
                    populate();

                    CatIDTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescriptionTb.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIDTb.Text=="" || CatNameTb.Text=="" || CatDescriptionTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + CatNameTb.Text + "',CatDesc='" + CatDescriptionTb.Text + "' where CatID=" + CatIDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();

                    CatIDTb.Text = "";
                    CatNameTb.Text = "";
                    CatDescriptionTb.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
}
