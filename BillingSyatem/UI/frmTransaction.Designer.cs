namespace BillingSyatem.UI
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.pnlTopTransaction = new System.Windows.Forms.Panel();
            this.lblTopTransaction = new System.Windows.Forms.Label();
            this.pboxTransaction = new System.Windows.Forms.PictureBox();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.btnTShowAll = new System.Windows.Forms.Button();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.pnlTopTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTransaction
            // 
            this.pnlTopTransaction.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTopTransaction.Controls.Add(this.lblTopTransaction);
            this.pnlTopTransaction.Controls.Add(this.pboxTransaction);
            this.pnlTopTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTransaction.Location = new System.Drawing.Point(0, 0);
            this.pnlTopTransaction.Name = "pnlTopTransaction";
            this.pnlTopTransaction.Size = new System.Drawing.Size(797, 32);
            this.pnlTopTransaction.TabIndex = 1;
            // 
            // lblTopTransaction
            // 
            this.lblTopTransaction.AutoSize = true;
            this.lblTopTransaction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTransaction.Location = new System.Drawing.Point(342, 9);
            this.lblTopTransaction.Name = "lblTopTransaction";
            this.lblTopTransaction.Size = new System.Drawing.Size(99, 17);
            this.lblTopTransaction.TabIndex = 1;
            this.lblTopTransaction.Text = "TRANSACTION";
            // 
            // pboxTransaction
            // 
            this.pboxTransaction.Image = ((System.Drawing.Image)(resources.GetObject("pboxTransaction.Image")));
            this.pboxTransaction.Location = new System.Drawing.Point(758, 0);
            this.pboxTransaction.Name = "pboxTransaction";
            this.pboxTransaction.Size = new System.Drawing.Size(39, 32);
            this.pboxTransaction.TabIndex = 0;
            this.pboxTransaction.TabStop = false;
            this.pboxTransaction.Click += new System.EventHandler(this.pboxTransaction_Click);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(12, 107);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(773, 343);
            this.dgvTransaction.TabIndex = 2;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(12, 73);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(113, 17);
            this.lblTransactionType.TabIndex = 3;
            this.lblTransactionType.Text = "Transaction-Type:";
            // 
            // btnTShowAll
            // 
            this.btnTShowAll.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTShowAll.ForeColor = System.Drawing.Color.White;
            this.btnTShowAll.Location = new System.Drawing.Point(435, 66);
            this.btnTShowAll.Name = "btnTShowAll";
            this.btnTShowAll.Size = new System.Drawing.Size(95, 31);
            this.btnTShowAll.TabIndex = 5;
            this.btnTShowAll.Text = "Show All";
            this.btnTShowAll.UseVisualStyleBackColor = false;
            this.btnTShowAll.Click += new System.EventHandler(this.btnTShowAll_Click);
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "PURCHASE",
            "SALES"});
            this.cmbTransactionType.Location = new System.Drawing.Point(131, 70);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(298, 25);
            this.cmbTransactionType.TabIndex = 6;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.btnTShowAll);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.pnlTopTransaction);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.pnlTopTransaction.ResumeLayout(false);
            this.pnlTopTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopTransaction;
        private System.Windows.Forms.Label lblTopTransaction;
        private System.Windows.Forms.PictureBox pboxTransaction;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Button btnTShowAll;
        private System.Windows.Forms.ComboBox cmbTransactionType;
    }
}