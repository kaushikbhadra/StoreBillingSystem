using BillingSyatem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSyatem.UI
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        TransactionDAL tdal = new TransactionDAL();

        private void pboxTransaction_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransaction.DataSource = dt;

        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbTransactionType.Text;
            DataTable dt = tdal.DisplayTransactionBYType(type);
            dgvTransaction.DataSource = dt;
        }

        private void btnTShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransaction.DataSource = dt;
        }
    }
}
