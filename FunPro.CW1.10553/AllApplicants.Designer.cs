namespace FunPro.CW1._10553
{
    partial class AllApplicants
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.apid10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apname10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apscore10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apteststaken10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxSort = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apid10553DataGridViewTextBoxColumn,
            this.apname10553DataGridViewTextBoxColumn,
            this.apscore10553DataGridViewTextBoxColumn,
            this.apteststaken10553DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.applicantBindingSource;
            this.dgv.Location = new System.Drawing.Point(31, 25);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(444, 333);
            this.dgv.TabIndex = 0;
            // 
            // apid10553DataGridViewTextBoxColumn
            // 
            this.apid10553DataGridViewTextBoxColumn.DataPropertyName = "ap_id_10553";
            this.apid10553DataGridViewTextBoxColumn.HeaderText = "Id";
            this.apid10553DataGridViewTextBoxColumn.Name = "apid10553DataGridViewTextBoxColumn";
            this.apid10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apname10553DataGridViewTextBoxColumn
            // 
            this.apname10553DataGridViewTextBoxColumn.DataPropertyName = "ap_name_10553";
            this.apname10553DataGridViewTextBoxColumn.HeaderText = "Name";
            this.apname10553DataGridViewTextBoxColumn.Name = "apname10553DataGridViewTextBoxColumn";
            this.apname10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apscore10553DataGridViewTextBoxColumn
            // 
            this.apscore10553DataGridViewTextBoxColumn.DataPropertyName = "ap_score_10553";
            this.apscore10553DataGridViewTextBoxColumn.HeaderText = "Score";
            this.apscore10553DataGridViewTextBoxColumn.Name = "apscore10553DataGridViewTextBoxColumn";
            this.apscore10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apteststaken10553DataGridViewTextBoxColumn
            // 
            this.apteststaken10553DataGridViewTextBoxColumn.DataPropertyName = "ap_tests_taken_10553";
            this.apteststaken10553DataGridViewTextBoxColumn.HeaderText = "Tests Taken";
            this.apteststaken10553DataGridViewTextBoxColumn.Name = "apteststaken10553DataGridViewTextBoxColumn";
            this.apteststaken10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicantBindingSource
            // 
            this.applicantBindingSource.DataSource = typeof(FunPro.CW1._10553.DAL.Applicant);
            // 
            // cbxSearch
            // 
            this.cbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.cbxSearch.Location = new System.Drawing.Point(165, 402);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(121, 21);
            this.cbxSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.Location = new System.Drawing.Point(292, 400);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxSearch.Location = new System.Drawing.Point(38, 402);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(121, 20);
            this.tbxSearch.TabIndex = 17;
            // 
            // cbxSort
            // 
            this.cbxSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSort.FormattingEnabled = true;
            this.cbxSort.Items.AddRange(new object[] {
            "Name",
            "Score"});
            this.cbxSort.Location = new System.Drawing.Point(38, 374);
            this.cbxSort.Name = "cbxSort";
            this.cbxSort.Size = new System.Drawing.Size(121, 21);
            this.cbxSort.TabIndex = 16;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSort.Location = new System.Drawing.Point(165, 374);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 15;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(491, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(491, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(491, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(491, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AllApplicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 440);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.cbxSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgv);
            this.Name = "AllApplicants";
            this.Text = "AllApplicants";
            this.Load += new System.EventHandler(this.AllApplicants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource applicantBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn apid10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apname10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apscore10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apteststaken10553DataGridViewTextBoxColumn;
    }
}