namespace BillingSyatem.UI
{
    partial class frmdeaCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdeaCus));
            this.pnldealerCustomer = new System.Windows.Forms.Panel();
            this.lblDC = new System.Windows.Forms.Label();
            this.pboxDecCus = new System.Windows.Forms.PictureBox();
            this.cmbdcType = new System.Windows.Forms.ComboBox();
            this.txtdcID = new System.Windows.Forms.TextBox();
            this.lblDeaCusID = new System.Windows.Forms.Label();
            this.lbldcType = new System.Windows.Forms.Label();
            this.lbldcName = new System.Windows.Forms.Label();
            this.lbldcEmail = new System.Windows.Forms.Label();
            this.lbldcContact = new System.Windows.Forms.Label();
            this.lbldcaddress = new System.Windows.Forms.Label();
            this.txtdcName = new System.Windows.Forms.TextBox();
            this.txtdcEmail = new System.Windows.Forms.TextBox();
            this.txtdcContact = new System.Windows.Forms.TextBox();
            this.txtdcAddress = new System.Windows.Forms.TextBox();
            this.txtdcSearch = new System.Windows.Forms.TextBox();
            this.lbldcSearch = new System.Windows.Forms.Label();
            this.dgvDeaCus = new System.Windows.Forms.DataGridView();
            this.btndcADD = new System.Windows.Forms.Button();
            this.btndcUpdate = new System.Windows.Forms.Button();
            this.btndcDelete = new System.Windows.Forms.Button();
            this.pnldealerCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDecCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCus)).BeginInit();
            this.SuspendLayout();
            // 
            // pnldealerCustomer
            // 
            this.pnldealerCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnldealerCustomer.Controls.Add(this.lblDC);
            this.pnldealerCustomer.Controls.Add(this.pboxDecCus);
            this.pnldealerCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnldealerCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnldealerCustomer.Name = "pnldealerCustomer";
            this.pnldealerCustomer.Size = new System.Drawing.Size(797, 32);
            this.pnldealerCustomer.TabIndex = 0;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(325, 9);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(162, 17);
            this.lblDC.TabIndex = 1;
            this.lblDC.Text = "DEALER AND CUSTOMER\r\n";
            // 
            // pboxDecCus
            // 
            this.pboxDecCus.Image = ((System.Drawing.Image)(resources.GetObject("pboxDecCus.Image")));
            this.pboxDecCus.Location = new System.Drawing.Point(758, 0);
            this.pboxDecCus.Name = "pboxDecCus";
            this.pboxDecCus.Size = new System.Drawing.Size(39, 32);
            this.pboxDecCus.TabIndex = 0;
            this.pboxDecCus.TabStop = false;
            this.pboxDecCus.Click += new System.EventHandler(this.pboxDecCus_Click);
            // 
            // cmbdcType
            // 
            this.cmbdcType.FormattingEnabled = true;
            this.cmbdcType.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbdcType.Location = new System.Drawing.Point(110, 96);
            this.cmbdcType.Name = "cmbdcType";
            this.cmbdcType.Size = new System.Drawing.Size(199, 25);
            this.cmbdcType.TabIndex = 1;
            // 
            // txtdcID
            // 
            this.txtdcID.Location = new System.Drawing.Point(110, 51);
            this.txtdcID.Name = "txtdcID";
            this.txtdcID.ReadOnly = true;
            this.txtdcID.Size = new System.Drawing.Size(199, 25);
            this.txtdcID.TabIndex = 2;
            // 
            // lblDeaCusID
            // 
            this.lblDeaCusID.AutoSize = true;
            this.lblDeaCusID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCusID.Location = new System.Drawing.Point(12, 54);
            this.lblDeaCusID.Name = "lblDeaCusID";
            this.lblDeaCusID.Size = new System.Drawing.Size(70, 17);
            this.lblDeaCusID.TabIndex = 3;
            this.lblDeaCusID.Text = "DeaCus ID";
            // 
            // lbldcType
            // 
            this.lbldcType.AutoSize = true;
            this.lbldcType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcType.Location = new System.Drawing.Point(12, 99);
            this.lbldcType.Name = "lbldcType";
            this.lbldcType.Size = new System.Drawing.Size(36, 17);
            this.lbldcType.TabIndex = 4;
            this.lbldcType.Text = "Type";
            // 
            // lbldcName
            // 
            this.lbldcName.AutoSize = true;
            this.lbldcName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcName.Location = new System.Drawing.Point(12, 147);
            this.lbldcName.Name = "lbldcName";
            this.lbldcName.Size = new System.Drawing.Size(44, 17);
            this.lbldcName.TabIndex = 5;
            this.lbldcName.Text = "Name";
            // 
            // lbldcEmail
            // 
            this.lbldcEmail.AutoSize = true;
            this.lbldcEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcEmail.Location = new System.Drawing.Point(12, 199);
            this.lbldcEmail.Name = "lbldcEmail";
            this.lbldcEmail.Size = new System.Drawing.Size(40, 17);
            this.lbldcEmail.TabIndex = 6;
            this.lbldcEmail.Text = "Email";
            // 
            // lbldcContact
            // 
            this.lbldcContact.AutoSize = true;
            this.lbldcContact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcContact.Location = new System.Drawing.Point(12, 248);
            this.lbldcContact.Name = "lbldcContact";
            this.lbldcContact.Size = new System.Drawing.Size(55, 17);
            this.lbldcContact.TabIndex = 7;
            this.lbldcContact.Text = "Contact";
            // 
            // lbldcaddress
            // 
            this.lbldcaddress.AutoSize = true;
            this.lbldcaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcaddress.Location = new System.Drawing.Point(12, 290);
            this.lbldcaddress.Name = "lbldcaddress";
            this.lbldcaddress.Size = new System.Drawing.Size(57, 17);
            this.lbldcaddress.TabIndex = 8;
            this.lbldcaddress.Text = "Address";
            // 
            // txtdcName
            // 
            this.txtdcName.Location = new System.Drawing.Point(110, 144);
            this.txtdcName.Name = "txtdcName";
            this.txtdcName.Size = new System.Drawing.Size(199, 25);
            this.txtdcName.TabIndex = 9;
            // 
            // txtdcEmail
            // 
            this.txtdcEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdcEmail.Location = new System.Drawing.Point(110, 196);
            this.txtdcEmail.Name = "txtdcEmail";
            this.txtdcEmail.Size = new System.Drawing.Size(199, 25);
            this.txtdcEmail.TabIndex = 10;
            // 
            // txtdcContact
            // 
            this.txtdcContact.Location = new System.Drawing.Point(110, 245);
            this.txtdcContact.Name = "txtdcContact";
            this.txtdcContact.Size = new System.Drawing.Size(199, 25);
            this.txtdcContact.TabIndex = 11;
            // 
            // txtdcAddress
            // 
            this.txtdcAddress.Location = new System.Drawing.Point(110, 287);
            this.txtdcAddress.Multiline = true;
            this.txtdcAddress.Name = "txtdcAddress";
            this.txtdcAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdcAddress.Size = new System.Drawing.Size(199, 76);
            this.txtdcAddress.TabIndex = 12;
            // 
            // txtdcSearch
            // 
            this.txtdcSearch.Location = new System.Drawing.Point(433, 54);
            this.txtdcSearch.Name = "txtdcSearch";
            this.txtdcSearch.Size = new System.Drawing.Size(352, 25);
            this.txtdcSearch.TabIndex = 13;
            this.txtdcSearch.TextChanged += new System.EventHandler(this.txtdcSearch_TextChanged);
            // 
            // lbldcSearch
            // 
            this.lbldcSearch.AutoSize = true;
            this.lbldcSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldcSearch.Location = new System.Drawing.Point(365, 57);
            this.lbldcSearch.Name = "lbldcSearch";
            this.lbldcSearch.Size = new System.Drawing.Size(48, 17);
            this.lbldcSearch.TabIndex = 14;
            this.lbldcSearch.Text = "Search";
            // 
            // dgvDeaCus
            // 
            this.dgvDeaCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeaCus.Location = new System.Drawing.Point(344, 96);
            this.dgvDeaCus.Name = "dgvDeaCus";
            this.dgvDeaCus.Size = new System.Drawing.Size(441, 267);
            this.dgvDeaCus.TabIndex = 15;
            this.dgvDeaCus.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCus_RowHeaderMouseClick);
            // 
            // btndcADD
            // 
            this.btndcADD.BackColor = System.Drawing.Color.DarkGreen;
            this.btndcADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndcADD.ForeColor = System.Drawing.Color.White;
            this.btndcADD.Location = new System.Drawing.Point(110, 392);
            this.btndcADD.Name = "btndcADD";
            this.btndcADD.Size = new System.Drawing.Size(147, 34);
            this.btndcADD.TabIndex = 16;
            this.btndcADD.Text = "ADD";
            this.btndcADD.UseVisualStyleBackColor = false;
            this.btndcADD.Click += new System.EventHandler(this.btndcADD_Click);
            // 
            // btndcUpdate
            // 
            this.btndcUpdate.BackColor = System.Drawing.Color.DarkBlue;
            this.btndcUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndcUpdate.ForeColor = System.Drawing.Color.White;
            this.btndcUpdate.Location = new System.Drawing.Point(313, 392);
            this.btndcUpdate.Name = "btndcUpdate";
            this.btndcUpdate.Size = new System.Drawing.Size(138, 34);
            this.btndcUpdate.TabIndex = 17;
            this.btndcUpdate.Text = "UPDATE";
            this.btndcUpdate.UseVisualStyleBackColor = false;
            this.btndcUpdate.Click += new System.EventHandler(this.btndcUpdate_Click);
            // 
            // btndcDelete
            // 
            this.btndcDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btndcDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndcDelete.ForeColor = System.Drawing.Color.White;
            this.btndcDelete.Location = new System.Drawing.Point(509, 392);
            this.btndcDelete.Name = "btndcDelete";
            this.btndcDelete.Size = new System.Drawing.Size(139, 34);
            this.btndcDelete.TabIndex = 18;
            this.btndcDelete.Text = "DELETE";
            this.btndcDelete.UseVisualStyleBackColor = false;
            this.btndcDelete.Click += new System.EventHandler(this.btndcDelete_Click);
            // 
            // frmdeaCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(797, 462);
            this.Controls.Add(this.btndcDelete);
            this.Controls.Add(this.btndcUpdate);
            this.Controls.Add(this.btndcADD);
            this.Controls.Add(this.dgvDeaCus);
            this.Controls.Add(this.lbldcSearch);
            this.Controls.Add(this.txtdcSearch);
            this.Controls.Add(this.txtdcAddress);
            this.Controls.Add(this.txtdcContact);
            this.Controls.Add(this.txtdcEmail);
            this.Controls.Add(this.txtdcName);
            this.Controls.Add(this.lbldcaddress);
            this.Controls.Add(this.lbldcContact);
            this.Controls.Add(this.lbldcEmail);
            this.Controls.Add(this.lbldcName);
            this.Controls.Add(this.lbldcType);
            this.Controls.Add(this.lblDeaCusID);
            this.Controls.Add(this.txtdcID);
            this.Controls.Add(this.cmbdcType);
            this.Controls.Add(this.pnldealerCustomer);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmdeaCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdeaCus";
            this.Load += new System.EventHandler(this.frmdeaCus_Load);
            this.pnldealerCustomer.ResumeLayout(false);
            this.pnldealerCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDecCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnldealerCustomer;
        private System.Windows.Forms.PictureBox pboxDecCus;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.ComboBox cmbdcType;
        private System.Windows.Forms.TextBox txtdcID;
        private System.Windows.Forms.Label lblDeaCusID;
        private System.Windows.Forms.Label lbldcType;
        private System.Windows.Forms.Label lbldcName;
        private System.Windows.Forms.Label lbldcEmail;
        private System.Windows.Forms.Label lbldcContact;
        private System.Windows.Forms.Label lbldcaddress;
        private System.Windows.Forms.TextBox txtdcName;
        private System.Windows.Forms.TextBox txtdcEmail;
        private System.Windows.Forms.TextBox txtdcContact;
        private System.Windows.Forms.TextBox txtdcAddress;
        private System.Windows.Forms.TextBox txtdcSearch;
        private System.Windows.Forms.Label lbldcSearch;
        private System.Windows.Forms.DataGridView dgvDeaCus;
        private System.Windows.Forms.Button btndcADD;
        private System.Windows.Forms.Button btndcUpdate;
        private System.Windows.Forms.Button btndcDelete;
    }
}