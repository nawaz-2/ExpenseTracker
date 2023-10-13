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
    public partial class frmUserInfo : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
        }
        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "uId";
            gv.Columns[1].DataPropertyName = "Username";
            gv.Columns[2].DataPropertyName = "Password";
            gv.Columns[3].DataPropertyName = "FullName";
            gv.Columns[4].DataPropertyName = "UserType";


            var data = Db.tblUsers.Select(x => new { x.uId, x.Username, x.Password, x.FullName, x.UserType }).ToList();
            gv.DataSource = data;

            pnlData.Visible = false;


        }

        private void clearUserForm()
        {
            txtId.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            cmbUserType.SelectedIndex = 0;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                tblUser user = new tblUser();

                user.Username = txtUserName.Text;
                user.Password = txtPassword.Text;
                user.FullName = txtFullName.Text;
                user.UserType = cmbUserType.Text;


                Db.tblUsers.Add(user);
                Db.SaveChanges();

                clearUserForm();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                 
                int idn = Int32.Parse(txtId.Text);
                var user = Db.tblUsers.Where(x => x.uId == idn).FirstOrDefault();
                if (user != null)
                {
                    user.Username = txtUserName.Text;
                    user.Password = txtPassword.Text;
                    user.FullName = txtFullName.Text;
                    user.UserType = cmbUserType.Text;


                    Db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";

                }


                clearUserForm();
                MessageBox.Show("Data Updated Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        var data = Db.tblUsers.Where(x => x.uId == idn).FirstOrDefault();
                        

                        txtUserName.Text = data.Username;
                        txtPassword.Text = data.Password;
                        txtFullName.Text = data.FullName;
                        cmbUserType.Text = data.UserType;


                        break;

                    default:

                    case 6:
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtId.Text);

                        var datadelete = Db.tblUsers.Where(x => x.uId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            Db.tblUsers.Remove(datadelete);
                            Db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data deleted successfully");
                        }
                        break;
                }

            }
            catch (Exception)
            {


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearUserForm();
            pnlData.Visible = false;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            LoadData();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
