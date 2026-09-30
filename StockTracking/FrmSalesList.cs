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
    public partial class FrmSalesList : Form
    {
        SalesDTO dto = new SalesDTO();
        SalesBLL bll = new SalesBLL();
        SalesDetailDTO detail = new SalesDetailDTO();
        
        public FrmSalesList()
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

        private void txtStockAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSales frm = new FrmSales();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.select();
            dataGridView1.DataSource = dto.Sales;
        }

        private void FrmSalesList_Load(object sender, EventArgs e)
        {
            dto = bll.select();
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

            cmbCategory.DataSource = dto.Categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<SalesDetailDTO> list = dto.Sales;
            if (txtCustomer.Text.Trim() != "")
                list = list.Where(x => x.CustomerName == txtCustomer.Text).ToList();
            if (txtName.Text.Trim() != "")
                list = list.Where(x => x.ProductName == txtName.Text).ToList();
            if (cmbCategory.SelectedIndex != -1)
                list = list.Where(x => x.CategoryID == Convert.ToInt32(cmbCategory.SelectedValue)).ToList();
            if (txtPrice.Text.Trim() != "")
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
            if (txtSalesAmount.Text.Trim() != "")
            {
                if (rbSalesEqual.Checked)
                    list = list.Where(x => x.StockAmount == Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else if (rbSalesMore.Checked)
                    list = list.Where(x => x.StockAmount > Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else if (rbSalesLess.Checked)
                    list = list.Where(x => x.StockAmount < Convert.ToInt32(txtSalesAmount.Text)).ToList();
                else
                    MessageBox.Show("Please select criterion from Stock group");
            }
            if (cbDate.Checked)
                list = list.Where(x => x.SalesDate > dpStart.Value && x.SalesDate < dpEnd.Value).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFilter();
        }

        private void clearFilter()
        {
            txtCustomer.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtSalesAmount.Clear();
            rbPriceEqual.Checked = false;
            rbPriceLess.Checked = false;
            rbPriceMore.Checked = false;
            rbSalesEqual.Checked = false;
            rbSalesMore.Checked = false;
            rbSalesLess.Checked = false;
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;
            cbDate.Checked = false;
            cmbCategory.SelectedIndex = -1;
            dataGridView1.DataSource = dto.Sales;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new SalesDetailDTO();
            detail.SalesID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.ProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            detail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            detail.ProductName = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();            
            detail.Price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);            
            detail.SalesAmount = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[7].Value);            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.SalesID == 0)
                MessageBox.Show("please select Sales from table");
            else
            {
                FrmSales frm = new FrmSales();
                frm.detail = detail;
                frm.isUpadte = true;
                frm.dto = dto;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new SalesBLL();
                dto = bll.select();
                dataGridView1.DataSource = dto.Sales;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.SalesID == 0)
                MessageBox.Show("please select Sales from table");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure??", "Warning!!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Sales Deleted");
                        bll = new SalesBLL();
                        dto = bll.select();
                        dataGridView1.DataSource = dto.Sales;
                        clearFilter();
                    }
                }
            }
        }
    }
}
