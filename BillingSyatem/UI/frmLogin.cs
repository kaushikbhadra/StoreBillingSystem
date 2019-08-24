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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string loggedIn;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            txtPassword.Text = "";
            cmbUserType.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            bool success = dal.Logincheck(l);
            if(success==true)
            {
                MessageBox.Show("Successfully Login... ");
                Clear();
                loggedIn = l.username;
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            User user = new User();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Invalid User Type.");
                            
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again...");
                Clear();
            }
        }
    }
}
