using BillingSyatem.BLL;
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
    public partial class frmdeaCus : Form
    {
        public frmdeaCus()
        {
            InitializeComponent();
        }

        private void pboxDecCus_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UserDAL udal = new UserDAL();
        DeaCusDAL dcdal = new DeaCusDAL();
        DeaCusBLL dc = new DeaCusBLL();

        private void clear()
        {
            txtdcID.Text = "";
            cmbdcType.Text = "";
            txtdcName.Text = "";
            txtdcEmail.Text = "";
            txtdcContact.Text = "";
            txtdcAddress.Text = "";
            txtdcSearch.Text = "";
            
        }
        private void btndcADD_Click(object sender, EventArgs e)
        {
            dc.type = cmbdcType.Text;
            dc.name = txtdcName.Text;
            dc.email = txtdcEmail.Text;
            dc.contact = txtdcContact.Text;
            dc.address = txtdcAddress.Text;
            
            dc.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            dc.added_by = user.id;

            bool success = dcdal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show(" Successfully Added Dealer and Customer Details...");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new  Dealer and Customer Details...");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCus.DataSource = dt;
        }

        private void frmdeaCus_Load(object sender, EventArgs e)
        {
            DataTable dt = dcdal.Select();
            dgvDeaCus.DataSource = dt;
        }

        private void btndcUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtdcID.Text);
            dc.type = cmbdcType.Text;
            dc.name = txtdcName.Text;
            dc.email = txtdcEmail.Text;
            dc.contact = txtdcContact.Text;
            dc.address = txtdcAddress.Text;
            dc.added_date = DateTime.Now;

            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);

            dc.added_by = user.id;

            bool success = dcdal.Update(dc);
            if (success == true)
            {
                MessageBox.Show(" Successfully Updated Dealer and Customer Details...");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Updated  Dealer and Customer Details...");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCus.DataSource = dt;
        }

        private void btndcDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtdcID.Text);
            bool success = dcdal.Delete(dc);
            if (success == true)
            {
                MessageBox.Show("Deleted Dealer and Customer Detail Successfully....");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Delete Dealer and Customer Detail...");
            }
            DataTable dt = dcdal.Select();
            dgvDeaCus.DataSource = dt;
        }

        private void txtdcSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtdcSearch.Text;
            if (keyword != null)
            {
                DataTable dt = dcdal.Search(keyword);
                dgvDeaCus.DataSource = dt;
            }
            else
            {
                DataTable dt = dcdal.Select();
                dgvDeaCus.DataSource = dt;
            }
        }

        private void dgvDeaCus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtdcID.Text =dgvDeaCus.Rows[rowIndex].Cells[0].Value.ToString();
            cmbdcType.Text = dgvDeaCus.Rows[rowIndex].Cells[1].Value.ToString();
            txtdcName.Text = dgvDeaCus.Rows[rowIndex].Cells[2].Value.ToString();
            txtdcEmail.Text = dgvDeaCus.Rows[rowIndex].Cells[3].Value.ToString();
            txtdcContact.Text = dgvDeaCus.Rows[rowIndex].Cells[4].Value.ToString();
            txtdcAddress.Text = dgvDeaCus.Rows[rowIndex].Cells[5].Value.ToString();
            
        }
    }
}
