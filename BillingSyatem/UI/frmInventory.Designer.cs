namespace BillingSyatem.UI
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.pnlTopInventory = new System.Windows.Forms.Panel();
            this.lblTopInventory = new System.Windows.Forms.Label();
            this.pboxInventory = new System.Windows.Forms.PictureBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnIShowAll = new System.Windows.Forms.Button();
            this.lblCategories = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.pnlTopInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopInventory
            // 
            this.pnlTopInventory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTopInventory.Controls.Add(this.lblTopInventory);
            this.pnlTopInventory.Controls.Add(this.pboxInventory);
            this.pnlTopInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopInventory.Location = new System.Drawing.Point(0, 0);
            this.pnlTopInventory.Name = "pnlTopInventory";
            this.pnlTopInventory.Size = new System.Drawing.Size(797, 32);
            this.pnlTopInventory.TabIndex = 7;
            // 
            // lblTopInventory
            // 
            this.lblTopInventory.AutoSize = true;
            this.lblTopInventory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopInventory.Location = new System.Drawing.Point(342, 9);
            this.lblTopInventory.Name = "lblTopInventory";
            this.lblTopInventory.Size = new System.Drawing.Size(82, 17);
            this.lblTopInventory.TabIndex = 1;
            this.lblTopInventory.Text = "INVENTORY";
            // 
            // pboxInventory
            // 
            this.pboxInventory.Image = ((System.Drawing.Image)(resources.GetObject("pboxInventory.Image")));
            this.pboxInventory.Location = new System.Drawing.Point(758, 0);
            this.pboxInventory.Name = "pboxInventory";
            this.pboxInventory.Size = new System.Drawing.Size(39, 32);
            this.pboxInventory.TabIndex = 0;
            this.pboxInventory.TabStop = false;
            this.pboxInventory.Click += new System.EventHandler(this.pboxInventory_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(83, 59);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(344, 25);
            this.cmbCategories.TabIndex = 11;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // btnIShowAll
            // 
            this.btnIShowAll.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIShowAll.ForeColor = System.Drawing.Color.White;
            this.btnIShowAll.Location = new System.Drawing.Point(433, 55);
            this.btnIShowAll.Name = "btnIShowAll";
            this.btnIShowAll.Size = new System.Drawing.Size(95, 31);
            this.btnIShowAll.TabIndex = 10;
            this.btnIShowAll.Text = "Show All";
            this.btnIShowAll.UseVisualStyleBackColor = false;
            this.btnIShowAll.Click += new System.EventHandler(this.btnIShowAll_Click);
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.Location = new System.Drawing.Point(10, 62);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(67, 17);
            this.lblCategories.TabIndex = 9;
            this.lblCategories.Text = "Category:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(12, 107);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.Size = new System.Drawing.Size(773, 343);
            this.dgvInventory.TabIndex = 8;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.pnlTopInventory);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnIShowAll);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.dgvInventory);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.pnlTopInventory.ResumeLayout(false);
            this.pnlTopInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopInventory;
        private System.Windows.Forms.Label lblTopInventory;
        private System.Windows.Forms.PictureBox pboxInventory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnIShowAll;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.DataGridView dgvInventory;
    }
}