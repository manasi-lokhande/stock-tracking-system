namespace StockTracking
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(157, 125);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.btnProduct.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Location = new System.Drawing.Point(175, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(157, 125);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSales.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.Location = new System.Drawing.Point(338, 12);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(157, 125);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddStock.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Image")));
            this.btnAddStock.Location = new System.Drawing.Point(12, 143);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(157, 125);
            this.btnAddStock.TabIndex = 3;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCategory.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Location = new System.Drawing.Point(175, 143);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(157, 125);
            this.btnCategory.TabIndex = 4;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(338, 143);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 125);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(175, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 125);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 413);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCustomer);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}