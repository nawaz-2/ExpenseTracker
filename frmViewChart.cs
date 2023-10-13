using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    public partial class frmViewChart : Form
    {
        expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();

        public frmViewChart()
        {
            InitializeComponent();
        }
        private void CreateChart()
        {
           expenseTrackerDBEntities1 Db = new expenseTrackerDBEntities1();

            // Load Expense Record By User 
            var data = Db.tblExpenseRecords.Where(x => x.UserId == userInfo.uId).Select(x => new
            {
                x.tblMonth.MonthName,
                x.tblExpenseCategory.CategoryName,
                x.Cost
            }).ToList();



            // Data grup by month and category
            var groupData = data.GroupBy(d => new { Month = d.MonthName, Category = d.CategoryName })
                                                   .OrderBy(g => g.Key.Month)
                                                   .ThenBy(g => g.Key.Category)
                                                   .Select(g => new
                                                   {
                                                       MonthName = g.Key.Month,
                                                       Category = g.Key.Category,
                                                       TotalCost = g.Sum(x => x.Cost)
                                                   });

            // Clear existing series in the chart
            //barChart.Series.Clear();

            gv.DataSource = groupData.ToList();

            var categoryList = groupData.Select(g => g.Category).Distinct();

            foreach (var item in groupData)
            {
                chart1.Series["Series1"].Points.AddXY(item.MonthName, item.TotalCost);
                //chart1.Series["Series1"].Points[0].Color = Color.PaleGreen;
            }




            Title title = chart1.Titles.Add("Monthly Expense Breakdown by Category");
            title.Font = new Font(title.Font.FontFamily, 14, FontStyle.Bold);

            //chart1.Titles.Clear();
            //chart1.Titles.Add("Monthly Expense Breakdown by Category");
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Legends[0].Enabled = false;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
        }
        private void loadUserName()
        {
            lblUserName.Text = userInfo.username;
        }
        //private void loadUserName()
        //{
        //    lblUserName.Text = userInfo.username;
        //}
        private void frmViewChart_Load(object sender, EventArgs e)
        {
            loadUserName();
            btn3D.Text = "View 3D";
            CreateChart();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            chart1.Refresh();
        }
        //User Name Load Function
        

        private void btn3D_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].Area3DStyle.Enable3D = !chart1.ChartAreas[0].Area3DStyle.Enable3D;
            btn3D.Text = (btn3D.Text == "View 3D") ? "View 2D" : "View 3D";
        }
    }
}
