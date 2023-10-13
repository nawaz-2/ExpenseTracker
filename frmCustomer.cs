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
    public partial class frmCustomer : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1 ();
        public frmCustomer()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "cId";
            gv.Columns[1].DataPropertyName = "Name";
            gv.Columns[2].DataPropertyName = "Email";
            gv.Columns[3].DataPropertyName = "Phone";
            gv.Columns[4].DataPropertyName = "Username";

            var data = Db.tblCustomers.Select(x => new { x.cId, x.Name, x.email, x.phone, x.tblUser.Username }).ToList();
            gv.DataSource = data;

            pnlData.Visible = false;
        }
        private void clearUserForm()
        {
            txtID.Text = "";
            txtEmail.Text = "";
            txtCustomerName.Text = "";
            txtNumber.Text = "";

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                tblCustomer cust = new tblCustomer();
                cust.Name = txtCustomerName.Text;
                cust.email = txtEmail.Text;
                cust.phone = txtNumber.Text;
                cust.uId = userInfo.uId;


                Db.tblCustomers.Add(cust);
                Db.SaveChanges();

                clearUserForm();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                //update code 
                int idn = Int32.Parse(txtID.Text);
                var cust = Db.tblCustomers.Where(x => x.cId == idn).FirstOrDefault();
                if (cust != null)
                {
                    cust.Name = txtCustomerName.Text;
                    cust.email = txtEmail.Text;
                    cust.phone = txtNumber.Text;


                    Db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";

                }


                clearUserForm();
                MessageBox.Show("Data Updated Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            LoadData();
        }
 

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearUserForm();
            pnlData.Visible = false;
        }

        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
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
                        txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtID.Text);

                        var data = Db.tblCustomers.Where(x => x.cId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        txtCustomerName.Text = data.Name;
                        txtEmail.Text = data.email;
                        txtNumber.Text = data.phone;

                        break;

                    default:

                    case 6:
                        txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtID.Text);

                        var datadelete = Db.tblCustomers.Where(x => x.cId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            Db.tblCustomers.Remove(datadelete);
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
    }
}
