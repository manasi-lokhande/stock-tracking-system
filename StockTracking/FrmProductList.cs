using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockTracking.BLL;
using StockTracking.DAL.DTO;

namespace StockTracking
{
    public partial class FrmProductList : Form
    {
        ProductDTO dto = new ProductDTO();
        ProductBLL bll = new ProductBLL();
        ProductDetailDTO detail = new ProductDetailDTO();
        public FrmProductList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.dto = dto;
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.select();
            dataGridView1.DataSource = dto.Produts;
        }

        private void FrmProductList_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Produts;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Product";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Category";
            dataGridView1.Columns[4].HeaderText = "Stock Amount";
            dataGridView1.Columns[5].HeaderText = "Price";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<ProductDetailDTO> list = dto.Produts;
            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.ProductName == txtName.Text).ToList();
            if(cmbCategory.SelectedIndex != -1)
                list = list.Where(x => x.CategoryId == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            if(txtPrice.Text.Trim()!= "")
            {
                if (rbPriceEqual.Checked)
                    list = list.Where(x => x.Price == Convert.ToInt32(txtPrice.Text)).ToList();
                else if (rbPriceMore.Checked)
                    list = list.Where(x => x.Price > Convert.ToInt32(txtPrice.Text)).ToList();
                else if (rbPriceLess.Checked)
                    list = list.Where(x => x.Price < Convert.ToInt32(txtPrice.Text)).ToList();
                else
                    MessageBox.Show("Please select criterion from Price group");
            }
            if (txtStockAmount.Text.Trim() != "")
            {
                if (rbStockEqual.Checked)
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtStockAmount.Text)).ToList();
                else if (rbstockMore.Checked)
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtStockAmount.Text)).ToList();
                else if (rbStockLess.Checked)
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtStockAmount.Text)).ToList();
                else
                    MessageBox.Show("Please select criterion from Stock group");
            }
            dataGridView1.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

        private void clearFilter()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStockAmount.Clear();
            cmbCategory.SelectedIndex = -1;
            rbPriceEqual.Checked = false;
            rbPriceMore.Checked = false;
            rbPriceLess.Checked = false;
            rbStockEqual.Checked = false;
            rbstockMore.Checked = false;
            rbStockLess.Checked = false;
            dataGridView1.DataSource = dto.Produts;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new ProductDetailDTO();
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.CategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
                MessageBox.Show("Please select product from table");
            else
            {
                FrmProduct frm = new FrmProduct();
                frm.dto = dto;
                frm.detail = detail;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new ProductBLL();
                dto = bll.select();
                dataGridView1.DataSource = dto.Produts;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.ProductID == 0)
                MessageBox.Show("Please select product from table");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure??", "Warning!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Sales Deleted");
                        bll = new ProductBLL();
                        dto = bll.select();
                        dataGridView1.DataSource = dto.Produts;
                        clearFilter();
                    }
                }
            }
        }

    }
}
