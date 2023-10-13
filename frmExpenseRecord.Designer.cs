namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    partial class frmExpenseRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv = new System.Windows.Forms.DataGridView();
            this.pnlData = new System.Windows.Forms.Panel();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(184, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(567, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Expense Record Information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(981, 58);
            this.pnlTop.TabIndex = 25;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.ToolTipText = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Cost";
            this.colCost.MinimumWidth = 6;
            this.colCost.Name = "colCost";
            this.colCost.Width = 125;
            // 
            // cPaymentType
            // 
            this.cPaymentType.HeaderText = "Payment Type";
            this.cPaymentType.Name = "cPaymentType";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            // 
            // cMonth
            // 
            this.cMonth.HeaderText = "Month";
            this.cMonth.MinimumWidth = 6;
            this.cMonth.Name = "cMonth";
            this.cMonth.Width = 125;
            // 
            // aId
            // 
            this.aId.HeaderText = "ID";
            this.aId.MinimumWidth = 6;
            this.aId.Name = "aId";
            this.aId.Width = 125;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aId,
            this.cMonth,
            this.colCategory,
            this.cPaymentType,
            this.colCost,
            this.colItem,
            this.Edit,
            this.Delete});
            this.gv.Location = new System.Drawing.Point(0, 106);
            this.gv.Margin = new System.Windows.Forms.Padding(2);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(972, 201);
            this.gv.TabIndex = 26;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.cboItemName);
            this.pnlData.Controls.Add(this.txtDescription);
            this.pnlData.Controls.Add(this.txtCost);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.cboCategory);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.cboMonth);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.cboPaymentType);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.txtId);
            this.pnlData.Controls.Add(this.lblId);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.ForeColor = System.Drawing.Color.Black;
            this.pnlData.Location = new System.Drawing.Point(239, 168);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(473, 331);
            this.pnlData.TabIndex = 27;
            this.pnlData.Visible = false;
            // 
            // cboItemName
            // 
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(173, 100);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(185, 21);
            this.cboItemName.TabIndex = 30;
            this.cboItemName.SelectionChangeCommitted += new System.EventHandler(this.cboItemName_SelectionChangeCommitted);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(173, 196);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 53);
            this.txtDescription.TabIndex = 29;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(173, 166);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(185, 20);
            this.txtCost.TabIndex = 28;
            this.txtCost.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.cboCategory.Location = new System.Drawing.Point(173, 74);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(185, 21);
            this.cboCategory.TabIndex = 26;
            this.cboCategory.SelectionChangeCommitted += new System.EventHandler(this.cboCategory_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Category :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "Casy On Delivary",
            "Bkash"});
            this.cboMonth.Location = new System.Drawing.Point(173, 45);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(185, 21);
            this.cboMonth.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(52, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Month Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Items.AddRange(new object[] {
            "Casy On Delivary",
            "Bkash"});
            this.cboPaymentType.Location = new System.Drawing.Point(173, 134);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(185, 21);
            this.cboPaymentType.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Payment Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Item :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(173, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(99, 20);
            this.txtId.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(52, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(372, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 33);
            this.btnClose.TabIndex = 17;
            this.btnClose.Tag = "";
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(264, 279);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(77, 33);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Tag = "Insert";
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 37);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmExpenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 616);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmExpenseRecord";
            this.Text = "frmExpenseRecord";
            this.Load += new System.EventHandler(this.frmExpenseRecord_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn aId;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
    }
}