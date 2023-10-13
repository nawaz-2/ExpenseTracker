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
    public partial class frmExpenseCategory : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();
        public frmExpenseCategory()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "ecId";
            gv.Columns[1].DataPropertyName = "CategoryName";

            var data = Db.tblExpenseCategories.Select(x => new { x.ecId, x.CategoryName }).ToList();
            gv.DataSource = data;
        }
        private void clearForm()
        {
            txtID.Text = "";
            txtCategoryName.Text = "";
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (txtCategoryName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the category name!");
            }

            if (btnInsert.Text == "Insert")
            {
                tblExpenseCategory cate = new tblExpenseCategory();
                cate.CategoryName = txtCategoryName.Text;
                cate.UserId = userInfo.uId;

                Db.tblExpenseCategories.Add(cate);
                Db.SaveChanges();
                MessageBox.Show("Data saved successfully!", "Insert", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
            }
            else
            {
                //Update code
                int idn = Int32.Parse(txtID.Text);
                var cate = Db.tblExpenseCategories.Where(x => x.ecId == idn).FirstOrDefault();
                if (cate != null)
                {
                    cate.CategoryName = txtCategoryName.Text;
                    Db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";
                }
                MessageBox.Show("Data saved successfully!", "Insert", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            clearForm();
            LoadData();
            pnlData.Visible = false;
        }

        private void frmExpenseCategory_Load(object sender, EventArgs e)
        {
            LoadData();
            pnlData.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clearForm();
            pnlData.Visible = false;
        }
        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtID.Text);

                        var data = Db.tblExpenseCategories.Where(x => x.ecId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        txtCategoryName.Text = data.CategoryName;

                        break;

                    case 3:
                        txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtID.Text);

                        var datadelete = Db.tblExpenseCategories.Where(x => x.ecId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "Delete confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            Db.tblExpenseCategories.Remove(datadelete);
                            Db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Data has been successfully deleted");
                        }
                        break;

                    default:
                        break;
                }
            }

            catch (Exception)
            {

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
        }

         
    }
     
}
