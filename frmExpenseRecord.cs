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
    public partial class frmExpenseRecord : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();
        public frmExpenseRecord()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            gv.AutoGenerateColumns = false;
            gv.Columns[0].DataPropertyName = "erId";
            gv.Columns[1].DataPropertyName = "MonthName";
            gv.Columns[2].DataPropertyName = "CategoryName";
            gv.Columns[3].DataPropertyName = "PaymentTypeName";
            gv.Columns[4].DataPropertyName = "Cost";
            gv.Columns[5].DataPropertyName = "ItemName";

            var data = Db.tblExpenseRecords.Select(x => new { x.erId, x.tblMonth.MonthName, x.tblExpenseCategory.CategoryName, x.tblPaymentType.PaymentTypeName, x.Cost, x.Description, x.tblExpenseItem.ItemName, x.UserId }).Where(rec => rec.UserId == userInfo.uId).ToList();
            gv.DataSource = data;

            pnlData.Visible = false;


        }

        private void clearUserForm()
        {
            txtId.Text = "";
            txtCost.Text = "0";


        }

        private void frmExpenseRecord_Load(object sender, EventArgs e)
        {
            pnlData.Visible = false;
            LoadData();

            //Load Expense Item
            var dataItem = Db.tblExpenseItems.ToList();
            dataItem.Insert(0, new tblExpenseItem { eiId = 0, ItemName = "---- Select ---" });

            cboItemName.DisplayMember = "ItemName";
            cboItemName.ValueMember = "eiId";
            cboItemName.DataSource = dataItem;

            //Check ComboBox Data
            if (dataItem.Count == 1)
            {
                MessageBox.Show("Please Add Some Expense Item Information");
                //this.Close();
                frmExpenseItem frm = new frmExpenseItem();
                frm.ShowDialog();
            }

            //Load Month Combo Data
            var dataMonth = Db.tblMonths.ToList();
            dataMonth.Insert(0, new tblMonth { Id = 0, MonthName = "---- Select ---" });

            cboMonth.DisplayMember = "MonthName";
            cboMonth.ValueMember = "Id";
            cboMonth.DataSource = dataMonth;

            //Load Category Combo Data
            var dataCat = Db.tblExpenseCategories.ToList();
            dataCat.Insert(0, new tblExpenseCategory { ecId = 0, CategoryName = "---- Select ---" });

            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "ecId";
            cboCategory.DataSource = dataCat;

            //Load Payment Type 
            var dataPaytype = Db.tblPaymentTypes.ToList();
            dataPaytype.Insert(0, new tblPaymentType { Id = 0, PaymentTypeName = "---- Select ---" });

            cboPaymentType.DisplayMember = "PaymentTypeName";
            cboPaymentType.ValueMember = "Id";
            cboPaymentType.DataSource = dataPaytype;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnInsert.Text = "Insert";
            pnlData.Visible = true;
            clearUserForm();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (btnInsert.Text == "Insert")
            {
                //Form Validation 
                StringBuilder sb = new StringBuilder();

                if (cboMonth.SelectedIndex == 0)
                {
                    sb.AppendLine("Please Select Month !!!");
                }

                if (cboCategory.SelectedIndex == 0)
                {
                    sb.AppendLine("Please Select Category !!!");
                }

                if (cboItemName.SelectedIndex == 0)
                {
                    sb.AppendLine("Please Select Item Name !!!");
                }

                if (cboPaymentType.SelectedIndex == 0)
                {
                    sb.AppendLine("Please Select Payment Type !!!");
                }

                if (txtCost.Text.Trim().Length == 0)
                {
                    sb.AppendLine("Please Enter Item Cost !!!");
                }

                if (sb.ToString() != String.Empty)
                {
                    MessageBox.Show(sb.ToString());
                    return;

                }

                //------------ End Validation ---------------------
                tblExpenseRecord record = new tblExpenseRecord();

                record.UserId = userInfo.uId;
                record.MonthId = Int32.Parse(cboMonth.SelectedValue.ToString());
                record.ExpCategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                record.PaymentTypeId = Int32.Parse(cboPaymentType.SelectedValue.ToString());
                record.Cost = decimal.Parse(txtCost.Text);
                record.Description = txtDescription.Text;
                record.ExpItemId = Int32.Parse(cboItemName.SelectedValue.ToString());



                Db.tblExpenseRecords.Add(record);
                Db.SaveChanges();

                clearUserForm();
                MessageBox.Show("Data Saved Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            else
            {

                //update code 
                int idn = Int32.Parse(txtId.Text);
                var record = Db.tblExpenseRecords.Where(x => x.erId == idn).FirstOrDefault();
                if (record != null)
                {
                    //record.UserId = userClass.uId;
                    record.MonthId = Int32.Parse(cboMonth.SelectedValue.ToString());
                    record.ExpCategoryId = Int32.Parse(cboCategory.SelectedValue.ToString());
                    record.PaymentTypeId = Int32.Parse(cboPaymentType.SelectedValue.ToString());
                    record.Cost = decimal.Parse(txtCost.Text);
                    record.Description = txtDescription.Text;
                    record.ExpItemId = Int32.Parse(cboItemName.SelectedValue.ToString());

                    Db.SaveChanges();
                    LoadData();
                    btnInsert.Text = "Insert";

                }


                clearUserForm();
                MessageBox.Show("Data Updated Successfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlData.Visible = false;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 6:
                        pnlData.Visible = true;
                        btnInsert.Text = "Update";
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn = Int32.Parse(txtId.Text);

                        var record = Db.tblExpenseRecords.Where(x => x.erId == idn).FirstOrDefault();
                        //MessageBox.Show(data.TransId.ToString());

                        //record.UserId = userClass.uId;
                        cboMonth.SelectedValue = record.MonthId;
                        cboCategory.SelectedValue = record.ExpCategoryId;
                        cboPaymentType.SelectedValue = record.PaymentTypeId;
                        txtCost.Text = record.Cost.ToString();
                        txtDescription.Text = record.Description;
                        cboItemName.SelectedValue = record.ExpItemId;

                        break;

                    default:

                    case 7:
                        txtId.Text = gv.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int idn1 = Int32.Parse(txtId.Text);

                        var datadelete = Db.tblExpenseRecords.Where(x => x.erId == idn1).FirstOrDefault();
                        DialogResult dg = MessageBox.Show("Do you wish to delete?", "Delete confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dg == DialogResult.Yes)
                        {
                            Db.tblExpenseRecords.Remove(datadelete);
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

        private void cboCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Load Payment Type
            int cid = Int32.Parse(cboCategory.SelectedValue.ToString());
            var dataItem = Db.tblExpenseItems.Where(x => x.ExpenseCategoryId == cid).ToList();

            dataItem.Insert(0, new tblExpenseItem { eiId = 0, ItemName = "---- Select ---" });
            cboItemName.DisplayMember = "ItemName";
            cboItemName.ValueMember = "eiId";
            cboItemName.DataSource = dataItem;
        }

        private void cboItemName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int iid = Int32.Parse(cboItemName.SelectedValue.ToString());

            var dataItem = Db.tblExpenseItems.Where(x => x.eiId == iid).FirstOrDefault();

            if (dataItem != null)
            {
                txtCost.Text = dataItem.Cost.ToString();
            }

        }
    }
}
