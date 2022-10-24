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

        private void SellingForm_Load(object sender, EventArgs e)
        {
            populate();
        }

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

                Amountlbl.Text = "Rs " + GrdTotal;
            }
            
        }
    }
}
