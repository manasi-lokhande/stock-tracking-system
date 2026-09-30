namespace StockTracking
{
    partial class FrmProductList
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
            this.btnClean = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbstockMore = new System.Windows.Forms.RadioButton();
            this.rbStockEqual = new System.Windows.Forms.RadioButton();
            this.rbStockLess = new System.Windows.Forms.RadioButton();
            this.Price = new System.Windows.Forms.GroupBox();
            this.rbPriceMore = new System.Windows.Forms.RadioButton();
            this.rbPriceEqual = new System.Windows.Forms.RadioButton();
            this.rbPriceLess = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStockAmount = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 100);
            this.panel2.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(420, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 49);
            this.btnDelete.TabIndex = 11;
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
            this.btnUpdate.TabIndex = 10;
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
            this.btnAdd.TabIndex = 9;
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
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(827, 237);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStockAmount);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 177);
            this.panel1.TabIndex = 3;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(692, 117);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(122, 49);
            this.btnClean.TabIndex = 26;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(562, 117);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(122, 49);
            this.btnsearch.TabIndex = 25;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbstockMore);
            this.groupBox1.Controls.Add(this.rbStockEqual);
            this.groupBox1.Controls.Add(this.rbStockLess);
            this.groupBox1.Location = new System.Drawing.Point(588, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 51);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // rbstockMore
            // 
            this.rbstockMore.AutoSize = true;
            this.rbstockMore.Location = new System.Drawing.Point(75, 21);
            this.rbstockMore.Name = "rbstockMore";
            this.rbstockMore.Size = new System.Drawing.Size(59, 20);
            this.rbstockMore.TabIndex = 2;
            this.rbstockMore.TabStop = true;
            this.rbstockMore.Text = "More";
            this.rbstockMore.UseVisualStyleBackColor = true;
            // 
            // rbStockEqual
            // 
            this.rbStockEqual.AutoSize = true;
            this.rbStockEqual.Location = new System.Drawing.Point(6, 22);
            this.rbStockEqual.Name = "rbStockEqual";
            this.rbStockEqual.Size = new System.Drawing.Size(63, 20);
            this.rbStockEqual.TabIndex = 1;
            this.rbStockEqual.TabStop = true;
            this.rbStockEqual.Text = "Equal";
            this.rbStockEqual.UseVisualStyleBackColor = true;
            // 
            // rbStockLess
            // 
            this.rbStockLess.AutoSize = true;
            this.rbStockLess.Location = new System.Drawing.Point(140, 22);
            this.rbStockLess.Name = "rbStockLess";
            this.rbStockLess.Size = new System.Drawing.Size(57, 20);
            this.rbStockLess.TabIndex = 0;
            this.rbStockLess.TabStop = true;
            this.rbStockLess.Text = "Less";
            this.rbStockLess.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.Controls.Add(this.rbPriceMore);
            this.Price.Controls.Add(this.rbPriceEqual);
            this.Price.Controls.Add(this.rbPriceLess);
            this.Price.Location = new System.Drawing.Point(588, 3);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(226, 51);
            this.Price.TabIndex = 23;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Stock Amount:";
            // 
            // txtStockAmount
            // 
            this.txtStockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAmount.Location = new System.Drawing.Point(466, 67);
            this.txtStockAmount.Name = "txtStockAmount";
            this.txtStockAmount.Size = new System.Drawing.Size(115, 30);
            this.txtStockAmount.TabIndex = 21;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(164, 65);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(141, 33);
            this.cmbCategory.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(466, 14);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 30);
            this.txtPrice.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(164, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 30);
            this.txtName.TabIndex = 15;
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStockAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox Price;
        private System.Windows.Forms.RadioButton rbPriceLess;
        private System.Windows.Forms.RadioButton rbPriceMore;
        private System.Windows.Forms.RadioButton rbPriceEqual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbstockMore;
        private System.Windows.Forms.RadioButton rbStockEqual;
        private System.Windows.Forms.RadioButton rbStockLess;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnsearch;
    }
}