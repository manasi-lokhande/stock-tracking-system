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
    public partial class FrmStockAlter : Form
    {
        ProductBLL bll = new ProductBLL();
        ProductDTO dto = new ProductDTO();
        public FrmStockAlter()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();            
        }

        private void FrmStockAlter_Load(object sender, EventArgs e)
        {
            dto = bll.select();
            dto.Produts = dto.Produts.Where(x => x.StockAmount <= 10).ToList();
            dataGridView1.DataSource = dto.Produts;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Product";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Category";
            dataGridView1.Columns[4].HeaderText = "Stock Amount";
            dataGridView1.Columns[5].HeaderText = "Price";
            if (dto.Produts.Count ==0)
            {
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
