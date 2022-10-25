using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperMarket_Management_Syatem
{
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3B3RLIP\SQLEXPRESS;Initial Catalog=SuperMarktDB;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Datelbl.Text = DateTime.Today.Day.ToString() + ":" + DateTime.Today.Month.ToString() + ":" + DateTime.Today.Year.ToString()
            Datelbl.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }

        private void populate()
        {
            Con.Open();
            string query = "Select ProdName,ProdPrice from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellingGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populateBill()
        {
            Con.Open();
            string query = "Select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BilldataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
            populateBill();
            fillCombo();
        }

        int flag = 0;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SellingGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdNameTb.Text = SellingGridView.SelectedRows[0].Cells[0].Value.ToString();
            ProdPriceTb.Text = SellingGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Datelbl_Click(object sender, EventArgs e)
        {

        }

        int GrdTotal = 0, n = 0;

        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            if(BillIDTb.Text == "")
            {
                MessageBox.Show("Missing Bill ID !");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Insert into BillTbl values(" + BillIDTb.Text + ", '" + sellerlbl.Text + "', '" + Datelbl.Text + "', '" + Amountlbl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Added Successfully!");
                    Con.Close();
                    populateBill();

                    BillIDTb.Text = "";
                    Amountlbl.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPrintSelling_Click(object sender, EventArgs e)
        {
            if(printPreviewDialogSelling1.ShowDialog() == DialogResult.OK)
            {
                printDocumentSelling1.Print();
            }
        }

        private void BilldataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flag =  1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILY SUPERMARKET", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(300,60));
            e.Graphics.DrawString("Bill ID : " + BilldataGridView.SelectedRows[0].Cells[0].Value.ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(70,120));
            e.Graphics.DrawString("Seller Name: " + BilldataGridView.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(70,145));
            e.Graphics.DrawString("Date : " + BilldataGridView.SelectedRows[0].Cells[2].Value.ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(70,170));
            e.Graphics.DrawString("Total Amount : " + BilldataGridView.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(70,195));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
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
            //ddlProdCategory.ValueMember = "CatName";
            //ddlProdCategory.DataSource = dt;
            Con.Close();

        }

        private void comboBox2_Selection_ChangeCommited(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select ProdName, ProdQty from ProductTbl where ProdCat='" + ddlProdCategory.SelectedValue.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SellingGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnAddProductSelling_Click(object sender, EventArgs e)
        {
            if (ProdNameTb.Text == "" || ProdQtyTb.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int total = Convert.ToInt32(ProdPriceTb.Text) * Convert.ToInt32(ProdQtyTb.Text);
               
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderGridTopRightSelling);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ProdNameTb.Text;
                newRow.Cells[2].Value = ProdPriceTb.Text;
                newRow.Cells[3].Value = ProdQtyTb.Text;
                newRow.Cells[4].Value = Convert.ToInt32(ProdPriceTb.Text) * Convert.ToInt32(ProdQtyTb.Text);
                OrderGridTopRightSelling.Rows.Add(newRow);
                n++;

                GrdTotal = GrdTotal + total;

                Amountlbl.Text =  "" + GrdTotal;

                ProdNameTb.Text = "";
                ProdPriceTb.Text = "";
                ProdQtyTb.Text = "";
            }
            
        }
    }
}
