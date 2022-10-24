
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.Datelbl = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(167, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 683);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.ProductsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.ProductsDataGridView.ColumnHeadersHeight = 18;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.ProductsDataGridView.EnableHeadersVisualStyles = false;
            this.ProductsDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductsDataGridView.Location = new System.Drawing.Point(414, 72);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.ProductsDataGridView.RowHeadersWidth = 51;
            this.ProductsDataGridView.RowTemplate.Height = 24;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(716, 591);
            this.ProductsDataGridView.TabIndex = 20;
            this.ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsDataGridView_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(413, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 28);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Select Category";
            // 
            // ddlProdCategory
            // 
            this.ddlProdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProdCategory.FormattingEnabled = true;
            this.ddlProdCategory.Location = new System.Drawing.Point(193, 228);
            this.ddlProdCategory.Name = "ddlProdCategory";
            this.ddlProdCategory.Size = new System.Drawing.Size(171, 28);
            this.ddlProdCategory.TabIndex = 18;
            this.ddlProdCategory.Text = "Select Category";
            // 
            // ProdPriceTb
            // 
            this.ProdPriceTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdPriceTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdPriceTb.Location = new System.Drawing.Point(193, 175);
            this.ProdPriceTb.Name = "ProdPriceTb";
            this.ProdPriceTb.Size = new System.Drawing.Size(171, 30);
            this.ProdPriceTb.TabIndex = 17;
            // 
            // ProdQtyTb
            // 
            this.ProdQtyTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdQtyTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdQtyTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdQtyTb.Location = new System.Drawing.Point(193, 124);
            this.ProdQtyTb.Name = "ProdQtyTb";
            this.ProdQtyTb.Size = new System.Drawing.Size(171, 30);
            this.ProdQtyTb.TabIndex = 17;
            // 
            // ProdNameTb
            // 
            this.ProdNameTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdNameTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdNameTb.Location = new System.Drawing.Point(193, 72);
            this.ProdNameTb.Name = "ProdNameTb";
            this.ProdNameTb.Size = new System.Drawing.Size(171, 30);
            this.ProdNameTb.TabIndex = 17;
            // 
            // ProdIDTb
            // 
            this.ProdIDTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdIDTb.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDTb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ProdIDTb.Location = new System.Drawing.Point(193, 26);
            this.ProdIDTb.Name = "ProdIDTb";
            this.ProdIDTb.Size = new System.Drawing.Size(171, 30);
            this.ProdIDTb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(30, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
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
            this.btnEditProducts.Location = new System.Drawing.Point(142, 293);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(105, 43);
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
            this.btnAddProducts.Location = new System.Drawing.Point(36, 293);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(100, 43);
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
            this.button4.Location = new System.Drawing.Point(598, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 32);
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
            this.btnDeleteProducts.Location = new System.Drawing.Point(253, 293);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(111, 43);
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
            this.label7.Location = new System.Drawing.Point(30, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 35);
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
            this.label6.Location = new System.Drawing.Point(30, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 35);
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
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 35);
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
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 35);
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
            this.label3.Location = new System.Drawing.Point(573, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "MANAGE PRODUCTS";
            // 
            // btnNavSeller
            // 
            this.btnNavSeller.FlatAppearance.BorderSize = 0;
            this.btnNavSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSeller.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSeller.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNavSeller.Location = new System.Drawing.Point(3, 95);
            this.btnNavSeller.Name = "btnNavSeller";
            this.btnNavSeller.Size = new System.Drawing.Size(125, 44);
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
            this.button5.Location = new System.Drawing.Point(11, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 44);
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
            this.button6.Location = new System.Drawing.Point(8, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 44);
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
            this.button8.Location = new System.Drawing.Point(1279, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 44);
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
            this.btnMinimize.Location = new System.Drawing.Point(1241, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 44);
            this.btnMinimize.TabIndex = 23;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // Datelbl
            // 
            this.Datelbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Sitka Display", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.ForeColor = System.Drawing.Color.Navy;
            this.Datelbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Datelbl.Location = new System.Drawing.Point(768, 21);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(67, 32);
            this.Datelbl.TabIndex = 21;
            this.Datelbl.Text = "DATE";
            this.Datelbl.Click += new System.EventHandler(this.Datelbl_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 786);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNavSeller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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