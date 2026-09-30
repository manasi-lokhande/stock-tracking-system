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
    public partial class FrmCustomerList : Form
    {
        CustomerDTO dto = new CustomerDTO();
        CustomerBLL bll = new CustomerBLL();
        CustomerDetailDTO detail = new CustomerDetailDTO();
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            dto = bll.select();
            dataGridView1.DataSource = dto.Customers;
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            dataGridView1.DataSource = dto.Customers;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Customer Name";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<CustomerDetailDTO> list = dto.Customers;
            if (txtCustomer.Text.Trim() != "")
                list = list.Where(x => x.CustomerName == txtCustomer.Text).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCustomer.Clear();
            dataGridView1.DataSource = dto.Customers;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CustomerDetailDTO();
            detail.CustomerID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CustomerName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.CustomerID == 0)
                MessageBox.Show("Please select Customer from table");
            else
            {
                FrmCustomer frm = new FrmCustomer();
                frm.detail = detail;
                frm.isUpdate = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                bll = new CustomerBLL();
                dto = bll.select();
                dataGridView1.DataSource = dto.Customers;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.CustomerID == 0)
                MessageBox.Show("Please select Customer from table");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure??", "Warning!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (bll.Delete(detail))
                    {
                        MessageBox.Show("Sales Deleted");
                        bll = new CustomerBLL();
                        dto = bll.select();
                        dataGridView1.DataSource = dto.Customers;                        
                    }
                }                
            }
        }
    }
}
