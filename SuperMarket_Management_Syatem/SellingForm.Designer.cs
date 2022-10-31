
namespace SuperMarket_Management_Syatem
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNavSelling = new System.Windows.Forms.Button();
            this.btnNavProducts = new System.Windows.Forms.Button();
            this.btnNavSeller = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BillID2Tb = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BilldataGridView = new System.Windows.Forms.DataGridView();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sellerNamelbl = new System.Windows.Forms.Label();
            this.OrderGridTopRightSelling = new System.Windows.Forms.DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddProductSelling = new System.Windows.Forms.Button();
            this.ddlProdCategory = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SellingGridView = new System.Windows.Forms.DataGridView();
            this.ProdQtyTb = new System.Windows.Forms.MaskedTextBox();
            this.ProdPriceTb = new System.Windows.Forms.MaskedTextBox();
            this.ProdNameTb = new System.Windows.Forms.MaskedTextBox();
            this.BillIDTb = new System.Windows.Forms.MaskedTextBox();
            this.Datelbl = new System.Windows.Forms.Label();
            this.btnPrintSelling = new System.Windows.Forms.Button();
            this.btnAddSelling = new System.Windows.Forms.Button();
            this.btnDeleteSelling = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialogSelling1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentSelling1 = new System.Drawing.Printing.PrintDocument();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridTopRightSelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Earth Orbiter Extra-Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Green;
            this.btnMinimize.Location = new System.Drawing.Point(1259, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 44);
            this.btnMinimize.TabIndex = 31;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1295, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 44);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNavSelling
            // 
            this.btnNavSelling.FlatAppearance.BorderSize = 0;
            this.btnNavSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSelling.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSelling.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavSelling.Location = new System.Drawing.Point(19, 206);
            this.btnNavSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavSelling.Name = "btnNavSelling";
            this.btnNavSelling.Size = new System.Drawing.Size(125, 44);
            this.btnNavSelling.TabIndex = 25;
            this.btnNavSelling.Text = "SELLING";
            this.btnNavSelling.UseVisualStyleBackColor = true;
            this.btnNavSelling.Click += new System.EventHandler(this.btnNavSelling_Click);
            // 
            // btnNavProducts
            // 
            this.btnNavProducts.FlatAppearance.BorderSize = 0;
            this.btnNavProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavProducts.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavProducts.Location = new System.Drawing.Point(21, 156);
            this.btnNavProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavProducts.Name = "btnNavProducts";
            this.btnNavProducts.Size = new System.Drawing.Size(139, 44);
            this.btnNavProducts.TabIndex = 26;
            this.btnNavProducts.Text = "PRODUCTS";
            this.btnNavProducts.UseVisualStyleBackColor = true;
            this.btnNavProducts.Click += new System.EventHandler(this.btnNavProducts_Click);
            // 
            // btnNavSeller
            // 
            this.btnNavSeller.FlatAppearance.BorderSize = 0;
            this.btnNavSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSeller.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSeller.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavSeller.Location = new System.Drawing.Point(13, 106);
            this.btnNavSeller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNavSeller.Name = "btnNavSeller";
            this.btnNavSeller.Size = new System.Drawing.Size(125, 44);
            this.btnNavSeller.TabIndex = 27;
            this.btnNavSeller.Text = "SELLER";
            this.btnNavSeller.UseVisualStyleBackColor = true;
            this.btnNavSeller.Click += new System.EventHandler(this.btnNavSeller_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(496, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 48);
            this.label3.TabIndex = 29;
            this.label3.Text = "SELLING";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.BillID2Tb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BilldataGridView);
            this.panel1.Controls.Add(this.Amountlbl);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.sellerNamelbl);
            this.panel1.Controls.Add(this.OrderGridTopRightSelling);
            this.panel1.Controls.Add(this.btnAddProductSelling);
            this.panel1.Controls.Add(this.ddlProdCategory);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.SellingGridView);
            this.panel1.Controls.Add(this.ProdQtyTb);
            this.panel1.Controls.Add(this.ProdPriceTb);
            this.panel1.Controls.Add(this.ProdNameTb);
            this.panel1.Controls.Add(this.BillIDTb);
            this.panel1.Controls.Add(this.Datelbl);
            this.panel1.Controls.Add(this.btnPrintSelling);
            this.panel1.Controls.Add(this.btnAddSelling);
            this.panel1.Controls.Add(this.btnDeleteSelling);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(179, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 683);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BillID2Tb
            // 
            this.BillID2Tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BillID2Tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillID2Tb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillID2Tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BillID2Tb.Location = new System.Drawing.Point(187, 32);
            this.BillID2Tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillID2Tb.Name = "BillID2Tb";
            this.BillID2Tb.Size = new System.Drawing.Size(171, 20);
            this.BillID2Tb.TabIndex = 30;
            this.BillID2Tb.Visible = false;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(412, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "SALES LIST";
            // 
            // BilldataGridView
            // 
            this.BilldataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.BilldataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle37;
            this.BilldataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BilldataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.BilldataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BilldataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BilldataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BilldataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
            this.BilldataGridView.ColumnHeadersHeight = 18;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BilldataGridView.DefaultCellStyle = dataGridViewCellStyle39;
            this.BilldataGridView.EnableHeadersVisualStyles = false;
            this.BilldataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.BilldataGridView.Location = new System.Drawing.Point(408, 340);
            this.BilldataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BilldataGridView.Name = "BilldataGridView";
            this.BilldataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BilldataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.BilldataGridView.RowHeadersWidth = 51;
            this.BilldataGridView.RowTemplate.Height = 24;
            this.BilldataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BilldataGridView.Size = new System.Drawing.Size(709, 245);
            this.BilldataGridView.TabIndex = 28;
            this.BilldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BilldataGridView_CellContentClick);
            // 
            // Amountlbl
            // 
            this.Amountlbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlbl.ForeColor = System.Drawing.Color.Navy;
            this.Amountlbl.Location = new System.Drawing.Point(995, 246);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(45, 25);
            this.Amountlbl.TabIndex = 27;
            this.Amountlbl.Text = "RS.";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(847, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "AMOUNT RS";
            // 
            // sellerNamelbl
            // 
            this.sellerNamelbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sellerNamelbl.AutoSize = true;
            this.sellerNamelbl.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerNamelbl.ForeColor = System.Drawing.Color.Navy;
            this.sellerNamelbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sellerNamelbl.Location = new System.Drawing.Point(35, 6);
            this.sellerNamelbl.Name = "sellerNamelbl";
            this.sellerNamelbl.Size = new System.Drawing.Size(68, 32);
            this.sellerNamelbl.TabIndex = 25;
            this.sellerNamelbl.Text = "Seller";
            // 
            // OrderGridTopRightSelling
            // 
            this.OrderGridTopRightSelling.AllowUserToResizeRows = false;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.OrderGridTopRightSelling.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle41;
            this.OrderGridTopRightSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridTopRightSelling.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.OrderGridTopRightSelling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGridTopRightSelling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGridTopRightSelling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridTopRightSelling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.OrderGridTopRightSelling.ColumnHeadersHeight = 18;
            this.OrderGridTopRightSelling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGridTopRightSelling.DefaultCellStyle = dataGridViewCellStyle43;
            this.OrderGridTopRightSelling.EnableHeadersVisualStyles = false;
            this.OrderGridTopRightSelling.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderGridTopRightSelling.Location = new System.Drawing.Point(408, 57);
            this.OrderGridTopRightSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderGridTopRightSelling.Name = "OrderGridTopRightSelling";
            this.OrderGridTopRightSelling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridTopRightSelling.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.OrderGridTopRightSelling.RowHeadersWidth = 51;
            this.OrderGridTopRightSelling.RowTemplate.Height = 24;
            this.OrderGridTopRightSelling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridTopRightSelling.Size = new System.Drawing.Size(709, 169);
            this.OrderGridTopRightSelling.TabIndex = 24;
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Prod Name";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // btnAddProductSelling
            // 
            this.btnAddProductSelling.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddProductSelling.FlatAppearance.BorderSize = 0;
            this.btnAddProductSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductSelling.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductSelling.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddProductSelling.Location = new System.Drawing.Point(120, 218);
            this.btnAddProductSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProductSelling.Name = "btnAddProductSelling";
            this.btnAddProductSelling.Size = new System.Drawing.Size(147, 27);
            this.btnAddProductSelling.TabIndex = 23;
            this.btnAddProductSelling.Text = "ADD PRODUCT";
            this.btnAddProductSelling.UseVisualStyleBackColor = false;
            this.btnAddProductSelling.Click += new System.EventHandler(this.btnAddProductSelling_Click);
            // 
            // ddlProdCategory
            // 
            this.ddlProdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProdCategory.FormattingEnabled = true;
            this.ddlProdCategory.Location = new System.Drawing.Point(52, 258);
            this.ddlProdCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlProdCategory.Name = "ddlProdCategory";
            this.ddlProdCategory.Size = new System.Drawing.Size(173, 28);
            this.ddlProdCategory.TabIndex = 21;
            this.ddlProdCategory.Text = "Select Category";
            this.ddlProdCategory.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_Selection_ChangeCommited);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRefresh.Location = new System.Drawing.Point(244, 258);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 28);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // SellingGridView
            // 
            this.SellingGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle45.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.SellingGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle45;
            this.SellingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellingGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.SellingGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SellingGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellingGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
            this.SellingGridView.ColumnHeadersHeight = 18;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellingGridView.DefaultCellStyle = dataGridViewCellStyle47;
            this.SellingGridView.EnableHeadersVisualStyles = false;
            this.SellingGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.SellingGridView.Location = new System.Drawing.Point(37, 302);
            this.SellingGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellingGridView.Name = "SellingGridView";
            this.SellingGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellingGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.SellingGridView.RowHeadersWidth = 51;
            this.SellingGridView.RowTemplate.Height = 24;
            this.SellingGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingGridView.Size = new System.Drawing.Size(320, 362);
            this.SellingGridView.TabIndex = 19;
            this.SellingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingGridView_CellContentClick);
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdQtyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdQtyTb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdQtyTb.Location = new System.Drawing.Point(187, 180);
            this.ProdQtyTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(171, 20);
            this.ProdQtyTb.TabIndex = 17;
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdPriceTb.Enabled = false;
            this.ProdPriceTb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdPriceTb.Location = new System.Drawing.Point(187, 142);
            this.ProdPriceTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(171, 20);
            this.ProdPriceTb.TabIndex = 17;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdNameTb.Enabled = false;
            this.ProdNameTb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdNameTb.Location = new System.Drawing.Point(187, 100);
            this.ProdNameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(171, 20);
            this.ProdNameTb.TabIndex = 17;
            // 
            // BillIDTb
            // 
            this.BillIDTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BillIDTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillIDTb.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIDTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BillIDTb.Location = new System.Drawing.Point(187, 57);
            this.BillIDTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillIDTb.Name = "BillIDTb";
            this.BillIDTb.Size = new System.Drawing.Size(171, 20);
            this.BillIDTb.TabIndex = 17;
            // 
            // Datelbl
            // 
            this.Datelbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Navy;
            this.Datelbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Datelbl.Location = new System.Drawing.Point(713, 10);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(67, 32);
            this.Datelbl.TabIndex = 15;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // btnPrintSelling
            // 
            this.btnPrintSelling.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrintSelling.FlatAppearance.BorderSize = 0;
            this.btnPrintSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSelling.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSelling.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPrintSelling.Location = new System.Drawing.Point(735, 608);
            this.btnPrintSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintSelling.Name = "btnPrintSelling";
            this.btnPrintSelling.Size = new System.Drawing.Size(105, 44);
            this.btnPrintSelling.TabIndex = 0;
            this.btnPrintSelling.Text = "PRINT";
            this.btnPrintSelling.UseVisualStyleBackColor = false;
            this.btnPrintSelling.Click += new System.EventHandler(this.btnPrintSelling_Click);
            // 
            // btnAddSelling
            // 
            this.btnAddSelling.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSelling.FlatAppearance.BorderSize = 0;
            this.btnAddSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSelling.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelling.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAddSelling.Location = new System.Drawing.Point(629, 608);
            this.btnAddSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSelling.Name = "btnAddSelling";
            this.btnAddSelling.Size = new System.Drawing.Size(100, 44);
            this.btnAddSelling.TabIndex = 0;
            this.btnAddSelling.Text = "ADD";
            this.btnAddSelling.UseVisualStyleBackColor = false;
            this.btnAddSelling.Click += new System.EventHandler(this.btnAddSelling_Click);
            // 
            // btnDeleteSelling
            // 
            this.btnDeleteSelling.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteSelling.FlatAppearance.BorderSize = 0;
            this.btnDeleteSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelling.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelling.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDeleteSelling.Location = new System.Drawing.Point(845, 608);
            this.btnDeleteSelling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSelling.Name = "btnDeleteSelling";
            this.btnDeleteSelling.Size = new System.Drawing.Size(111, 44);
            this.btnDeleteSelling.TabIndex = 0;
            this.btnDeleteSelling.Text = "DELETE";
            this.btnDeleteSelling.UseVisualStyleBackColor = false;
            this.btnDeleteSelling.Click += new System.EventHandler(this.btnDeleteSelling_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(32, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "QUANTITY";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(32, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 35);
            this.label6.TabIndex = 15;
            this.label6.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(31, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "PROD. NAME";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "BILL ID";
            // 
            // printPreviewDialogSelling1
            // 
            this.printPreviewDialogSelling1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSelling1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogSelling1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogSelling1.Document = this.printDocumentSelling1;
            this.printPreviewDialogSelling1.Enabled = true;
            this.printPreviewDialogSelling1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogSelling1.Icon")));
            this.printPreviewDialogSelling1.Name = "printPreviewDialogSelling1";
            this.printPreviewDialogSelling1.Visible = false;
            // 
            // printDocumentSelling1
            // 
            this.printDocumentSelling1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnLogout.Location = new System.Drawing.Point(21, 709);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(125, 44);
            this.BtnLogout.TabIndex = 27;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 786);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNavSelling);
            this.Controls.Add(this.btnNavProducts);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.btnNavSeller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BilldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridTopRightSelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNavSelling;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavSeller;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView SellingGridView;
        private System.Windows.Forms.MaskedTextBox BillIDTb;
        private System.Windows.Forms.Button btnPrintSelling;
        private System.Windows.Forms.Button btnAddSelling;
        private System.Windows.Forms.Button btnDeleteSelling;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ProdQtyTb;
        private System.Windows.Forms.MaskedTextBox ProdPriceTb;
        private System.Windows.Forms.MaskedTextBox ProdNameTb;
        private System.Windows.Forms.ComboBox ddlProdCategory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sellerNamelbl;
        private System.Windows.Forms.DataGridView OrderGridTopRightSelling;
        private System.Windows.Forms.Button btnAddProductSelling;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView BilldataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        //private System.Windows.Forms.PrintPreviewDialog PrintPrevDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogSelling1;
        private System.Drawing.Printing.PrintDocument printDocumentSelling1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.MaskedTextBox BillID2Tb;
    }
}