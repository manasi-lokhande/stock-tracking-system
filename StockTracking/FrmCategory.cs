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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace StockTracking
{
    public partial class FrmCategory : Form
    {
        CategoryBLL BLL = new CategoryBLL();
        public CategoryDetailDTO detail = new CategoryDetailDTO();
        public bool isUpadte = false;
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (txtCategory.Text.Trim() == "")
                MessageBox.Show("category Name is Empty");
            else
            {
                if (!isUpadte)
                {
                    CategoryDetailDTO category = new CategoryDetailDTO();
                    category.CategoryName = txtCategory.Text;
                    if (BLL.Insert(category))
                    {
                        MessageBox.Show("Category Inserted");
                        txtCategory.Clear();
                        
                    }
                }
                else if(isUpadte)
                {
                    if (detail.CategoryName == txtCategory.Text)
                        MessageBox.Show("There is no Change");
                    else
                    {
                        detail.CategoryName = txtCategory.Text;
                        if (BLL.Update(detail))
                        {
                            MessageBox.Show("Category Updated");
                            this.Close();
                        }
                    }
                }
            }            
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            if (isUpadte)
            {
                txtCategory.Text = detail.CategoryName;

            }
        }
    }
}
