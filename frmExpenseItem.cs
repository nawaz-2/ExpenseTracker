using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    public partial class frmExpenseItem : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();
        public frmExpenseItem()
        {
            InitializeComponent();
        }
        private void LoadComboData()
        {
            //Populate the combo box
            var cbodata = Db.tblExpenseCategories.ToList();

            cbodata.Insert(0, new tblExpenseCategory { ecId = 0, CategoryName = "---- Select ---" });
            cboExpense.DataSource = cbodata;
            cboExpense.DisplayMember = "CategoryName";
            cboExpense.ValueMember = "ecId";
            //--------------------------------------------
        }
        private void LoadData()
        {


            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "eiId";
            gv.Columns[1].DataPropertyName = "ItemName";
            gv.Columns[2].DataPropertyName = "Cost";
            gv.Columns[3].DataPropertyName = "Description";
            gv.Columns[4].DataPropertyName = "ExpenseCategoryId";
            gv.Columns[5].DataPropertyName = "UserId";

            var data = Db.tblExpenseItems.Select(x => new { x.eiId, x.ItemName, x.Cost, x.Description, x.ExpenseCategoryId, x.UserId }).ToList();
            gv.DataSource = data;

        }

        private void frmExpenseItem_Load(object sender, EventArgs e)
        {
            LoadComboData();
            LoadData();
            pnlData.Visible = false;
        }
        private void clearform()
        {
            txtID.Clear();
            txtItemName.Clear();

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            clearform();
            pnlData.Visible = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (txtItemName.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item name!");
            }

            if (txtCost.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item cost!");
            }

            if (txtDescription.Text.Trim().Length == 0)
            {
                sb.AppendLine("Please enter the Item Description!");
            }

            if (btnInsert.Text == "Insert")
            {
                tblExpenseItem eitem = new tblExpenseItem();
                eitem.ItemName = txtItemName.Text;
                eitem.Cost = decimal.Parse(txtCost.Text);
                eitem.Description = txtDescription.Text;
                eitem.ExpenseCategoryId = Int32.Parse(cboExpense.SelectedValue.ToString());
                eitem.UserId = userInfo.uId;

                Db.tblExpenseItems.Add(eitem);
                Db.SaveChanges();
                MessageBox.Show("Data saved successfully!", "Insert", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadData();
            }
            else
            {
                //Update code
                int idn = Int32.Parse(txtID.Text);
                var eitem = Db.tblExpenseItems.Where(x => x.eiId == idn).FirstOrDefault();
                if (eitem != null)
                {
                    eitem.ItemName = txtItemName.Text;
                    eitem.Cost = decimal.Parse(txtCost.Text);
                    eitem.Description = txtDescription.Text;
                    eitem.ExpenseCategoryId = Int32.Parse(cboExpense.SelectedValue.ToString());
                    //eitem.UserId = userClass.uId;

                    Db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";
                }
                MessageBox.Show("Data saved successfully!", "Insert", MessageBoxButtons.OK,
                     MessageBoxIcon.Information);
            }
            clearform();
            LoadData();
            pnlData.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoadComboData();
            LoadData();
            pnlData.Visible = false;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    pnlData.Visible = true;
                    btnInsert.Text = "Update";
                    txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int idn = Int32.Parse(txtID.Text);

                    var data = Db.tblExpenseItems.Where(x => x.eiId == idn).FirstOrDefault();

                    //MessageBox.Show(data.TransId.ToString());
                    txtID.Text = data.eiId.ToString();
                    txtItemName.Text = data.ItemName;
                    txtDescription.Text = data.Description;
                    cboExpense.SelectedValue = data.ExpenseCategoryId;

                    break;

                case 6:
                    txtID.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int idn1 = Int32.Parse(txtID.Text);

                    var datadelete = Db.tblExpenseItems.Where(x => x.eiId == idn1).FirstOrDefault();
                    DialogResult dg = MessageBox.Show("Are you sure you want to delete?", "Delete confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        Db.tblExpenseItems.Remove(datadelete);
                        Db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Data has been successfully deleted");
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
