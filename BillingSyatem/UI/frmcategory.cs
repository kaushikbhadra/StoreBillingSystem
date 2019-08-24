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
    public partial class frmcategory : Form
    {
        public frmcategory()
        {
            InitializeComponent();
        }

        CategoryBLL c = new CategoryBLL();
        CategoryDAL dal = new CategoryDAL();
        UserDAL udal = new UserDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmcategory_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvCategory.DataSource = dt;
            
        }
        private void clear()
        {
            txtcategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtctgSearch.Text = "";
        }

        private void btnctgADD_Click(object sender, EventArgs e)
        {
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            c.added_by = user.id;
            
            bool success = dal.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Category Successfully Inserted.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new Categories.");
            }
            DataTable dt = dal.Select();
            dgvCategory.DataSource = dt;


        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcategoryID.Text = dgvCategory.Rows[rowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategory.Rows[rowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategory.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btnctgUpdate_Click(object sender, EventArgs e)
        {
            c.id = Convert.ToInt32(txtcategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            
            c.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = udal.GetIdFromUsername(loggeduser);
            c.added_by = user.id;

            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show(" Successfully Update Categorie.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Update Categorie.");
            }
            DataTable dt = dal.Select();
            dgvCategory.DataSource = dt;
        }

        private void btnctgDelete_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtcategoryID.Text);
            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Deleted Categorie Successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Delete Categorie.");
            }
            DataTable dt = dal.Select();
            dgvCategory.DataSource = dt;
        }

        private void txtctgSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtctgSearch.Text;
            if (keyword != null)
            {
                DataTable dt = dal.Search(keyword);
                dgvCategory.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvCategory.DataSource = dt;
            }
        }
    }
}

