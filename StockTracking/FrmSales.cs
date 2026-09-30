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
    public partial class FrmSales : Form
    {
        public SalesDTO dto = new SalesDTO();
        public SalesDetailDTO detail = new SalesDetailDTO();
        SalesBLL bll = new SalesBLL();
        bool comboful = false;        
        public bool isUpadte = false;
        public FrmSales()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void FrmSales_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            if (!isUpadte)
            {
                dataGridView1.DataSource = dto.Products;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Product";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Category";
                dataGridView1.Columns[4].HeaderText = "Stock Amount";
                dataGridView1.Columns[5].HeaderText = "Price";

                dataGridView2.DataSource = dto.Customers;
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "Customer Name";
                if (dto.Categories.Count > 0)
                {
                    comboful = true;
                }
            }
            else
            {
                panel1.Hide();
                txtCustomer.Text = detail.CustomerName;
                txtName.Text = detail.ProductName;
                txtPrice.Text = detail.Price.ToString();
                txtSalesAmount.Text = detail.SalesAmount.ToString();
                ProductDetailDTO product = dto.Products.First(x => x.ProductID == detail.ProductID);
                detail.StockAmount = product.StockAmount;
                txtStockAmount.Text = detail.StockAmount.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customers;
            list = list.Where(x => x.CustomerName.Contains(txtCustomer.Text)).ToList();
            dataGridView2.DataSource = list;

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboful)
            {
                List<ProductDetailDTO> list = dto.Products;
                list = list.Where(x => x.CategoryId == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
                dataGridView1.DataSource = list;
                if (list.Count == 0)
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
            txtStockAmount.Text = detail.StockAmount.ToString();
            detail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.CustomerID = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            detail.CustomerName = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustomer.Text = detail.CustomerName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtSalesAmount.Text == "")
                MessageBox.Show("Sales Amount is empty");            
            else
            {
                if (!isUpadte)
                {
                    if (detail.CustomerID == 0)
                        MessageBox.Show("Please select Customer from product table");
                    else if (detail.ProductID == 0)
                        MessageBox.Show("Please select Product from table");
                    else if (detail.StockAmount < Convert.ToInt32(txtSalesAmount.Text))
                        MessageBox.Show("You have not enough product for sales");
                    else
                    {
                        detail.SalesAmount = Convert.ToInt32(txtSalesAmount.Text);
                        detail.SalesDate = DateTime.Today;
                        if (bll.Insert(detail))
                        {
                            MessageBox.Show("Sales Added");
                            bll = new SalesBLL();
                            dto = bll.select();
                            dataGridView1.DataSource = dto.Products;
                            dataGridView2.DataSource = dto.Customers;
                            comboful = false;
                            cmbCategory.DataSource = dto.Categories;
                            if (dto.Products.Count > 0)
                            {
                                comboful = true;
                            }
                            txtSalesAmount.Clear();
                        }
                    }
                }
                else
                {
                    if (detail.StockAmount == Convert.ToInt32(txtSalesAmount.Text))
                    {
                        MessageBox.Show("There is no chnage");
                    }
                    else
                    {
                        int temp = detail.StockAmount + detail.SalesAmount;
                        if(temp == Convert.ToInt32(txtSalesAmount.Text))
                            MessageBox.Show("You have not enough product for sales");
                        else
                        {
                            detail.SalesAmount = Convert.ToInt32(txtSalesAmount.Text);
                            detail.StockAmount = temp;
                            if (bll.Update(detail))
                            {
                                MessageBox.Show("Sales Updated");
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
