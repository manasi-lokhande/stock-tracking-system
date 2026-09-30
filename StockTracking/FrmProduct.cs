using StockTracking.BLL;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockTracking
{
    public partial class FrmProduct : Form
    {
        public ProductDTO dto = new ProductDTO();
        ProductBLL bll = new ProductBLL();
        public ProductDetailDTO detail = new ProductDetailDTO();
        public bool isUpdate = false;
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
            if (isUpdate)
            {
                cmbCategory.SelectedValue = detail.CategoryId;
                txtName.Text = detail.ProductName;
                txtPrice.Text = detail.Price.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
                MessageBox.Show("Product Name is Empty");
            else if (txtPrice.Text.Trim() == "")
                MessageBox.Show("Product Price is Empty");
            else if (cmbCategory.SelectedIndex == -1)
                MessageBox.Show("Please select category");
            else
            {
                ProductDetailDTO product = new ProductDetailDTO();
                if (!isUpdate)
                {
                    product.ProductName = txtName.Text;
                    product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                    product.Price = Convert.ToInt32(txtPrice.Text);
                    if (bll.Insert(product))
                    {
                        MessageBox.Show("Product Added");
                        txtName.Clear();
                        txtPrice.Clear();
                        cmbCategory.SelectedIndex = -1;
                    }
                    
                }
                else if (isUpdate)
                {
                    if (detail.ProductName == txtName.Text && 
                        detail.CategoryId == Convert.ToInt32(cmbCategory.SelectedValue)&&
                        detail.Price == Convert.ToInt32(txtPrice.Text))
                    {
                        MessageBox.Show("There is no changes");
                    }
                    product.ProductName = txtName.Text;
                    product.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                    product.Price = Convert.ToInt32(txtPrice.Text);
                    product.ProductID = detail.ProductID;
                    if (bll.Update(product))
                    {
                        MessageBox.Show("Product Updated");
                        this.Close();
                    }
                }

            }
        }
    }
}

