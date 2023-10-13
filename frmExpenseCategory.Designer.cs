namespace P00196754_Md_Nawaz_Sharif_Nahid_ExpenseTracker
{
    partial class frmExpenseCategory
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gv = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(233, 50);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(158, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(233, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(158, 20);
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
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expense Category Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblTitle.Location = new System.Drawing.Point(175, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 31);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Expense Category ";
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
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnClose);
            this.pnlData.Controls.Add(this.btnInsert);
            this.pnlData.Controls.Add(this.txtCategoryName);
            this.pnlData.Controls.Add(this.txtID);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(163, 223);
            this.pnlData.Margin = new System.Windows.Forms.Padding(2);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(454, 168);
            this.pnlData.TabIndex = 18;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(318, 108);
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
            this.btnInsert.Location = new System.Drawing.Point(234, 108);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(73, 26);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colName
            // 
            this.colName.HeaderText = "Category Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.colName,
            this.btnEdit,
            this.Cancel});
            this.gv.Location = new System.Drawing.Point(2, 96);
            this.gv.Margin = new System.Windows.Forms.Padding(2);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 62;
            this.gv.RowTemplate.Height = 28;
            this.gv.Size = new System.Drawing.Size(663, 231);
            this.gv.TabIndex = 19;
            this.gv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_CellContentClick);
            // 
            // cid
            // 
            this.cid.HeaderText = "ID";
            this.cid.MinimumWidth = 8;
            this.cid.Name = "cid";
            this.cid.Width = 150;
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
            // Cancel
            // 
            this.Cancel.HeaderText = "Delete";
            this.Cancel.MinimumWidth = 8;
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Delete";
            this.Cancel.ToolTipText = "Delete";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 150;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pnlMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(845, 55);
            this.pnlTop.TabIndex = 17;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(2, 61);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(98, 30);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmExpenseCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 473);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmExpenseCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExpenseCategory";
            this.Load += new System.EventHandler(this.frmExpenseCategory_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnAddNew;
    }
}