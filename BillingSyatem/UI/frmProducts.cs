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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pcbProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CategoryDAL cdal = new CategoryDAL();
        ProductsBLL p = new ProductsBLL();
        ProductsDAL pdal = new ProductsDAL();
        UserDAL udal = new UserDAL();
        private void frmProducts_Load(object sender, EventArgs e)
        {
            DataTable categorieDT = cdal.Select();
            cmbpdtCategorie.DataSource = categorieDT;
            cmbpdtCategorie.DisplayMember = "title";
            cmbpdtCategorie.ValueMember = "title";

            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;

        }

        private void clear()
        {
           txtpdtID .Text = "";
            txtpdtName.Text = "";
            cmbpdtCategorie.Text = "";
            txtpdtDescription.Text = "";
            txtpdtRate.Text = "";
            txtpdtSearch.Text = "";
        }
        private void btnpdtADD_Click(object sender, EventArgs e)
        {
            p.name = txtpdtName.Text;
            p.categorie = cmbpdtCategorie.Text;
            p.description = txtpdtDescription.Text;
            p.rate = decimal.Parse(txtpdtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            p.added_by = user.id;

            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product Added Successfully ....");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new Product...");
            }
            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtpdtID.Text = dgvProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtpdtName.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();
            cmbpdtCategorie.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();
            txtpdtDescription.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
            txtpdtRate.Text = dgvProduct.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnpdtUpdate_Click(object sender, EventArgs e)
        {
            p.id = Convert.ToInt32(txtpdtID.Text);
            p.name = txtpdtName.Text;
            p.categorie = cmbpdtCategorie.Text;
            p.description = txtpdtDescription.Text;
            p.rate = decimal.Parse(txtpdtRate.Text);
            p.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            p.added_by = user.id;

            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show(" Successfully Update Product...");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Update Product...");
            }
            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;
        }

        private void btnpdtDelete_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtpdtID.Text);
            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Deleted Product Successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Delete Product.");
            }
            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;
        }

        private void txtpdtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtpdtSearch.Text;
            if (keyword != null)
            {
                DataTable dt = pdal.Search(keyword);
                dgvProduct.DataSource = dt;
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
        }
    }

}
