namespace StockTracking
{
    partial class FrmSalesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.rbSalesMore = new System.Windows.Forms.RadioButton();
            this.rbSalesEqual = new System.Windows.Forms.RadioButton();
            this.rbSalesLess = new System.Windows.Forms.RadioButton();
            this.Price = new System.Windows.Forms.GroupBox();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.Price.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 100);
            this.panel2.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(420, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(292, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 49);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(164, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 49);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(548, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 356);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbSales);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.cbDate);
            this.panel1.Controls.Add(this.dpEnd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dpStart);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCustomer);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSalesAmount);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 177);
            this.panel1.TabIndex = 0;
            // 
            // gbSales
            // 
            this.gbSales.Controls.Add(this.rbSalesMore);
            this.gbSales.Controls.Add(this.rbSalesEqual);
            this.gbSales.Controls.Add(this.rbSalesLess);
            this.gbSales.Location = new System.Drawing.Point(598, 60);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(226, 51);
            this.gbSales.TabIndex = 35;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Sales";
            // 
            // rbSalesMore
            // 
            this.rbSalesMore.AutoSize = true;
            this.rbSalesMore.Location = new System.Drawing.Point(75, 21);
            this.rbSalesMore.Name = "rbSalesMore";
            this.rbSalesMore.Size = new System.Drawing.Size(59, 20);
            this.rbSalesMore.TabIndex = 2;
            this.rbSalesMore.TabStop = true;
            this.rbSalesMore.Text = "More";
            this.rbSalesMore.UseVisualStyleBackColor = true;
            // 
            // rbSalesEqual
            // 
            this.rbSalesEqual.AutoSize = true;
            this.rbSalesEqual.Location = new System.Drawing.Point(6, 22);
            this.rbSalesEqual.Name = "rbSalesEqual";
            this.rbSalesEqual.Size = new System.Drawing.Size(63, 20);
            this.rbSalesEqual.TabIndex = 1;
            this.rbSalesEqual.TabStop = true;
            this.rbSalesEqual.Text = "Equal";
            this.rbSalesEqual.UseVisualStyleBackColor = true;
            // 
            // rbSalesLess
            // 
            this.rbSalesLess.AutoSize = true;
            this.rbSalesLess.Location = new System.Drawing.Point(140, 22);
            this.rbSalesLess.Name = "rbSalesLess";
            this.rbSalesLess.Size = new System.Drawing.Size(57, 20);
            this.rbSalesLess.TabIndex = 0;
            this.rbSalesLess.TabStop = true;
            this.rbSalesLess.Text = "Less";
            this.rbSalesLess.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.Controls.Add(this.rbPriceMore);
            this.Price.Controls.Add(this.rbPriceEqual);
            this.Price.Controls.Add(this.rbPriceLess);
            this.Price.Location = new System.Drawing.Point(598, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(226, 51);
            this.Price.TabIndex = 34;
            this.Price.TabStop = false;
            this.Price.Text = "Price";
            // 
            // rbPriceMore
            // 
            this.rbPriceMore.AutoSize = true;
            this.rbPriceMore.Location = new System.Drawing.Point(75, 21);
            this.rbPriceMore.Name = "rbPriceMore";
            this.rbPriceMore.Size = new System.Drawing.Size(59, 20);
            this.rbPriceMore.TabIndex = 2;
            this.rbPriceMore.TabStop = true;
            this.rbPriceMore.Text = "More";
            this.rbPriceMore.UseVisualStyleBackColor = true;
            // 
            // rbPriceEqual
            // 
            this.rbPriceEqual.AutoSize = true;
            this.rbPriceEqual.Location = new System.Drawing.Point(6, 22);
            this.rbPriceEqual.Name = "rbPriceEqual";
            this.rbPriceEqual.Size = new System.Drawing.Size(63, 20);
            this.rbPriceEqual.TabIndex = 1;
            this.rbPriceEqual.TabStop = true;
            this.rbPriceEqual.Text = "Equal";
            this.rbPriceEqual.UseVisualStyleBackColor = true;
            // 
            // rbPriceLess
            // 
            this.rbPriceLess.AutoSize = true;
            this.rbPriceLess.Location = new System.Drawing.Point(140, 22);
            this.rbPriceLess.Name = "rbPriceLess";
            this.rbPriceLess.Size = new System.Drawing.Size(57, 20);
            this.rbPriceLess.TabIndex = 0;
            this.rbPriceLess.TabStop = true;
            this.rbPriceLess.Text = "Less";
            this.rbPriceLess.UseVisualStyleBackColor = true;
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDate.Location = new System.Drawing.Point(500, 134);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(59, 19);
            this.cbDate.TabIndex = 33;
            this.cbDate.Text = "Date";
            this.cbDate.UseVisualStyleBackColor = true;
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(364, 132);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(130, 22);
            this.dpEnd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "To:";
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(183, 131);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(130, 22);
            this.dpStart.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sales Date From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Customer:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(164, 11);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(148, 30);
            this.txtCustomer.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(719, 116);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(122, 49);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(589, 116);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(122, 49);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sales Amount:";
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesAmount.Location = new System.Drawing.Point(458, 54);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(123, 30);
            this.txtSalesAmount.TabIndex = 4;
            this.txtSalesAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockAmount_KeyPress);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(164, 92);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(148, 33);
            this.cmbCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(458, 10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(123, 30);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 30);
            this.txtName.TabIndex = 1;
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSalesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales List";
            this.Load += new System.EventHandler(this.FrmSalesList_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSales.ResumeLayout(false);
            this.gbSales.PerformLayout();
            this.Price.ResumeLayout(false);
            this.Price.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.RadioButton rbSalesMore;
        private System.Windows.Forms.RadioButton rbSalesEqual;
        private System.Windows.Forms.RadioButton rbSalesLess;
        private System.Windows.Forms.GroupBox Price;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.RadioButton rbPriceLess;
    }
}