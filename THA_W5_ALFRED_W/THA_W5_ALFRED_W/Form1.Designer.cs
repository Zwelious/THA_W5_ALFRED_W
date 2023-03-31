namespace THA_W5_ALFRED_W
{
    partial class Form1
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
            this.lbl_Product = new System.Windows.Forms.Label();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.dataGridView_Categories = new System.Windows.Forms.DataGridView();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.cmb_Filter = new System.Windows.Forms.ComboBox();
            this.cmb_Cat = new System.Windows.Forms.ComboBox();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Nama = new System.Windows.Forms.Label();
            this.lbl_Cat = new System.Windows.Forms.Label();
            this.lbl_Harga = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_EditProduct = new System.Windows.Forms.Button();
            this.btn_RemoveProduct = new System.Windows.Forms.Button();
            this.lbl_Nama1 = new System.Windows.Forms.Label();
            this.textBox_NamaCat = new System.Windows.Forms.TextBox();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.btn_RemoveCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(31, 38);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(119, 32);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "Product";
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(37, 88);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.RowHeadersWidth = 51;
            this.dataGridView_Products.RowTemplate.Height = 24;
            this.dataGridView_Products.ShowEditingIcon = false;
            this.dataGridView_Products.Size = new System.Drawing.Size(430, 263);
            this.dataGridView_Products.TabIndex = 1;
            this.dataGridView_Products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_CellContentClick);
            // 
            // dataGridView_Categories
            // 
            this.dataGridView_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categories.Location = new System.Drawing.Point(526, 88);
            this.dataGridView_Categories.Name = "dataGridView_Categories";
            this.dataGridView_Categories.RowHeadersWidth = 51;
            this.dataGridView_Categories.RowTemplate.Height = 24;
            this.dataGridView_Categories.Size = new System.Drawing.Size(239, 200);
            this.dataGridView_Categories.TabIndex = 2;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(520, 38);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(137, 32);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(254, 48);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(48, 23);
            this.btn_All.TabIndex = 4;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(308, 48);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(58, 23);
            this.btn_Filter.TabIndex = 5;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // cmb_Filter
            // 
            this.cmb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Filter.FormattingEnabled = true;
            this.cmb_Filter.Location = new System.Drawing.Point(372, 48);
            this.cmb_Filter.Name = "cmb_Filter";
            this.cmb_Filter.Size = new System.Drawing.Size(95, 24);
            this.cmb_Filter.TabIndex = 6;
            this.cmb_Filter.SelectionChangeCommitted += new System.EventHandler(this.cmb_Filter_SelectionChangeCommitted);
            // 
            // cmb_Cat
            // 
            this.cmb_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cat.FormattingEnabled = true;
            this.cmb_Cat.Location = new System.Drawing.Point(115, 425);
            this.cmb_Cat.Name = "cmb_Cat";
            this.cmb_Cat.Size = new System.Drawing.Size(115, 24);
            this.cmb_Cat.TabIndex = 7;
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Location = new System.Drawing.Point(32, 360);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(78, 25);
            this.lbl_Details.TabIndex = 8;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_Nama
            // 
            this.lbl_Nama.AutoSize = true;
            this.lbl_Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nama.Location = new System.Drawing.Point(34, 394);
            this.lbl_Nama.Name = "lbl_Nama";
            this.lbl_Nama.Size = new System.Drawing.Size(47, 16);
            this.lbl_Nama.TabIndex = 9;
            this.lbl_Nama.Text = "Nama:";
            // 
            // lbl_Cat
            // 
            this.lbl_Cat.AutoSize = true;
            this.lbl_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cat.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_Cat.Location = new System.Drawing.Point(16, 428);
            this.lbl_Cat.Name = "lbl_Cat";
            this.lbl_Cat.Size = new System.Drawing.Size(65, 16);
            this.lbl_Cat.TabIndex = 10;
            this.lbl_Cat.Text = "Category:";
            // 
            // lbl_Harga
            // 
            this.lbl_Harga.AutoSize = true;
            this.lbl_Harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Harga.Location = new System.Drawing.Point(33, 461);
            this.lbl_Harga.Name = "lbl_Harga";
            this.lbl_Harga.Size = new System.Drawing.Size(48, 16);
            this.lbl_Harga.TabIndex = 11;
            this.lbl_Harga.Text = "Harga:";
            this.lbl_Harga.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.Location = new System.Drawing.Point(37, 493);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(44, 16);
            this.lbl_Stock.TabIndex = 12;
            this.lbl_Stock.Text = "Stock:";
            this.lbl_Stock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(115, 391);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(346, 22);
            this.textBox_Nama.TabIndex = 13;
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Location = new System.Drawing.Point(115, 458);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(115, 22);
            this.textBox_Harga.TabIndex = 14;
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(115, 490);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(115, 22);
            this.textBox_Stock.TabIndex = 15;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Location = new System.Drawing.Point(236, 458);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(74, 54);
            this.btn_AddProduct.TabIndex = 16;
            this.btn_AddProduct.Text = "Add Product";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_EditProduct
            // 
            this.btn_EditProduct.Location = new System.Drawing.Point(311, 458);
            this.btn_EditProduct.Name = "btn_EditProduct";
            this.btn_EditProduct.Size = new System.Drawing.Size(78, 54);
            this.btn_EditProduct.TabIndex = 17;
            this.btn_EditProduct.Text = "Edit Product";
            this.btn_EditProduct.UseVisualStyleBackColor = true;
            this.btn_EditProduct.Click += new System.EventHandler(this.btn_EditProduct_Click);
            // 
            // btn_RemoveProduct
            // 
            this.btn_RemoveProduct.Location = new System.Drawing.Point(390, 458);
            this.btn_RemoveProduct.Name = "btn_RemoveProduct";
            this.btn_RemoveProduct.Size = new System.Drawing.Size(77, 54);
            this.btn_RemoveProduct.TabIndex = 18;
            this.btn_RemoveProduct.Text = "Remove Product";
            this.btn_RemoveProduct.UseVisualStyleBackColor = true;
            this.btn_RemoveProduct.Click += new System.EventHandler(this.btn_RemoveProduct_Click);
            // 
            // lbl_Nama1
            // 
            this.lbl_Nama1.AutoSize = true;
            this.lbl_Nama1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nama1.Location = new System.Drawing.Point(523, 306);
            this.lbl_Nama1.Name = "lbl_Nama1";
            this.lbl_Nama1.Size = new System.Drawing.Size(47, 16);
            this.lbl_Nama1.TabIndex = 19;
            this.lbl_Nama1.Text = "Nama:";
            // 
            // textBox_NamaCat
            // 
            this.textBox_NamaCat.Location = new System.Drawing.Point(591, 303);
            this.textBox_NamaCat.Name = "textBox_NamaCat";
            this.textBox_NamaCat.Size = new System.Drawing.Size(174, 22);
            this.textBox_NamaCat.TabIndex = 20;
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(603, 339);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(77, 54);
            this.btn_AddCategory.TabIndex = 21;
            this.btn_AddCategory.Text = "Add Category";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // btn_RemoveCategory
            // 
            this.btn_RemoveCategory.Location = new System.Drawing.Point(686, 339);
            this.btn_RemoveCategory.Name = "btn_RemoveCategory";
            this.btn_RemoveCategory.Size = new System.Drawing.Size(79, 54);
            this.btn_RemoveCategory.TabIndex = 22;
            this.btn_RemoveCategory.Text = "Remove Category";
            this.btn_RemoveCategory.UseVisualStyleBackColor = true;
            this.btn_RemoveCategory.Click += new System.EventHandler(this.btn_RemoveCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btn_RemoveCategory);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(this.textBox_NamaCat);
            this.Controls.Add(this.lbl_Nama1);
            this.Controls.Add(this.btn_RemoveProduct);
            this.Controls.Add(this.btn_EditProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.textBox_Harga);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Harga);
            this.Controls.Add(this.lbl_Cat);
            this.Controls.Add(this.lbl_Nama);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.cmb_Cat);
            this.Controls.Add(this.cmb_Filter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.dataGridView_Categories);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.lbl_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.DataGridView dataGridView_Categories;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox cmb_Filter;
        private System.Windows.Forms.ComboBox cmb_Cat;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Nama;
        private System.Windows.Forms.Label lbl_Cat;
        private System.Windows.Forms.Label lbl_Harga;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_EditProduct;
        private System.Windows.Forms.Button btn_RemoveProduct;
        private System.Windows.Forms.Label lbl_Nama1;
        private System.Windows.Forms.TextBox textBox_NamaCat;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_RemoveCategory;
    }
}

