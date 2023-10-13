namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    partial class frmExpenseItem
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.gv = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlData = new System.Windows.Forms.Panel();
            this.cboExpense = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pnlMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1117, 55);
            this.pnlTop.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(210, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(615, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Expense Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlMenu.Location = new System.Drawing.Point(0, 129);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 44);
            this.pnlMenu.TabIndex = 2;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.colName,
            this.colCost,
            this.colDescription,
            this.colExpense,
            this.btnEdit,
            this.btnCancel});
            this.gv.Location = new System.Drawing.Point(0, 100);
            this.gv.Margin = new System.Windows.Forms.Padding(2);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 62;
            this.gv.RowTemplate.Height = 28;
            this.gv.Size = new System.Drawing.Size(1108, 231);
            this.gv.TabIndex = 14;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick);
            // 
            // cid
            // 
            this.cid.HeaderText = "ID";
            this.cid.MinimumWidth = 8;
            this.cid.Name = "cid";
            this.cid.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Item Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colCost
            // 
            this.colCost.HeaderText = "Cost";
            this.colCost.MinimumWidth = 8;
            this.colCost.Name = "colCost";
            this.colCost.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 8;
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 150;
            // 
            // colExpense
            // 
            this.colExpense.HeaderText = "Expense Category";
            this.colExpense.MinimumWidth = 8;
            this.colExpense.Name = "colExpense";
            this.colExpense.Width = 150;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.MinimumWidth = 8;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Edit";
            this.btnEdit.ToolTipText = "Edit";
            this.btnEdit.UseColumnTextForButtonValue = true;
            this.btnEdit.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.HeaderText = "Delete";
            this.btnCancel.MinimumWidth = 8;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Delete";
            this.btnCancel.ToolTipText = "Delete";
            this.btnCancel.UseColumnTextForButtonValue = true;
            this.btnCancel.Width = 150;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.cboExpense);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.txtDescription);
            this.pnlData.Controls.Add(this.txtCost);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtItemName);
            this.pnlData.Controls.Add(this.txtID);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(319, 201);
            this.pnlData.Margin = new System.Windows.Forms.Padding(2);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(363, 261);
            this.pnlData.TabIndex = 15;
            // 
            // cboExpense
            // 
            this.cboExpense.FormattingEnabled = true;
            this.cboExpense.Location = new System.Drawing.Point(156, 153);
            this.cboExpense.Margin = new System.Windows.Forms.Padding(2);
            this.cboExpense.Name = "cboExpense";
            this.cboExpense.Size = new System.Drawing.Size(170, 21);
            this.cboExpense.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Expense Category";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(156, 99);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 50);
            this.txtDescription.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(156, 75);
            this.txtCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(170, 20);
            this.txtCost.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(253, 205);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(169, 205);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(73, 26);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(156, 49);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(170, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(156, 25);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(78, 20);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(2, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(78, 34);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmExpenseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 506);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmExpenseItem";
            this.Text = "frmExpenseItem";
            this.Load += new System.EventHandler(this.frmExpenseItem_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpense;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnCancel;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.ComboBox cboExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddNew;
    }
}