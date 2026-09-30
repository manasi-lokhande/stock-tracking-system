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
    public partial class FrmCustomer : Form
    {
        CustomerDetailDTO dto = new CustomerDetailDTO();
        CustomerBLL bll = new CustomerBLL();
        public CustomerDetailDTO detail = new CustomerDetailDTO();
        public bool isUpdate = false;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text.Trim() == "")
                MessageBox.Show("Customer Name is Empty");
            else
            {
                if (!isUpdate)
                {
                    dto.CustomerName = txtCustomer.Text;
                    if (bll.Insert(dto))
                    {
                        MessageBox.Show("Customer Added");
                        txtCustomer.Clear();
                    }
                }
                else if (isUpdate)
                {
                    dto.CustomerName = txtCustomer.Text;
                    dto.CustomerID = detail.CustomerID;
                    if (bll.Update(dto))
                    {
                        MessageBox.Show("Customer Updated");
                        this.Close();
                    }
                }
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txtCustomer.Text = detail.CustomerName;
            }
        }
    }
}
