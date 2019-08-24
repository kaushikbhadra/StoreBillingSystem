namespace BillingSyatem.UI
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.pcbProduct = new System.Windows.Forms.PictureBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtpdtID = new System.Windows.Forms.TextBox();
            this.lblpdtRate = new System.Windows.Forms.Label();
            this.txtpdtRate = new System.Windows.Forms.TextBox();
            this.lblpdtDescription = new System.Windows.Forms.Label();
            this.txtpdtDescription = new System.Windows.Forms.TextBox();
            this.lblpdtCategorie = new System.Windows.Forms.Label();
            this.lblPdtName = new System.Windows.Forms.Label();
            this.txtpdtName = new System.Windows.Forms.TextBox();
            this.txtpdtSearch = new System.Windows.Forms.TextBox();
            this.lblpdtSearch = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnpdtADD = new System.Windows.Forms.Button();
            this.btnpdtUpdate = new System.Windows.Forms.Button();
            this.btnpdtDelete = new System.Windows.Forms.Button();
            this.cmbpdtCategorie = new System.Windows.Forms.ComboBox();
            this.pnlProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlProduct
            // 
            this.pnlProduct.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlProduct.Controls.Add(this.lblProducts);
            this.pnlProduct.Controls.Add(this.pcbProduct);
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProduct.Location = new System.Drawing.Point(0, 0);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(797, 32);
            this.pnlProduct.TabIndex = 0;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(366, 8);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(76, 17);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "PRODUCTS";
            // 
            // pcbProduct
            // 
            this.pcbProduct.Image = ((System.Drawing.Image)(resources.GetObject("pcbProduct.Image")));
            this.pcbProduct.Location = new System.Drawing.Point(758, 0);
            this.pcbProduct.Name = "pcbProduct";
            this.pcbProduct.Size = new System.Drawing.Size(39, 32);
            this.pcbProduct.TabIndex = 0;
            this.pcbProduct.TabStop = false;
            this.pcbProduct.Click += new System.EventHandler(this.pcbProduct_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(5, 66);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(69, 17);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "ProductID";
            // 
            // txtpdtID
            // 
            this.txtpdtID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdtID.Location = new System.Drawing.Point(112, 63);
            this.txtpdtID.Name = "txtpdtID";
            this.txtpdtID.ReadOnly = true;
            this.txtpdtID.Size = new System.Drawing.Size(237, 25);
            this.txtpdtID.TabIndex = 2;
            // 
            // lblpdtRate
            // 
            this.lblpdtRate.AutoSize = true;
            this.lblpdtRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdtRate.Location = new System.Drawing.Point(6, 327);
            this.lblpdtRate.Name = "lblpdtRate";
            this.lblpdtRate.Size = new System.Drawing.Size(35, 17);
            this.lblpdtRate.TabIndex = 7;
            this.lblpdtRate.Text = "Rate";
            // 
            // txtpdtRate
            // 
            this.txtpdtRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdtRate.Location = new System.Drawing.Point(112, 321);
            this.txtpdtRate.Name = "txtpdtRate";
            this.txtpdtRate.Size = new System.Drawing.Size(87, 25);
            this.txtpdtRate.TabIndex = 8;
            // 
            // lblpdtDescription
            // 
            this.lblpdtDescription.AutoSize = true;
            this.lblpdtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdtDescription.Location = new System.Drawing.Point(6, 220);
            this.lblpdtDescription.Name = "lblpdtDescription";
            this.lblpdtDescription.Size = new System.Drawing.Size(76, 17);
            this.lblpdtDescription.TabIndex = 7;
            this.lblpdtDescription.Text = "Description";
            // 
            // txtpdtDescription
            // 
            this.txtpdtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdtDescription.Location = new System.Drawing.Point(112, 220);
            this.txtpdtDescription.Multiline = true;
            this.txtpdtDescription.Name = "txtpdtDescription";
            this.txtpdtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtpdtDescription.Size = new System.Drawing.Size(237, 85);
            this.txtpdtDescription.TabIndex = 8;
            // 
            // lblpdtCategorie
            // 
            this.lblpdtCategorie.AutoSize = true;
            this.lblpdtCategorie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdtCategorie.Location = new System.Drawing.Point(5, 166);
            this.lblpdtCategorie.Name = "lblpdtCategorie";
            this.lblpdtCategorie.Size = new System.Drawing.Size(66, 17);
            this.lblpdtCategorie.TabIndex = 7;
            this.lblpdtCategorie.Text = "Categorie";
            // 
            // lblPdtName
            // 
            this.lblPdtName.AutoSize = true;
            this.lblPdtName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdtName.Location = new System.Drawing.Point(6, 114);
            this.lblPdtName.Name = "lblPdtName";
            this.lblPdtName.Size = new System.Drawing.Size(96, 17);
            this.lblPdtName.TabIndex = 7;
            this.lblPdtName.Text = "Product Name";
            // 
            // txtpdtName
            // 
            this.txtpdtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdtName.Location = new System.Drawing.Point(112, 114);
            this.txtpdtName.Name = "txtpdtName";
            this.txtpdtName.Size = new System.Drawing.Size(237, 25);
            this.txtpdtName.TabIndex = 8;
            // 
            // txtpdtSearch
            // 
            this.txtpdtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdtSearch.Location = new System.Drawing.Point(455, 63);
            this.txtpdtSearch.Name = "txtpdtSearch";
            this.txtpdtSearch.Size = new System.Drawing.Size(330, 25);
            this.txtpdtSearch.TabIndex = 22;
            this.txtpdtSearch.TextChanged += new System.EventHandler(this.txtpdtSearch_TextChanged);
            // 
            // lblpdtSearch
            // 
            this.lblpdtSearch.AutoSize = true;
            this.lblpdtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpdtSearch.Location = new System.Drawing.Point(373, 66);
            this.lblpdtSearch.Name = "lblpdtSearch";
            this.lblpdtSearch.Size = new System.Drawing.Size(48, 17);
            this.lblpdtSearch.TabIndex = 21;
            this.lblpdtSearch.Text = "Search";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(376, 114);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(409, 271);
            this.dgvProduct.TabIndex = 23;
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // btnpdtADD
            // 
            this.btnpdtADD.BackColor = System.Drawing.Color.DarkGreen;
            this.btnpdtADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdtADD.ForeColor = System.Drawing.Color.White;
            this.btnpdtADD.Location = new System.Drawing.Point(139, 416);
            this.btnpdtADD.Name = "btnpdtADD";
            this.btnpdtADD.Size = new System.Drawing.Size(123, 34);
            this.btnpdtADD.TabIndex = 24;
            this.btnpdtADD.Text = "ADD";
            this.btnpdtADD.UseVisualStyleBackColor = false;
            this.btnpdtADD.Click += new System.EventHandler(this.btnpdtADD_Click);
            // 
            // btnpdtUpdate
            // 
            this.btnpdtUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnpdtUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdtUpdate.ForeColor = System.Drawing.Color.White;
            this.btnpdtUpdate.Location = new System.Drawing.Point(315, 416);
            this.btnpdtUpdate.Name = "btnpdtUpdate";
            this.btnpdtUpdate.Size = new System.Drawing.Size(117, 34);
            this.btnpdtUpdate.TabIndex = 25;
            this.btnpdtUpdate.Text = "UPDATE";
            this.btnpdtUpdate.UseVisualStyleBackColor = false;
            this.btnpdtUpdate.Click += new System.EventHandler(this.btnpdtUpdate_Click);
            // 
            // btnpdtDelete
            // 
            this.btnpdtDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnpdtDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpdtDelete.ForeColor = System.Drawing.Color.White;
            this.btnpdtDelete.Location = new System.Drawing.Point(467, 416);
            this.btnpdtDelete.Name = "btnpdtDelete";
            this.btnpdtDelete.Size = new System.Drawing.Size(126, 34);
            this.btnpdtDelete.TabIndex = 26;
            this.btnpdtDelete.Text = "DELETE";
            this.btnpdtDelete.UseVisualStyleBackColor = false;
            this.btnpdtDelete.Click += new System.EventHandler(this.btnpdtDelete_Click);
            // 
            // cmbpdtCategorie
            // 
            this.cmbpdtCategorie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpdtCategorie.FormattingEnabled = true;
            this.cmbpdtCategorie.Location = new System.Drawing.Point(112, 166);
            this.cmbpdtCategorie.Name = "cmbpdtCategorie";
            this.cmbpdtCategorie.Size = new System.Drawing.Size(237, 25);
            this.cmbpdtCategorie.TabIndex = 27;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.cmbpdtCategorie);
            this.Controls.Add(this.btnpdtDelete);
            this.Controls.Add(this.btnpdtUpdate);
            this.Controls.Add(this.btnpdtADD);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtpdtSearch);
            this.Controls.Add(this.lblpdtSearch);
            this.Controls.Add(this.txtpdtRate);
            this.Controls.Add(this.lblpdtRate);
            this.Controls.Add(this.txtpdtDescription);
            this.Controls.Add(this.lblpdtDescription);
            this.Controls.Add(this.txtpdtName);
            this.Controls.Add(this.lblPdtName);
            this.Controls.Add(this.lblpdtCategorie);
            this.Controls.Add(this.txtpdtID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.pnlProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRODUCTS";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.PictureBox pcbProduct;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtpdtID;
        private System.Windows.Forms.Label lblpdtRate;
        private System.Windows.Forms.TextBox txtpdtRate;
        private System.Windows.Forms.Label lblpdtDescription;
        private System.Windows.Forms.TextBox txtpdtDescription;
        private System.Windows.Forms.Label lblpdtCategorie;
        private System.Windows.Forms.Label lblPdtName;
        private System.Windows.Forms.TextBox txtpdtName;
        private System.Windows.Forms.TextBox txtpdtSearch;
        private System.Windows.Forms.Label lblpdtSearch;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnpdtADD;
        private System.Windows.Forms.Button btnpdtUpdate;
        private System.Windows.Forms.Button btnpdtDelete;
        private System.Windows.Forms.ComboBox cmbpdtCategorie;
    }
}