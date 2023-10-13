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
    public partial class frmRegister : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1 ();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (txtUserName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter User name !!!");
            }

            if (txtPassword.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please Enter Password !!!");
            }

            if (txtPassword.Text.Trim() != txtConfirmPass.Text.Trim())
            {
                sb.AppendLine("Sorry, Password and Confirm Password does not match !!!");
            }

            // check if password is at least 8 characters long
            // and contains at least one lowercase
            // and one uppercase letter
            string password = txtPassword.Text;
            bool validPassword = password.Length >= 8 &&
                password.Any(char.IsLower) &&
                password.Any(char.IsUpper);

            // Print result
            if (!validPassword)
            {
                sb.AppendLine("Password is not valid.");

            }

            if (sb.ToString() != String.Empty)
            {
                MessageBox.Show(sb.ToString());
                return;

            }

            tblUser user = new tblUser();
            user.FullName = txtFullName.Text;
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.UserType = "Consumer";
            Db.tblUsers.Add(user);
            Db.SaveChanges();

            MessageBox.Show("Signup Completed Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Alert for successfull
        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPass.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
            }
        }
        private void ClearForm()
        {
            txtFullName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPass.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin log = new frmLogin();
            log.ShowDialog();
        }
    }
}
