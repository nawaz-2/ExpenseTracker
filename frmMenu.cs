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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusClock.Text = DateTime.Now.ToLongTimeString();
        }
        private Form activeForm = null;
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childform);
            pnlContainer.Dock = DockStyle.Fill;
            childform.BringToFront();
            childform.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            statusWelcome.Text = "Welcome - " + userInfo.username;
            openChildForm(new frmHome());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
        }

        private void btnExpenseCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseCategory());
        }

        private void btnExpenseItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseItem());
        }

        private void btnExpenseRecord_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExpenseRecord());
        }
        

        private void btnBarChat_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmViewChart());

        }

        private void btnManagerUser_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmUserInfo());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
    }
}
