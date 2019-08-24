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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
        }
        private void butADD_Click(object sender, EventArgs e)
        {
            
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = dal.GetIdFromUsername(loggeduser);
            u.added_by = user.id;

            bool success = dal.Insert(u);
            if(success == true)
            {
                MessageBox.Show("User Successfully Created.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new User.");
            }
            DataTable dt = dal.Select();
            dataGridView1.DataSource =dt;

            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUserName.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            string loggeduser = frmLogin.loggedIn;
            UserBLL user = dal.GetIdFromUsername(loggeduser);
            u.added_by = user.id;

            bool success = dal.Update(u);
            if (success == true)
            {
                MessageBox.Show("User Successfully Updated.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Update User.");
            }
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            u.id = int.Parse(txtID.Text);
            bool success = dal.Delete(u);
            if (success == true)
            {
                MessageBox.Show("Deleted User Successfully.");
                clear();
            }
            else
            {
                MessageBox.Show("failed to Delete User.");
            }
            DataTable dt = dal.Select();
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            if(keyword!=null)
            {
                DataTable dt = dal.Search(keyword);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
