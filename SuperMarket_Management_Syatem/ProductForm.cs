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
    public partial class ProductForm : Form
    {
        public ProductForm()
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

        private void fillCombo()
        {
            //blind the combobox with database
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatName from CategoryTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            ddlProdCategory.ValueMember = "CatName";
            ddlProdCategory.DataSource = dt;
            Con.Close();

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillCombo();
            populate();
        }

        private void btnNavCategory_Click(object sender, EventArgs e)
        {
            CategotyForm cat = new CategotyForm();
            cat.Show();
            this.Hide();
        }
        private void btnNavSeller_Click(object sender, EventArgs e)
        {
            SellerForm cat = new SellerForm();
            cat.Show();
            this.Hide();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ProductTbl values(" + ProdIDTb.Text + ", '" + ProdNameTb.Text + "', '" + ProdQtyTb.Text + "', '" + ProdPriceTb.Text + "', '" + ddlProdCategory.SelectedValue.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully!");
                Con.Close();
                populate();

                ProdIDTb.Text = "";
                ProdNameTb.Text = "";
                ProdQtyTb.Text = "";
                ProdPriceTb.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populate()
        {
            Con.Open();
            string query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIDTb.Text = ProductsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProdNameTb.Text = ProductsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            ProdQtyTb.Text = ProductsDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            ProdPriceTb.Text = ProductsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIDTb.Text == "" || ProdNameTb.Text == "" || ProdPriceTb.Text == "" || ProdQtyTb.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update ProductTbl set ProdName='" + ProdNameTb.Text + "',ProdQty='" + ProdQtyTb.Text + "',ProdPrice='" + ProdPriceTb.Text + "',ProductCat='" + ddlProdCategory.SelectedValue + "' where ProdId=" + ProdIDTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();

                    ProdIDTb.Text = "";
                    ProdNameTb.Text = "";
                    ProdQtyTb.Text = "";
                    ProdPriceTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProdIDTb.Text == "")
                {
                    MessageBox.Show("Select product to delete!");
                }
                else
                {
                    Con.Open();
                    String query = "delete from ProductTbl where ProdID=" + ProdIDTb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully!");
                    Con.Close();
                    populate();

                    ProdIDTb.Text = "";
                    ProdNameTb.Text = "";
                    ProdQtyTb.Text = "";
                    ProdPriceTb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        private void ddlProdCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
    }
    
}

