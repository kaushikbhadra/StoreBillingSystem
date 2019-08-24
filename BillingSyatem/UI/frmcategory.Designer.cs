namespace BillingSyatem.UI
{
    partial class frmcategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcategory));
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcategoryID = new System.Windows.Forms.Label();
            this.txtcategoryID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblctgDescription = new System.Windows.Forms.Label();
            this.lblCateTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnctgADD = new System.Windows.Forms.Button();
            this.btnctgUpdate = new System.Windows.Forms.Button();
            this.btnctgDelete = new System.Windows.Forms.Button();
            this.lblctgSearch = new System.Windows.Forms.Label();
            this.txtctgSearch = new System.Windows.Forms.TextBox();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCategory
            // 
            this.pnlCategory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlCategory.Controls.Add(this.label1);
            this.pnlCategory.Controls.Add(this.pictureBox1);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(797, 32);
            this.pnlCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CATEGORIES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(758, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblcategoryID
            // 
            this.lblcategoryID.AutoSize = true;
            this.lblcategoryID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoryID.Location = new System.Drawing.Point(13, 75);
            this.lblcategoryID.Name = "lblcategoryID";
            this.lblcategoryID.Size = new System.Drawing.Size(77, 17);
            this.lblcategoryID.TabIndex = 1;
            this.lblcategoryID.Text = "CategoryID";
            // 
            // txtcategoryID
            // 
            this.txtcategoryID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryID.Location = new System.Drawing.Point(112, 75);
            this.txtcategoryID.Name = "txtcategoryID";
            this.txtcategoryID.ReadOnly = true;
            this.txtcategoryID.Size = new System.Drawing.Size(238, 25);
            this.txtcategoryID.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(112, 177);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(238, 97);
            this.txtDescription.TabIndex = 4;
            // 
            // lblctgDescription
            // 
            this.lblctgDescription.AutoSize = true;
            this.lblctgDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctgDescription.Location = new System.Drawing.Point(13, 177);
            this.lblctgDescription.Name = "lblctgDescription";
            this.lblctgDescription.Size = new System.Drawing.Size(76, 17);
            this.lblctgDescription.TabIndex = 3;
            this.lblctgDescription.Text = "Description";
            // 
            // lblCateTitle
            // 
            this.lblCateTitle.AutoSize = true;
            this.lblCateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateTitle.Location = new System.Drawing.Point(13, 121);
            this.lblCateTitle.Name = "lblCateTitle";
            this.lblCateTitle.Size = new System.Drawing.Size(33, 17);
            this.lblCateTitle.TabIndex = 3;
            this.lblCateTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(112, 121);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(238, 25);
            this.txtTitle.TabIndex = 4;
            // 
            // btnctgADD
            // 
            this.btnctgADD.BackColor = System.Drawing.Color.DarkGreen;
            this.btnctgADD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctgADD.ForeColor = System.Drawing.Color.White;
            this.btnctgADD.Location = new System.Drawing.Point(116, 419);
            this.btnctgADD.Name = "btnctgADD";
            this.btnctgADD.Size = new System.Drawing.Size(145, 31);
            this.btnctgADD.TabIndex = 5;
            this.btnctgADD.Text = "ADD";
            this.btnctgADD.UseVisualStyleBackColor = false;
            this.btnctgADD.Click += new System.EventHandler(this.btnctgADD_Click);
            // 
            // btnctgUpdate
            // 
            this.btnctgUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btnctgUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctgUpdate.ForeColor = System.Drawing.Color.White;
            this.btnctgUpdate.Location = new System.Drawing.Point(307, 419);
            this.btnctgUpdate.Name = "btnctgUpdate";
            this.btnctgUpdate.Size = new System.Drawing.Size(145, 31);
            this.btnctgUpdate.TabIndex = 6;
            this.btnctgUpdate.Text = "UPDATE";
            this.btnctgUpdate.UseVisualStyleBackColor = false;
            this.btnctgUpdate.Click += new System.EventHandler(this.btnctgUpdate_Click);
            // 
            // btnctgDelete
            // 
            this.btnctgDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnctgDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnctgDelete.ForeColor = System.Drawing.Color.White;
            this.btnctgDelete.Location = new System.Drawing.Point(511, 419);
            this.btnctgDelete.Name = "btnctgDelete";
            this.btnctgDelete.Size = new System.Drawing.Size(145, 31);
            this.btnctgDelete.TabIndex = 7;
            this.btnctgDelete.Text = "DELETE";
            this.btnctgDelete.UseVisualStyleBackColor = false;
            this.btnctgDelete.Click += new System.EventHandler(this.btnctgDelete_Click);
            // 
            // lblctgSearch
            // 
            this.lblctgSearch.AutoSize = true;
            this.lblctgSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblctgSearch.Location = new System.Drawing.Point(373, 78);
            this.lblctgSearch.Name = "lblctgSearch";
            this.lblctgSearch.Size = new System.Drawing.Size(48, 17);
            this.lblctgSearch.TabIndex = 8;
            this.lblctgSearch.Text = "Search";
            // 
            // txtctgSearch
            // 
            this.txtctgSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtctgSearch.Location = new System.Drawing.Point(427, 75);
            this.txtctgSearch.Name = "txtctgSearch";
            this.txtctgSearch.Size = new System.Drawing.Size(358, 25);
            this.txtctgSearch.TabIndex = 9;
            this.txtctgSearch.TextChanged += new System.EventHandler(this.txtctgSearch_TextChanged);
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(376, 121);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(409, 274);
            this.dgvCategory.TabIndex = 10;
            this.dgvCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCategory_RowHeaderMouseClick);
            // 
            // frmcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.txtctgSearch);
            this.Controls.Add(this.lblctgSearch);
            this.Controls.Add(this.btnctgDelete);
            this.Controls.Add(this.btnctgUpdate);
            this.Controls.Add(this.btnctgADD);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblCateTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblctgDescription);
            this.Controls.Add(this.txtcategoryID);
            this.Controls.Add(this.lblcategoryID);
            this.Controls.Add(this.pnlCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcategory";
            this.Load += new System.EventHandler(this.frmcategory_Load);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcategoryID;
        private System.Windows.Forms.TextBox txtcategoryID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblctgDescription;
        private System.Windows.Forms.Label lblCateTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnctgADD;
        private System.Windows.Forms.Button btnctgUpdate;
        private System.Windows.Forms.Button btnctgDelete;
        private System.Windows.Forms.Label lblctgSearch;
        private System.Windows.Forms.TextBox txtctgSearch;
        private System.Windows.Forms.DataGridView dgvCategory;
    }
}