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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        CategoryDAL cdal = new CategoryDAL();
        ProductsDAL pdal = new ProductsDAL();
        private void pboxInventory_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            DataTable cdt = cdal.Select();
            cmbCategories.DataSource = cdt;
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";
            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategories.Text;
            DataTable dt = pdal.DisplayProductBYCategorie(category);
            dgvInventory.DataSource = dt;
        }

        private void btnIShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvInventory.DataSource = dt;
        }
    }
}
