using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_ALFRED_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>();
        List<string> categories = new List<string>();
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtCategory = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        int categoriesCount = 0;
        int productid = 0;

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            categoriesCount++;
            if(textBox_NamaCat.Text == "")
            {
                MessageBox.Show("Add a category name", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                dtCategory.Rows.Add("C" + categoriesCount, textBox_NamaCat.Text);
            }
            cmb_Cat.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cmb_Cat.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            cmb_Filter.Items.Clear();
            cmb_Filter.Enabled = false;
            dataGridView_Products.DataSource = dtProdukSimpan;
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            cmb_Filter.Enabled = true;
            cmb_Filter.Items.Clear();
            for(int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cmb_Filter.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dataGridView_Products.DataSource = dtProdukSimpan;

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");
            dataGridView_Categories.DataSource = dtCategory;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            products.Add(new Product("Jas Hitam", "100000", "10", "Jas"));
            products.Add(new Product("T-Shirt Black Pink", "70000", "20", "T-Shirt"));
            products.Add(new Product("T-Shirt Obsessive", "75000", "16", "T-Shirt"));
            products.Add(new Product("Rok Mini", "82000", "26", "Rok"));
            products.Add(new Product("Jeans Biru", "90000", "5", "Celana"));
            products.Add(new Product("Celana Pendek Coklat", "60000", "14", "Celana"));
            products.Add(new Product("Cawat Blink-Blink", "100000", "1", "Cawat"));
            products.Add(new Product("Rocca Shirt", "50000", "8", "T-Shirt"));

            foreach(Product product in products)
            {
                if (!categories.Contains(product.Category))
                {
                    categories.Add(product.Category);
                    categoriesCount++;
                    dtCategory.Rows.Add("C" + categoriesCount, product.Category);
                }
            }

            for (int i = 65; i <= 90; i++)
            {
                foreach(Product product in products)
                {
                    if (product.Name[0] == Convert.ToChar(i))
                    {
                        productid++;
                        product.IDProduct = Convert.ToChar(i) + productid.ToString("000");
                    }
                }
                productid = 0;
            }

            foreach(Product product in products)
            {
                product.CategoryID = generateCategoryID(product);
                dtProdukSimpan.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
            }
            cmb_Filter.Enabled = false;

            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                cmb_Cat.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }
        private string generateProductID(Product product)
        {
            string IDProduct = "";
            for (int i = 65; i <= 90; i++)
            {
                if (product.Name[0] == Convert.ToChar(i))
                {
                    foreach(Product produk in products)
                    {
                        if (produk.Name[0] == product.Name[0])
                        {
                            productid++;
                        }
                    }
                    IDProduct = Convert.ToChar(i) + productid.ToString("000");
                }
                productid = 0;
            }
            return IDProduct;
            
        }
        private string generateCategoryID(Product product)
        {
            string categoryID = "";
            for(int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][1].ToString() == product.Category)
                {
                    categoryID = dtCategory.Rows[i][0].ToString();
                }
            }
            return categoryID; 
        }

        private void cmb_Filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_Products.DataSource = dtProdukTampil;
            dtProdukTampil.Rows.Clear();
            foreach(Product product in products)
            {
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if(product.Name == dtProdukSimpan.Rows[i][1].ToString() && product.Category == cmb_Filter.Text)
                    {
                        dtProdukTampil.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
                    }
                }
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            bool ada = false;
            if (textBox_Nama.Text == "" || textBox_Harga.Text == "" || textBox_Stock.Text == "" || cmb_Cat.Text == "")
            {
                MessageBox.Show("Please enter all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(Product produk in products)
                {
                    if(textBox_Nama.Text == produk.Name)
                    {
                        ada = true;
                        MessageBox.Show("Product exists, try another product", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if(ada == false)
                {
                    Product product = new Product(textBox_Nama.Text, textBox_Harga.Text, textBox_Stock.Text, cmb_Cat.Text);
                    products.Add(product);
                    product.IDProduct = generateProductID(product);
                    product.CategoryID = generateCategoryID(product);
                    dtProdukSimpan.Rows.Add(product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID);
                }
                
            }
        }

        private void btn_RemoveProduct_Click(object sender, EventArgs e)
        {
            if(dataGridView_Products.DataSource == dtProdukSimpan)
            {
                dtProdukSimpan.Rows.RemoveAt(dataGridView_Products.CurrentCell.RowIndex);
                for(int i = 0; i < dtProdukTampil.Rows.Count; i++)
                {
                    if (dtProdukTampil.Rows[i][1].ToString() == dtProdukSimpan.Rows[dataGridView_Products.CurrentCell.RowIndex][1].ToString())
                    {
                        dtProdukTampil.Rows.RemoveAt(i);
                    }
                }
            }
            else if(dataGridView_Products.DataSource == dtProdukTampil)
            {
                dtProdukTampil.Rows.RemoveAt(dataGridView_Products.CurrentCell.RowIndex);
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][1].ToString() == dtProdukTampil.Rows[dataGridView_Products.CurrentCell.RowIndex][1].ToString())
                    {
                        dtProdukSimpan.Rows.RemoveAt(i);
                    }
                }
            }
                
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            if (textBox_Nama.Text == "" || textBox_Harga.Text == "" || textBox_Stock.Text == "" || cmb_Cat.Text == "")
            {
                MessageBox.Show("Please enter all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = dataGridView_Products.CurrentCell.RowIndex;
                string namaProduk = dataGridView_Products.CurrentRow.Cells["Nama Product"].Value.ToString();
                foreach (Product product in products)
                {
                    if(namaProduk == product.Name)
                    {
                        product.Name = textBox_Nama.Text;
                        product.Category = cmb_Cat.Text;
                        product.Harga = textBox_Harga.Text;
                        product.Stock = textBox_Stock.Text;
                        product.IDProduct = generateProductID(product);
                        product.CategoryID = generateCategoryID(product);
                        for(int i = 0; i < dataGridView_Products.Rows.Count; i++)
                        {
                            if(i == index)
                            {
                                dataGridView_Products.Rows[i].SetValues(new object[] { product.IDProduct, product.Name, product.Harga, product.Stock, product.CategoryID });
                            }
                        }
                    }
                }
            }
            textBox_Nama.Text = "";
            cmb_Cat.SelectedIndex = -1;
            textBox_Harga.Text = "";
            textBox_Stock.Text = "";
        }

        private void dataGridView_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView_Products.CurrentCell.RowIndex;
            foreach (Product product in products)
            {
                if (dataGridView_Products.CurrentRow.Cells["Nama Product"].Value.ToString() == product.Name)
                {
                    textBox_Nama.Text = product.Name;
                    cmb_Cat.Text = product.Category;
                    textBox_Harga.Text = product.Harga;
                    textBox_Stock.Text = product.Stock;
                }
            }
        }

        private void btn_RemoveCategory_Click(object sender, EventArgs e)
        {
            dataGridView_Products.DataSource = dtProdukSimpan;
            int index = dataGridView_Categories.CurrentCell.RowIndex;
            string removedCategoryID = dtCategory.Rows[index][0].ToString();
            for(int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if(dtProdukSimpan.Rows[i][4].ToString() == removedCategoryID)
                {
                    dtProdukSimpan.Rows.RemoveAt(i);
                    i = 0;
                }
            }
            cmb_Cat.Items.Remove(dtCategory.Rows[index][1].ToString());
            dtCategory.Rows.RemoveAt(index);
        }
    }
}
