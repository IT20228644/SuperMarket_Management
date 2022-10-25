
namespace SuperMarket_Management_Syatem
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Datelbl = new System.Windows.Forms.Label();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ddlProdCategory = new System.Windows.Forms.ComboBox();
            this.ProdPriceTb = new System.Windows.Forms.MaskedTextBox();
            this.ProdQtyTb = new System.Windows.Forms.MaskedTextBox();
            this.ProdNameTb = new System.Windows.Forms.MaskedTextBox();
            this.ProdIDTb = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNavSeller = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.ProductsDataGridView);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ddlProdCategory);
            this.panel1.Controls.Add(this.ProdPriceTb);
            this.panel1.Controls.Add(this.ProdQtyTb);
            this.panel1.Controls.Add(this.ProdNameTb);
            this.panel1.Controls.Add(this.ProdIDTb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnEditProducts);
            this.panel1.Controls.Add(this.btnAddProducts);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnDeleteProducts);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 555);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Datelbl
            // 
            this.Datelbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Navy;
            this.Datelbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Datelbl.Location = new System.Drawing.Point(576, 17);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(56, 26);
            this.Datelbl.TabIndex = 21;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.ProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDataGridView.ColumnHeadersHeight = 18;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsDataGridView.EnableHeadersVisualStyles = false;
            this.ProductsDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsDataGridView.Location = new System.Drawing.Point(310, 58);
            this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.RowTemplate.Height = 24;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(537, 480);
            this.ProductsDataGridView.TabIndex = 20;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(310, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 25);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Select Category";
            // 
            // ddlProdCategory
            // 
            this.ddlProdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProdCategory.FormattingEnabled = true;
            this.ddlProdCategory.Location = new System.Drawing.Point(145, 185);
            this.ddlProdCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ddlProdCategory.Name = "ddlProdCategory";
            this.ddlProdCategory.Size = new System.Drawing.Size(129, 25);
            this.ddlProdCategory.TabIndex = 18;
            this.ddlProdCategory.Text = "Select Category";
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdPriceTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdPriceTb.Location = new System.Drawing.Point(145, 142);
            this.ProdPriceTb.Margin = new System.Windows.Forms.Padding(2);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(129, 26);
            this.ProdPriceTb.TabIndex = 17;
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdQtyTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdQtyTb.Location = new System.Drawing.Point(145, 101);
            this.ProdQtyTb.Margin = new System.Windows.Forms.Padding(2);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(129, 26);
            this.ProdQtyTb.TabIndex = 17;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdNameTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdNameTb.Location = new System.Drawing.Point(145, 58);
            this.ProdNameTb.Margin = new System.Windows.Forms.Padding(2);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(129, 26);
            this.ProdNameTb.TabIndex = 17;
            // 
            // ProdIDTb
            // 
            this.ProdIDTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdIDTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdIDTb.Location = new System.Drawing.Point(145, 21);
            this.ProdIDTb.Margin = new System.Windows.Forms.Padding(2);
            this.ProdIDTb.Name = "ProdIDTb";
            this.ProdIDTb.Size = new System.Drawing.Size(129, 26);
            this.ProdIDTb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(22, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "CATEGORY";
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditProducts.FlatAppearance.BorderSize = 0;
            this.btnEditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEditProducts.Location = new System.Drawing.Point(106, 238);
            this.btnEditProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(79, 35);
            this.btnEditProducts.TabIndex = 0;
            this.btnEditProducts.Text = "EDIT";
            this.btnEditProducts.UseVisualStyleBackColor = false;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddProducts.Location = new System.Drawing.Point(27, 238);
            this.btnAddProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(75, 35);
            this.btnAddProducts.TabIndex = 0;
            this.btnAddProducts.Text = "ADD";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(448, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 26);
            this.button4.TabIndex = 0;
            this.button4.Text = "REFRESH";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteProducts.FlatAppearance.BorderSize = 0;
            this.btnDeleteProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProducts.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProducts.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteProducts.Location = new System.Drawing.Point(190, 238);
            this.btnDeleteProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(83, 35);
            this.btnDeleteProducts.TabIndex = 0;
            this.btnDeleteProducts.Text = "DELETE";
            this.btnDeleteProducts.UseVisualStyleBackColor = false;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(22, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "PRICE";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "QUANTITY";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(430, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "MANAGE PRODUCTS";
            // 
            // btnNavSeller
            // 
            this.btnNavSeller.FlatAppearance.BorderSize = 0;
            this.btnNavSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSeller.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSeller.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavSeller.Location = new System.Drawing.Point(2, 77);
            this.btnNavSeller.Margin = new System.Windows.Forms.Padding(2);
            this.btnNavSeller.Name = "btnNavSeller";
            this.btnNavSeller.Size = new System.Drawing.Size(94, 36);
            this.btnNavSeller.TabIndex = 0;
            this.btnNavSeller.Text = "SELLER";
            this.btnNavSeller.UseVisualStyleBackColor = true;
            this.btnNavSeller.Click += new System.EventHandler(this.btnNavSeller_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(8, 118);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "CATEGORY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnNavCategory_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(6, 158);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 36);
            this.button6.TabIndex = 0;
            this.button6.Text = "SELLING";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(959, 10);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 36);
            this.button8.TabIndex = 22;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Earth Orbiter Extra-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Green;
            this.btnMinimize.Location = new System.Drawing.Point(931, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(28, 36);
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 639);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNavSeller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNavSeller;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.MaskedTextBox ProdPriceTb;
        private System.Windows.Forms.MaskedTextBox ProdQtyTb;
        private System.Windows.Forms.MaskedTextBox ProdNameTb;
        private System.Windows.Forms.MaskedTextBox ProdIDTb;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox ddlProdCategory;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Label Datelbl;
    }
}