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
    public partial class FrmAddStock : Form
    {
        ProductDTO dto = new ProductDTO();
        ProductBLL bll = new ProductBLL();
        ProductDetailDTO detail = new ProductDetailDTO();
        public bool comboful= false;
        public FrmAddStock()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddStock_Load(object sender, EventArgs e)
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
            if (dto.Categories.Count>0)
            {
                comboful = true;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboful)
            {
                List<ProductDetailDTO> list = dto.Produts;
                list = list.Where(x => x.CategoryId == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dataGridView1.DataSource = list;
                if (list.Count==0)
                {
                    txtName.Clear();
                    txtPrice.Clear();
                    txtStockAmount.Clear();
                }
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtName.Text = detail.ProductName;
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            txtPrice.Text = detail.Price.ToString();
            detail.StockAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
                MessageBox.Show("Please select a product from table");
            else if (txtPrice.Text.Trim() == "")
                MessageBox.Show("Please select a product from table");
            else if (txtStockAmount.Text.Trim() == "")
                MessageBox.Show("Stock Amount is Empty");
            else
            {
                int sumstock = detail.StockAmount;
                sumstock += Convert.ToInt32(txtStockAmount.Text);
                detail.StockAmount = sumstock;
                if (bll.Update(detail))
                {
                    MessageBox.Show("Stock was Added");
                    bll = new ProductBLL();
                    dto = bll.select();
                    dataGridView1.DataSource = dto.Produts;
                    txtStockAmount.Clear();
                }
            }
        }
    }
}
