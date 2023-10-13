using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    public partial class frmLogin : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1 ();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var data = Db.tblUsers.Where(u => u.Username == txtUserName.Text
                          && u.Password == txtPassword.Text).FirstOrDefault(); //Checking username & Password in DB

            if (data != null)
            {
                userInfo.uId = data.uId;
                userInfo.Fullname = data.FullName;
                userInfo.username = data.Username;
                userInfo.userType = data.UserType;

                //Add logged in user detail in UserCLass
                this.Hide();

                frmMenu frm = new frmMenu();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid User !!!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPass.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;

            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
    
}
