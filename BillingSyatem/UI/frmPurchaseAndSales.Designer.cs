namespace BillingSyatem.UI
{
    partial class frmPurchaseAndSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.pnlTopPurcSale = new System.Windows.Forms.Panel();
            this.pbPueSal = new System.Windows.Forms.PictureBox();
            this.lblTopPurcSale = new System.Windows.Forms.Label();
            this.pnlDeaCus = new System.Windows.Forms.Panel();
            this.txtPSDeaCusName = new System.Windows.Forms.TextBox();
            this.txtPSDeaCusContact = new System.Windows.Forms.TextBox();
            this.txtPSDeaCusEmail = new System.Windows.Forms.TextBox();
            this.txtPSDeaCusAddress = new System.Windows.Forms.TextBox();
            this.txtPSDeaCusSearch = new System.Windows.Forms.TextBox();
            this.DTPSDeaCusDatetime = new System.Windows.Forms.DateTimePicker();
            this.lblPSDeaCusBillDate = new System.Windows.Forms.Label();
            this.lblPSDeaCusAddress = new System.Windows.Forms.Label();
            this.lblPSDeaCusEmail = new System.Windows.Forms.Label();
            this.lblPSDeaCusContact = new System.Windows.Forms.Label();
            this.lblPSDeaCusName = new System.Windows.Forms.Label();
            this.lblPSDeaCusSearch = new System.Windows.Forms.Label();
            this.lblPSDeaCus = new System.Windows.Forms.Label();
            this.pnlProDetails = new System.Windows.Forms.Panel();
            this.txtPSPDInventory = new System.Windows.Forms.TextBox();
            this.txtPSPDName = new System.Windows.Forms.TextBox();
            this.txtPSPDQty = new System.Windows.Forms.TextBox();
            this.txtPSPDRate = new System.Windows.Forms.TextBox();
            this.txtPSPDSearch = new System.Windows.Forms.TextBox();
            this.btnPSPDADD = new System.Windows.Forms.Button();
            this.lblPSPDQty = new System.Windows.Forms.Label();
            this.lblPSPDRate = new System.Windows.Forms.Label();
            this.lblPSPDInventory = new System.Windows.Forms.Label();
            this.lblPSPDNamme = new System.Windows.Forms.Label();
            this.lblPSPDSearch = new System.Windows.Forms.Label();
            this.lblPSProDetails = new System.Windows.Forms.Label();
            this.pnlDgvAddedProduct = new System.Windows.Forms.Panel();
            this.dgvPSAddedProduct = new System.Windows.Forms.DataGridView();
            this.lblPSAddedProduct = new System.Windows.Forms.Label();
            this.pnlPSCalculation = new System.Windows.Forms.Panel();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.txtPSCDRetAmut = new System.Windows.Forms.TextBox();
            this.txtPSCDpaidamount = new System.Windows.Forms.TextBox();
            this.txtPSCDDiscount = new System.Windows.Forms.TextBox();
            this.txtPSCDVat = new System.Windows.Forms.TextBox();
            this.txtPSCDGrandTotal = new System.Windows.Forms.TextBox();
            this.txtPSCDSubtotal = new System.Windows.Forms.TextBox();
            this.lblPSCDRetunAmont = new System.Windows.Forms.Label();
            this.lblPSCDPaid_Amount = new System.Windows.Forms.Label();
            this.lblPSCDGrand_Total = new System.Windows.Forms.Label();
            this.lblPSCDVAT = new System.Windows.Forms.Label();
            this.lblPSCDDiscount = new System.Windows.Forms.Label();
            this.lblPSCDSubtotal = new System.Windows.Forms.Label();
            this.lblPSCalculation = new System.Windows.Forms.Label();
            this.pnlTopPurcSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPueSal)).BeginInit();
            this.pnlDeaCus.SuspendLayout();
            this.pnlProDetails.SuspendLayout();
            this.pnlDgvAddedProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPSAddedProduct)).BeginInit();
            this.pnlPSCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPurcSale
            // 
            this.pnlTopPurcSale.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTopPurcSale.Controls.Add(this.pbPueSal);
            this.pnlTopPurcSale.Controls.Add(this.lblTopPurcSale);
            this.pnlTopPurcSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPurcSale.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPurcSale.Name = "pnlTopPurcSale";
            this.pnlTopPurcSale.Size = new System.Drawing.Size(1272, 32);
            this.pnlTopPurcSale.TabIndex = 0;
            // 
            // pbPueSal
            // 
            this.pbPueSal.Image = ((System.Drawing.Image)(resources.GetObject("pbPueSal.Image")));
            this.pbPueSal.Location = new System.Drawing.Point(1233, 0);
            this.pbPueSal.Name = "pbPueSal";
            this.pbPueSal.Size = new System.Drawing.Size(39, 32);
            this.pbPueSal.TabIndex = 1;
            this.pbPueSal.TabStop = false;
            this.pbPueSal.Click += new System.EventHandler(this.pbPueSal_Click);
            // 
            // lblTopPurcSale
            // 
            this.lblTopPurcSale.AutoSize = true;
            this.lblTopPurcSale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPurcSale.Location = new System.Drawing.Point(591, 9);
            this.lblTopPurcSale.Name = "lblTopPurcSale";
            this.lblTopPurcSale.Size = new System.Drawing.Size(148, 17);
            this.lblTopPurcSale.TabIndex = 0;
            this.lblTopPurcSale.Text = "PURCHASE AND SALES";
            // 
            // pnlDeaCus
            // 
            this.pnlDeaCus.Controls.Add(this.txtPSDeaCusName);
            this.pnlDeaCus.Controls.Add(this.txtPSDeaCusContact);
            this.pnlDeaCus.Controls.Add(this.txtPSDeaCusEmail);
            this.pnlDeaCus.Controls.Add(this.txtPSDeaCusAddress);
            this.pnlDeaCus.Controls.Add(this.txtPSDeaCusSearch);
            this.pnlDeaCus.Controls.Add(this.DTPSDeaCusDatetime);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusBillDate);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusAddress);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusEmail);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusContact);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusName);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCusSearch);
            this.pnlDeaCus.Controls.Add(this.lblPSDeaCus);
            this.pnlDeaCus.Location = new System.Drawing.Point(0, 31);
            this.pnlDeaCus.Name = "pnlDeaCus";
            this.pnlDeaCus.Size = new System.Drawing.Size(1269, 113);
            this.pnlDeaCus.TabIndex = 1;
            // 
            // txtPSDeaCusName
            // 
            this.txtPSDeaCusName.Location = new System.Drawing.Point(76, 78);
            this.txtPSDeaCusName.Name = "txtPSDeaCusName";
            this.txtPSDeaCusName.Size = new System.Drawing.Size(245, 25);
            this.txtPSDeaCusName.TabIndex = 12;
            // 
            // txtPSDeaCusContact
            // 
            this.txtPSDeaCusContact.Location = new System.Drawing.Point(401, 78);
            this.txtPSDeaCusContact.Name = "txtPSDeaCusContact";
            this.txtPSDeaCusContact.Size = new System.Drawing.Size(245, 25);
            this.txtPSDeaCusContact.TabIndex = 11;
            // 
            // txtPSDeaCusEmail
            // 
            this.txtPSDeaCusEmail.Location = new System.Drawing.Point(401, 35);
            this.txtPSDeaCusEmail.Name = "txtPSDeaCusEmail";
            this.txtPSDeaCusEmail.Size = new System.Drawing.Size(245, 25);
            this.txtPSDeaCusEmail.TabIndex = 10;
            // 
            // txtPSDeaCusAddress
            // 
            this.txtPSDeaCusAddress.Location = new System.Drawing.Point(731, 35);
            this.txtPSDeaCusAddress.Multiline = true;
            this.txtPSDeaCusAddress.Name = "txtPSDeaCusAddress";
            this.txtPSDeaCusAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPSDeaCusAddress.Size = new System.Drawing.Size(245, 68);
            this.txtPSDeaCusAddress.TabIndex = 9;
            // 
            // txtPSDeaCusSearch
            // 
            this.txtPSDeaCusSearch.Location = new System.Drawing.Point(76, 35);
            this.txtPSDeaCusSearch.Name = "txtPSDeaCusSearch";
            this.txtPSDeaCusSearch.Size = new System.Drawing.Size(245, 25);
            this.txtPSDeaCusSearch.TabIndex = 8;
            this.txtPSDeaCusSearch.TextChanged += new System.EventHandler(this.txtPSDeaCusSearch_TextChanged);
            // 
            // DTPSDeaCusDatetime
            // 
            this.DTPSDeaCusDatetime.Location = new System.Drawing.Point(1060, 32);
            this.DTPSDeaCusDatetime.Name = "DTPSDeaCusDatetime";
            this.DTPSDeaCusDatetime.Size = new System.Drawing.Size(200, 25);
            this.DTPSDeaCusDatetime.TabIndex = 7;
            // 
            // lblPSDeaCusBillDate
            // 
            this.lblPSDeaCusBillDate.AutoSize = true;
            this.lblPSDeaCusBillDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusBillDate.Location = new System.Drawing.Point(997, 35);
            this.lblPSDeaCusBillDate.Name = "lblPSDeaCusBillDate";
            this.lblPSDeaCusBillDate.Size = new System.Drawing.Size(57, 17);
            this.lblPSDeaCusBillDate.TabIndex = 6;
            this.lblPSDeaCusBillDate.Text = "Bill Date";
            // 
            // lblPSDeaCusAddress
            // 
            this.lblPSDeaCusAddress.AutoSize = true;
            this.lblPSDeaCusAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusAddress.Location = new System.Drawing.Point(668, 38);
            this.lblPSDeaCusAddress.Name = "lblPSDeaCusAddress";
            this.lblPSDeaCusAddress.Size = new System.Drawing.Size(57, 17);
            this.lblPSDeaCusAddress.TabIndex = 5;
            this.lblPSDeaCusAddress.Text = "Address";
            // 
            // lblPSDeaCusEmail
            // 
            this.lblPSDeaCusEmail.AutoSize = true;
            this.lblPSDeaCusEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusEmail.Location = new System.Drawing.Point(340, 35);
            this.lblPSDeaCusEmail.Name = "lblPSDeaCusEmail";
            this.lblPSDeaCusEmail.Size = new System.Drawing.Size(40, 17);
            this.lblPSDeaCusEmail.TabIndex = 4;
            this.lblPSDeaCusEmail.Text = "Email";
            // 
            // lblPSDeaCusContact
            // 
            this.lblPSDeaCusContact.AutoSize = true;
            this.lblPSDeaCusContact.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusContact.Location = new System.Drawing.Point(340, 81);
            this.lblPSDeaCusContact.Name = "lblPSDeaCusContact";
            this.lblPSDeaCusContact.Size = new System.Drawing.Size(55, 17);
            this.lblPSDeaCusContact.TabIndex = 3;
            this.lblPSDeaCusContact.Text = "Contact";
            // 
            // lblPSDeaCusName
            // 
            this.lblPSDeaCusName.AutoSize = true;
            this.lblPSDeaCusName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusName.Location = new System.Drawing.Point(6, 81);
            this.lblPSDeaCusName.Name = "lblPSDeaCusName";
            this.lblPSDeaCusName.Size = new System.Drawing.Size(44, 17);
            this.lblPSDeaCusName.TabIndex = 2;
            this.lblPSDeaCusName.Text = "Name";
            // 
            // lblPSDeaCusSearch
            // 
            this.lblPSDeaCusSearch.AutoSize = true;
            this.lblPSDeaCusSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCusSearch.Location = new System.Drawing.Point(6, 35);
            this.lblPSDeaCusSearch.Name = "lblPSDeaCusSearch";
            this.lblPSDeaCusSearch.Size = new System.Drawing.Size(48, 17);
            this.lblPSDeaCusSearch.TabIndex = 1;
            this.lblPSDeaCusSearch.Text = "Search";
            // 
            // lblPSDeaCus
            // 
            this.lblPSDeaCus.AutoSize = true;
            this.lblPSDeaCus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSDeaCus.Location = new System.Drawing.Point(3, 4);
            this.lblPSDeaCus.Name = "lblPSDeaCus";
            this.lblPSDeaCus.Size = new System.Drawing.Size(185, 17);
            this.lblPSDeaCus.TabIndex = 0;
            this.lblPSDeaCus.Text = "Dealer and Customer Details";
            // 
            // pnlProDetails
            // 
            this.pnlProDetails.Controls.Add(this.txtPSPDInventory);
            this.pnlProDetails.Controls.Add(this.txtPSPDName);
            this.pnlProDetails.Controls.Add(this.txtPSPDQty);
            this.pnlProDetails.Controls.Add(this.txtPSPDRate);
            this.pnlProDetails.Controls.Add(this.txtPSPDSearch);
            this.pnlProDetails.Controls.Add(this.btnPSPDADD);
            this.pnlProDetails.Controls.Add(this.lblPSPDQty);
            this.pnlProDetails.Controls.Add(this.lblPSPDRate);
            this.pnlProDetails.Controls.Add(this.lblPSPDInventory);
            this.pnlProDetails.Controls.Add(this.lblPSPDNamme);
            this.pnlProDetails.Controls.Add(this.lblPSPDSearch);
            this.pnlProDetails.Controls.Add(this.lblPSProDetails);
            this.pnlProDetails.Location = new System.Drawing.Point(3, 150);
            this.pnlProDetails.Name = "pnlProDetails";
            this.pnlProDetails.Size = new System.Drawing.Size(1269, 76);
            this.pnlProDetails.TabIndex = 2;
            // 
            // txtPSPDInventory
            // 
            this.txtPSPDInventory.Location = new System.Drawing.Point(591, 39);
            this.txtPSPDInventory.Name = "txtPSPDInventory";
            this.txtPSPDInventory.Size = new System.Drawing.Size(131, 25);
            this.txtPSPDInventory.TabIndex = 11;
            // 
            // txtPSPDName
            // 
            this.txtPSPDName.Location = new System.Drawing.Point(340, 39);
            this.txtPSPDName.Name = "txtPSPDName";
            this.txtPSPDName.Size = new System.Drawing.Size(171, 25);
            this.txtPSPDName.TabIndex = 10;
            // 
            // txtPSPDQty
            // 
            this.txtPSPDQty.Location = new System.Drawing.Point(975, 39);
            this.txtPSPDQty.Name = "txtPSPDQty";
            this.txtPSPDQty.Size = new System.Drawing.Size(111, 25);
            this.txtPSPDQty.TabIndex = 9;
            // 
            // txtPSPDRate
            // 
            this.txtPSPDRate.Location = new System.Drawing.Point(777, 39);
            this.txtPSPDRate.Name = "txtPSPDRate";
            this.txtPSPDRate.Size = new System.Drawing.Size(137, 25);
            this.txtPSPDRate.TabIndex = 8;
            // 
            // txtPSPDSearch
            // 
            this.txtPSPDSearch.Location = new System.Drawing.Point(73, 39);
            this.txtPSPDSearch.Name = "txtPSPDSearch";
            this.txtPSPDSearch.Size = new System.Drawing.Size(191, 25);
            this.txtPSPDSearch.TabIndex = 7;
            this.txtPSPDSearch.TextChanged += new System.EventHandler(this.txtPSPDSearch_TextChanged);
            // 
            // btnPSPDADD
            // 
            this.btnPSPDADD.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPSPDADD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSPDADD.ForeColor = System.Drawing.Color.White;
            this.btnPSPDADD.Location = new System.Drawing.Point(1123, 27);
            this.btnPSPDADD.Name = "btnPSPDADD";
            this.btnPSPDADD.Size = new System.Drawing.Size(113, 37);
            this.btnPSPDADD.TabIndex = 6;
            this.btnPSPDADD.Text = "ADD";
            this.btnPSPDADD.UseVisualStyleBackColor = false;
            this.btnPSPDADD.Click += new System.EventHandler(this.btnPSPDADD_Click);
            // 
            // lblPSPDQty
            // 
            this.lblPSPDQty.AutoSize = true;
            this.lblPSPDQty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPDQty.Location = new System.Drawing.Point(929, 42);
            this.lblPSPDQty.Name = "lblPSPDQty";
            this.lblPSPDQty.Size = new System.Drawing.Size(30, 17);
            this.lblPSPDQty.TabIndex = 5;
            this.lblPSPDQty.Text = "Qty";
            // 
            // lblPSPDRate
            // 
            this.lblPSPDRate.AutoSize = true;
            this.lblPSPDRate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPDRate.Location = new System.Drawing.Point(736, 42);
            this.lblPSPDRate.Name = "lblPSPDRate";
            this.lblPSPDRate.Size = new System.Drawing.Size(35, 17);
            this.lblPSPDRate.TabIndex = 4;
            this.lblPSPDRate.Text = "Rate";
            // 
            // lblPSPDInventory
            // 
            this.lblPSPDInventory.AutoSize = true;
            this.lblPSPDInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPDInventory.Location = new System.Drawing.Point(517, 42);
            this.lblPSPDInventory.Name = "lblPSPDInventory";
            this.lblPSPDInventory.Size = new System.Drawing.Size(68, 17);
            this.lblPSPDInventory.TabIndex = 3;
            this.lblPSPDInventory.Text = "Inventory";
            // 
            // lblPSPDNamme
            // 
            this.lblPSPDNamme.AutoSize = true;
            this.lblPSPDNamme.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPDNamme.Location = new System.Drawing.Point(290, 42);
            this.lblPSPDNamme.Name = "lblPSPDNamme";
            this.lblPSPDNamme.Size = new System.Drawing.Size(44, 17);
            this.lblPSPDNamme.TabIndex = 2;
            this.lblPSPDNamme.Text = "Name";
            // 
            // lblPSPDSearch
            // 
            this.lblPSPDSearch.AutoSize = true;
            this.lblPSPDSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSPDSearch.Location = new System.Drawing.Point(9, 39);
            this.lblPSPDSearch.Name = "lblPSPDSearch";
            this.lblPSPDSearch.Size = new System.Drawing.Size(48, 17);
            this.lblPSPDSearch.TabIndex = 1;
            this.lblPSPDSearch.Text = "Search";
            // 
            // lblPSProDetails
            // 
            this.lblPSProDetails.AutoSize = true;
            this.lblPSProDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSProDetails.Location = new System.Drawing.Point(3, 9);
            this.lblPSProDetails.Name = "lblPSProDetails";
            this.lblPSProDetails.Size = new System.Drawing.Size(103, 17);
            this.lblPSProDetails.TabIndex = 0;
            this.lblPSProDetails.Text = "Product Details";
            // 
            // pnlDgvAddedProduct
            // 
            this.pnlDgvAddedProduct.Controls.Add(this.dgvPSAddedProduct);
            this.pnlDgvAddedProduct.Controls.Add(this.lblPSAddedProduct);
            this.pnlDgvAddedProduct.Location = new System.Drawing.Point(0, 233);
            this.pnlDgvAddedProduct.Name = "pnlDgvAddedProduct";
            this.pnlDgvAddedProduct.Size = new System.Drawing.Size(588, 333);
            this.pnlDgvAddedProduct.TabIndex = 3;
            // 
            // dgvPSAddedProduct
            // 
            this.dgvPSAddedProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPSAddedProduct.Location = new System.Drawing.Point(6, 39);
            this.dgvPSAddedProduct.Name = "dgvPSAddedProduct";
            this.dgvPSAddedProduct.Size = new System.Drawing.Size(579, 291);
            this.dgvPSAddedProduct.TabIndex = 1;
            // 
            // lblPSAddedProduct
            // 
            this.lblPSAddedProduct.AutoSize = true;
            this.lblPSAddedProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSAddedProduct.Location = new System.Drawing.Point(6, 9);
            this.lblPSAddedProduct.Name = "lblPSAddedProduct";
            this.lblPSAddedProduct.Size = new System.Drawing.Size(106, 17);
            this.lblPSAddedProduct.TabIndex = 0;
            this.lblPSAddedProduct.Text = "Added Products";
            // 
            // pnlPSCalculation
            // 
            this.pnlPSCalculation.Controls.Add(this.btnSaveAll);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDRetAmut);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDpaidamount);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDDiscount);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDVat);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDGrandTotal);
            this.pnlPSCalculation.Controls.Add(this.txtPSCDSubtotal);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDRetunAmont);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDPaid_Amount);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDGrand_Total);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDVAT);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDDiscount);
            this.pnlPSCalculation.Controls.Add(this.lblPSCDSubtotal);
            this.pnlPSCalculation.Controls.Add(this.lblPSCalculation);
            this.pnlPSCalculation.Location = new System.Drawing.Point(595, 233);
            this.pnlPSCalculation.Name = "pnlPSCalculation";
            this.pnlPSCalculation.Size = new System.Drawing.Size(674, 330);
            this.pnlPSCalculation.TabIndex = 4;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(531, 133);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(113, 46);
            this.btnSaveAll.TabIndex = 13;
            this.btnSaveAll.Text = "SAVE";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // txtPSCDRetAmut
            // 
            this.txtPSCDRetAmut.BackColor = System.Drawing.SystemColors.Control;
            this.txtPSCDRetAmut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSCDRetAmut.ForeColor = System.Drawing.Color.DarkRed;
            this.txtPSCDRetAmut.Location = new System.Drawing.Point(117, 250);
            this.txtPSCDRetAmut.Name = "txtPSCDRetAmut";
            this.txtPSCDRetAmut.ReadOnly = true;
            this.txtPSCDRetAmut.Size = new System.Drawing.Size(393, 39);
            this.txtPSCDRetAmut.TabIndex = 12;
            // 
            // txtPSCDpaidamount
            // 
            this.txtPSCDpaidamount.Location = new System.Drawing.Point(117, 204);
            this.txtPSCDpaidamount.Name = "txtPSCDpaidamount";
            this.txtPSCDpaidamount.Size = new System.Drawing.Size(393, 25);
            this.txtPSCDpaidamount.TabIndex = 11;
            this.txtPSCDpaidamount.TextChanged += new System.EventHandler(this.txtPSCDpaidamount_TextChanged);
            // 
            // txtPSCDDiscount
            // 
            this.txtPSCDDiscount.Location = new System.Drawing.Point(117, 80);
            this.txtPSCDDiscount.Name = "txtPSCDDiscount";
            this.txtPSCDDiscount.Size = new System.Drawing.Size(393, 25);
            this.txtPSCDDiscount.TabIndex = 10;
            this.txtPSCDDiscount.TextChanged += new System.EventHandler(this.txtPSCDDiscount_TextChanged);
            // 
            // txtPSCDVat
            // 
            this.txtPSCDVat.Location = new System.Drawing.Point(117, 116);
            this.txtPSCDVat.Name = "txtPSCDVat";
            this.txtPSCDVat.Size = new System.Drawing.Size(393, 25);
            this.txtPSCDVat.TabIndex = 9;
            this.txtPSCDVat.TextChanged += new System.EventHandler(this.txtPSCDVat_TextChanged);
            // 
            // txtPSCDGrandTotal
            // 
            this.txtPSCDGrandTotal.Location = new System.Drawing.Point(117, 154);
            this.txtPSCDGrandTotal.Name = "txtPSCDGrandTotal";
            this.txtPSCDGrandTotal.ReadOnly = true;
            this.txtPSCDGrandTotal.Size = new System.Drawing.Size(393, 25);
            this.txtPSCDGrandTotal.TabIndex = 8;
            // 
            // txtPSCDSubtotal
            // 
            this.txtPSCDSubtotal.Location = new System.Drawing.Point(117, 39);
            this.txtPSCDSubtotal.Name = "txtPSCDSubtotal";
            this.txtPSCDSubtotal.ReadOnly = true;
            this.txtPSCDSubtotal.Size = new System.Drawing.Size(393, 25);
            this.txtPSCDSubtotal.TabIndex = 7;
            this.txtPSCDSubtotal.Text = "0";
            // 
            // lblPSCDRetunAmont
            // 
            this.lblPSCDRetunAmont.AutoSize = true;
            this.lblPSCDRetunAmont.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDRetunAmont.Location = new System.Drawing.Point(7, 253);
            this.lblPSCDRetunAmont.Name = "lblPSCDRetunAmont";
            this.lblPSCDRetunAmont.Size = new System.Drawing.Size(104, 17);
            this.lblPSCDRetunAmont.TabIndex = 6;
            this.lblPSCDRetunAmont.Text = "Return-Amount";
            // 
            // lblPSCDPaid_Amount
            // 
            this.lblPSCDPaid_Amount.AutoSize = true;
            this.lblPSCDPaid_Amount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDPaid_Amount.Location = new System.Drawing.Point(7, 204);
            this.lblPSCDPaid_Amount.Name = "lblPSCDPaid_Amount";
            this.lblPSCDPaid_Amount.Size = new System.Drawing.Size(89, 17);
            this.lblPSCDPaid_Amount.TabIndex = 5;
            this.lblPSCDPaid_Amount.Text = "Paid-Amount";
            // 
            // lblPSCDGrand_Total
            // 
            this.lblPSCDGrand_Total.AutoSize = true;
            this.lblPSCDGrand_Total.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDGrand_Total.Location = new System.Drawing.Point(7, 157);
            this.lblPSCDGrand_Total.Name = "lblPSCDGrand_Total";
            this.lblPSCDGrand_Total.Size = new System.Drawing.Size(79, 17);
            this.lblPSCDGrand_Total.TabIndex = 4;
            this.lblPSCDGrand_Total.Text = "Grand-Total";
            // 
            // lblPSCDVAT
            // 
            this.lblPSCDVAT.AutoSize = true;
            this.lblPSCDVAT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDVAT.Location = new System.Drawing.Point(7, 116);
            this.lblPSCDVAT.Name = "lblPSCDVAT";
            this.lblPSCDVAT.Size = new System.Drawing.Size(53, 17);
            this.lblPSCDVAT.TabIndex = 3;
            this.lblPSCDVAT.Text = "VAT (%)";
            // 
            // lblPSCDDiscount
            // 
            this.lblPSCDDiscount.AutoSize = true;
            this.lblPSCDDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDDiscount.Location = new System.Drawing.Point(7, 80);
            this.lblPSCDDiscount.Name = "lblPSCDDiscount";
            this.lblPSCDDiscount.Size = new System.Drawing.Size(84, 17);
            this.lblPSCDDiscount.TabIndex = 2;
            this.lblPSCDDiscount.Text = "Discount (%)";
            // 
            // lblPSCDSubtotal
            // 
            this.lblPSCDSubtotal.AutoSize = true;
            this.lblPSCDSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCDSubtotal.Location = new System.Drawing.Point(7, 39);
            this.lblPSCDSubtotal.Name = "lblPSCDSubtotal";
            this.lblPSCDSubtotal.Size = new System.Drawing.Size(65, 17);
            this.lblPSCDSubtotal.TabIndex = 1;
            this.lblPSCDSubtotal.Text = "Sub-Total";
            // 
            // lblPSCalculation
            // 
            this.lblPSCalculation.AutoSize = true;
            this.lblPSCalculation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPSCalculation.Location = new System.Drawing.Point(4, 9);
            this.lblPSCalculation.Name = "lblPSCalculation";
            this.lblPSCalculation.Size = new System.Drawing.Size(124, 17);
            this.lblPSCalculation.TabIndex = 0;
            this.lblPSCalculation.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1272, 578);
            this.Controls.Add(this.pnlPSCalculation);
            this.Controls.Add(this.pnlDgvAddedProduct);
            this.Controls.Add(this.pnlProDetails);
            this.Controls.Add(this.pnlDeaCus);
            this.Controls.Add(this.pnlTopPurcSale);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPurchaseAndSales";
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            this.pnlTopPurcSale.ResumeLayout(false);
            this.pnlTopPurcSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPueSal)).EndInit();
            this.pnlDeaCus.ResumeLayout(false);
            this.pnlDeaCus.PerformLayout();
            this.pnlProDetails.ResumeLayout(false);
            this.pnlProDetails.PerformLayout();
            this.pnlDgvAddedProduct.ResumeLayout(false);
            this.pnlDgvAddedProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPSAddedProduct)).EndInit();
            this.pnlPSCalculation.ResumeLayout(false);
            this.pnlPSCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopPurcSale;
        private System.Windows.Forms.PictureBox pbPueSal;
        private System.Windows.Forms.Label lblTopPurcSale;
        private System.Windows.Forms.Panel pnlDeaCus;
        private System.Windows.Forms.TextBox txtPSDeaCusName;
        private System.Windows.Forms.TextBox txtPSDeaCusContact;
        private System.Windows.Forms.TextBox txtPSDeaCusEmail;
        private System.Windows.Forms.TextBox txtPSDeaCusAddress;
        private System.Windows.Forms.TextBox txtPSDeaCusSearch;
        private System.Windows.Forms.DateTimePicker DTPSDeaCusDatetime;
        private System.Windows.Forms.Label lblPSDeaCusBillDate;
        private System.Windows.Forms.Label lblPSDeaCusAddress;
        private System.Windows.Forms.Label lblPSDeaCusEmail;
        private System.Windows.Forms.Label lblPSDeaCusContact;
        private System.Windows.Forms.Label lblPSDeaCusName;
        private System.Windows.Forms.Label lblPSDeaCusSearch;
        private System.Windows.Forms.Label lblPSDeaCus;
        private System.Windows.Forms.Panel pnlProDetails;
        private System.Windows.Forms.TextBox txtPSPDInventory;
        private System.Windows.Forms.TextBox txtPSPDName;
        private System.Windows.Forms.TextBox txtPSPDQty;
        private System.Windows.Forms.TextBox txtPSPDRate;
        private System.Windows.Forms.TextBox txtPSPDSearch;
        private System.Windows.Forms.Button btnPSPDADD;
        private System.Windows.Forms.Label lblPSPDQty;
        private System.Windows.Forms.Label lblPSPDRate;
        private System.Windows.Forms.Label lblPSPDInventory;
        private System.Windows.Forms.Label lblPSPDNamme;
        private System.Windows.Forms.Label lblPSPDSearch;
        private System.Windows.Forms.Label lblPSProDetails;
        private System.Windows.Forms.Panel pnlDgvAddedProduct;
        private System.Windows.Forms.DataGridView dgvPSAddedProduct;
        private System.Windows.Forms.Label lblPSAddedProduct;
        private System.Windows.Forms.Panel pnlPSCalculation;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.TextBox txtPSCDRetAmut;
        private System.Windows.Forms.TextBox txtPSCDpaidamount;
        private System.Windows.Forms.TextBox txtPSCDDiscount;
        private System.Windows.Forms.TextBox txtPSCDVat;
        private System.Windows.Forms.TextBox txtPSCDGrandTotal;
        private System.Windows.Forms.TextBox txtPSCDSubtotal;
        private System.Windows.Forms.Label lblPSCDRetunAmont;
        private System.Windows.Forms.Label lblPSCDPaid_Amount;
        private System.Windows.Forms.Label lblPSCDGrand_Total;
        private System.Windows.Forms.Label lblPSCDVAT;
        private System.Windows.Forms.Label lblPSCDDiscount;
        private System.Windows.Forms.Label lblPSCDSubtotal;
        private System.Windows.Forms.Label lblPSCalculation;
    }
}