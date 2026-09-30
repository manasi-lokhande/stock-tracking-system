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
    public partial class FrmCategoryList : Form
    {
        CategoryDTO DTO = new CategoryDTO();
        CategoryBLL BLL = new CategoryBLL();
        CategoryDetailDTO detail = new CategoryDetailDTO();
        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            DTO = BLL.select();
            dataGridView1.DataSource = DTO.Categories;
        }

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            DTO = BLL.select();
            dataGridView1.DataSource = DTO.Categories;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Categorys";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            List<CategoryDetailDTO> list = DTO.Categories;
            if (txtCategory.Text.Trim() != "")
                list = list.Where(x => x.CategoryName == txtCategory.Text).ToList();
            dataGridView1.DataSource = list;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            dataGridView1.DataSource = DTO.Categories;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail = new CategoryDetailDTO();
            detail.CategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.CategoryName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.CategoryID == 0)
                MessageBox.Show("Please select Category from Table");
            else
            {
                FrmCategory frm = new FrmCategory();
                frm.detail = detail;
                frm.isUpadte = true;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                BLL = new CategoryBLL();
                DTO = BLL.select();
                dataGridView1.DataSource = DTO.Categories;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (detail.CategoryID == 0)
                MessageBox.Show("Please select Category from Table");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure??", "Warning!!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (BLL.Delete(detail))
                    {
                        MessageBox.Show("Sales Deleted");
                        BLL = new CategoryBLL();
                        DTO = BLL.select();
                        dataGridView1.DataSource = DTO.Categories;
                    }
                }
                
            }
        }
    }
}
