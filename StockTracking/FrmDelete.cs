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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StockTracking
{
    public partial class FrmDelete : Form
    {
        SalesBLL bll = new SalesBLL();
        SalesDTO dto = new SalesDTO();
        SalesDetailDTO salesDetail = new SalesDetailDTO();
        ProductDetailDTO productDetail = new ProductDetailDTO();
        CategoryDetailDTO categoryDetail = new CategoryDetailDTO();
        CustomerDetailDTO customerDetail = new CustomerDetailDTO();
        CategoryBLL categoryBLL = new CategoryBLL();
        ProductBLL productBLL = new ProductBLL();
        CustomerBLL customerBLL = new CustomerBLL();
        SalesBLL salesBLL = new SalesBLL();
        public FrmDelete()
        {
            InitializeComponent();
        }

        private void FrmDelete_Load(object sender, EventArgs e)
        {
            cmbDeleteData.Items.Add("Category");
            cmbDeleteData.Items.Add("Product");
            cmbDeleteData.Items.Add("Customer");
            cmbDeleteData.Items.Add("Sales");
            dto = bll.select(true);
            dataGridView1.DataSource = dto.Sales;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "Customer";
            dataGridView1.Columns[5].HeaderText = "Product";
            dataGridView1.Columns[6].HeaderText = "Category";
            dataGridView1.Columns[7].HeaderText = "Sales Amount";
            dataGridView1.Columns[8].HeaderText = "Price";
            dataGridView1.Columns[9].HeaderText = "Sales Date";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDeleteData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeleteData.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dto.Categories;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Categorys";
            }
            else if(cmbDeleteData.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dto.Products;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Product";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Category";
                dataGridView1.Columns[4].HeaderText = "Stock Amount";
                dataGridView1.Columns[5].HeaderText = "Price";
            }
            else if (cmbDeleteData.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dto.Customers;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Customer Name";
            }
            else if (cmbDeleteData.SelectedIndex == 3)
            {
                dataGridView1.DataSource = dto.Sales;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].HeaderText = "Customer";
                dataGridView1.Columns[5].HeaderText = "Product";
                dataGridView1.Columns[6].HeaderText = "Category";
                dataGridView1.Columns[7].HeaderText = "Sales Amount";
                dataGridView1.Columns[8].HeaderText = "Price";
                dataGridView1.Columns[9].HeaderText = "Sales Date";
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbDeleteData.SelectedIndex == 0)
            {
                categoryDetail = new CategoryDetailDTO();
                categoryDetail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                categoryDetail.CategoryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeleteData.SelectedIndex == 1)
            {
                productDetail = new ProductDetailDTO();
                productDetail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                productDetail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                productDetail.CategoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                productDetail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
            else if (cmbDeleteData.SelectedIndex == 2)
            {
                customerDetail = new CustomerDetailDTO();
                customerDetail.CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                customerDetail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (cmbDeleteData.SelectedIndex == 3)
            {
                salesDetail = new SalesDetailDTO();
                salesDetail.SalesID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                salesDetail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                salesDetail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                salesDetail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                salesDetail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                salesDetail.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);
            }
        }

        private void btnGetBack_Click(object sender, EventArgs e)
        {
            if (cmbDeleteData.SelectedIndex == 0)
            {
                if (categoryBLL.GetBack(categoryDetail))
                {
                    MessageBox.Show("Category was Get Back");
                    dto = bll.select(true);
                    dataGridView1.DataSource = dto.Categories;
                }
            }
            else if (cmbDeleteData.SelectedIndex == 1)
            {
                if (productBLL.GetBack(productDetail))
                {
                    MessageBox.Show("Product was Get Back");
                    dto = bll.select(true);
                    dataGridView1.DataSource = dto.Products;
                }
            }
            else if (cmbDeleteData.SelectedIndex == 2)
            {
                if (customerBLL.GetBack(customerDetail))
                {
                    MessageBox.Show("Customer was Get Back");
                    dto = bll.select(true);
                    dataGridView1.DataSource = dto.Customers;
                }
            }
            else 
            {
                if (salesBLL.GetBack(salesDetail))
                {
                    MessageBox.Show("Sales was Get Back");
                    dto = bll.select(true);
                    dataGridView1.DataSource = dto.Sales;
                }
            }
        }
    }
}
