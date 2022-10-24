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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3B3RLIP\SQLEXPRESS;Initial Catalog=SuperMarktDB;Integrated Security=True");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnNavSeller_Click(object sender, EventArgs e)
        {
            CategotyForm cat = new CategotyForm();
            cat.Show();
            this.Hide();
        }

        private void btnNavCategory_Click(object sender, EventArgs e)
        {
            CategotyForm cat = new CategotyForm();
            cat.Show();
            this.Hide();
        }

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            ProductForm cat = new ProductForm();
            cat.Show();
            this.Hide();
        }

        private void populate()
        {
            Con.Open();
            string query = "Select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellersDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into SellerTbl values(" + SellerIDTb.Text + ", '" + SellerNameTb.Text + "', '" + SellerAgeTb.Text + "', '" + SellerPhoneTb.Text + "', '" + SellerPasswordTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully!");
                Con.Close();
                populate();

                SellerIDTb.Text = "";
                SellerNameTb.Text = "";
                SellerAgeTb.Text = "";
                SellerPhoneTb.Text = "";
                SellerPasswordTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIDTb.Text == "" || SellerNameTb.Text == "" || SellerAgeTb.Text == "" || SellerPhoneTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + SellerNameTb.Text + "',SellerAge='" + SellerAgeTb.Text + "',SellerPhone='" + SellerPhoneTb.Text + "' where SellerId=" + SellerIDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    populate();

                    SellerIDTb.Text = "";
                    SellerNameTb.Text = "";
                    SellerAgeTb.Text = "";
                    SellerPhoneTb.Text = "";
                    SellerPasswordTb.Text = "";

                    SellerPasswordTb.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellerIDTb.Text == "")
                {
                    MessageBox.Show("Select Seller to delete!");
                }
                else
                {
                    Con.Open();
                    String query = "delete from SellerTbl where SellerId=" + SellerIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully!");
                    Con.Close();
                    populate();

                    SellerIDTb.Text = "";
                    SellerNameTb.Text = "";
                    SellerAgeTb.Text = "";
                    SellerPhoneTb.Text = "";
                    SellerPasswordTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SellerIDTb.Text = SellersDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            SellerNameTb.Text = SellersDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SellerAgeTb.Text = SellersDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            SellerPhoneTb.Text = SellersDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }
    }
}
