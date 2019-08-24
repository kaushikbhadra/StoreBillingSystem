using BillingSyatem.BLL;
using BillingSyatem.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BillingSyatem.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pbPueSal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DeaCusDAL dcdal = new DeaCusDAL();
        ProductsDAL pdal = new ProductsDAL();
        UserDAL udal = new UserDAL();
        TransactionDAL tdal = new TransactionDAL();
        TransactionDetailsDAL tdDal = new TransactionDetailsDAL();

         DataTable transactionDT = new DataTable();
        
        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            string type = User.transactionType;
            lblTopPurcSale.Text = type;

            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void txtPSDeaCusSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPSDeaCusSearch.Text;

            if(keyword == "")
            {
                txtPSDeaCusName.Text = "";
                txtPSDeaCusEmail.Text = "";
                txtPSDeaCusContact.Text = "";
                txtPSDeaCusAddress.Text = "";
                return;
            }

            DeaCusBLL dc = dcdal.SearchDealerCustomerForTransaction(keyword);

            txtPSDeaCusName.Text = dc.name;
            txtPSDeaCusEmail.Text = dc.email;
            txtPSDeaCusContact.Text = dc.contact;
            txtPSDeaCusAddress.Text = dc.address;
        }

        private void txtPSPDSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtPSPDSearch.Text;
            if(keyword == "")
            {
                txtPSPDName.Text = "";
                txtPSPDInventory.Text = "";
                txtPSPDRate.Text = "";
                txtPSPDQty.Text = "";
                return;
            }

            ProductsBLL p = pdal.SearchProductForTransaction(keyword);
            txtPSPDName.Text = p.name;
            txtPSPDInventory.Text = p.qty.ToString();
            txtPSPDRate.Text = p.rate.ToString();
            
        }

        private void btnPSPDADD_Click(object sender, EventArgs e)
        {
            string ProductName = txtPSPDName.Text;
            decimal Rate = decimal.Parse(txtPSPDRate.Text);
            decimal Qty = decimal.Parse(txtPSPDQty.Text);
            decimal Total = Rate * Qty;
            decimal SubTotal = decimal.Parse(txtPSCDSubtotal.Text);
            SubTotal = SubTotal + Total;

            if(ProductName == "")
            {
                MessageBox.Show("Select the Product First...Try Again...");
            }
            else
            {
                transactionDT.Rows.Add(ProductName,Rate,Qty,Total);
                dgvPSAddedProduct.DataSource = transactionDT;

                txtPSCDSubtotal.Text = SubTotal.ToString();

                txtPSPDSearch.Text = "";
                txtPSPDName.Text = "";
                txtPSPDInventory.Text = "0.00";
                txtPSPDRate.Text = "0.00";
                txtPSPDQty.Text = "";
                

            }
        }

        private void txtPSCDDiscount_TextChanged(object sender, EventArgs e)
        {
            string value = txtPSCDDiscount.Text;
            if(value == "")
            {
                MessageBox.Show("Please Add Discount First...");
            }
            else
            {
                decimal SubTotal = decimal.Parse(txtPSCDSubtotal.Text);
                decimal discount = decimal.Parse(txtPSCDDiscount.Text);

                decimal grandTotal = ((100 - discount) / 100) * SubTotal;
                txtPSCDGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void txtPSCDVat_TextChanged(object sender, EventArgs e)
        {
            string check = txtPSCDGrandTotal.Text;

            if(check == "")
            {
                MessageBox.Show("Calculate The Discount And Set The Grand Total First...");
                
            }
            else
            {
                decimal PreviousGT = decimal.Parse(txtPSCDGrandTotal.Text);
                decimal VAT = decimal.Parse(txtPSCDVat.Text);

                decimal GrandTotalWithVat = ((100 + VAT) / 100) * PreviousGT;

                txtPSCDGrandTotal.Text = GrandTotalWithVat.ToString();
            }
        }

        private void txtPSCDpaidamount_TextChanged(object sender, EventArgs e)
        {
            decimal GrandTotal = decimal.Parse(txtPSCDGrandTotal.Text);
            decimal PaidAmount = decimal.Parse(txtPSCDpaidamount.Text);

            decimal ReturnAmount = PaidAmount - GrandTotal;

            txtPSCDRetAmut.Text = ReturnAmount.ToString();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            TransactionBLL transaction = new TransactionBLL();
            transaction.type = lblTopPurcSale.Text;
            string deaCusName = txtPSDeaCusName.Text;
            DeaCusBLL dc = dcdal.GetDeaCusIDFromName(deaCusName);
            transaction.delr_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtPSCDGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtPSCDVat.Text);
            transaction.discount = decimal.Parse(txtPSCDDiscount.Text);
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            transaction.added_by = user.id;


            transaction.transactionDetails = transactionDT;

            bool Success = false;
            using (TransactionScope scope = new TransactionScope())
            {
               int transactionID = -1;

                bool X = tdal.Insert_Transaction(transaction, out transactionID);

                for(int i=0;i<transactionDT.Rows.Count;i++)
                {
                    TransactionDetailsBLL td = new TransactionDetailsBLL();
                    String ProductName = transactionDT.Rows[i][0].ToString();
                    ProductsBLL p = pdal.GetProductIDFromName(ProductName);
                    td.product_id = p.id;
                    td.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    td.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    td.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    td.delr_cust_id = dc.id;
                    td.added_date = DateTime.Now;
                    td.added_by = user.id;

                    string transactionType = lblTopPurcSale.Text;
                    bool Y = false;
                    if(transactionType == "PURCHASE")
                    {
                        Y = pdal.IncreaseProduct(td.product_id, td.qty);
                    }
                    else if (transactionType == "SALES")
                    {
                        Y = pdal.DecreaseProduct(td.product_id, td.qty);
                    }

                    bool Z = tdDal.Insert_TransactionDetails(td);
                    Success = X && Y && Z;
                }
                
                if (Success == true)
                {
                    scope.Complete();

                    // CODE TO PRINT BILL 
                    DGVPrinter printer = new DGVPrinter();
                    printer.Title = "\r\n\r\nEVERYTHING PVT. LTD.\r\n";
                    printer.SubTitle = "\r\n MAIN ROAD NEAR RAILWAY STATION ,P.O:GHATSILA,\r\nDIST:EAST SINGHBHUM ,JHARKHAND\r\n Mob: 9583340426 \r\n\r\n ";
                    printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                    printer.PageNumbers = true;
                    printer.PageNumberInHeader = false;
                    printer.PorportionalColumns = true;
                    printer.HeaderCellAlignment = StringAlignment.Near;
                    printer.Footer = "Discount:"+ txtPSCDDiscount.Text + "%\r\n"+"TAX:"+txtPSCDVat.Text +"%\r\n"+"Grand-Total:RS"+txtPSCDGrandTotal.Text+"\r\n\r\n"+"THANK YOU FOR BUSINESS WITH US";
                    printer.FooterSpacing = 15;
                    printer.PrintDataGridView(dgvPSAddedProduct);
                    //----------------------------------------------------------------------------------------------------------------------------

                    MessageBox.Show("Transaction Successfully Done.");
                    dgvPSAddedProduct.DataSource = null;
                    dgvPSAddedProduct.Rows.Clear();
                    txtPSDeaCusSearch.Text = "";
                    txtPSDeaCusName.Text = "";
                    txtPSDeaCusEmail.Text = "";
                    txtPSDeaCusContact.Text = "";
                    txtPSDeaCusAddress.Text = "";
                    txtPSPDSearch.Text = "";
                    txtPSPDName.Text = "";
                    txtPSPDInventory.Text = "0";
                    txtPSPDRate.Text = "0";
                    txtPSPDQty.Text = "";
                    txtPSCDSubtotal.Text = "0";
                    txtPSCDDiscount.Text = "0";
                    txtPSCDVat.Text = "0";
                    txtPSCDGrandTotal.Text = "0";
                    txtPSCDpaidamount.Text = "0";
                    txtPSCDRetAmut.Text = "0";
                    
                }
                else
                {
                    MessageBox.Show("Failed Transaction,Retry");
                }
            }

        }
    }
}
