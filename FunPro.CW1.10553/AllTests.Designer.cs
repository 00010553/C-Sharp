namespace FunPro.CW1._10553
{
    partial class AllTests
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.testBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsid10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsname10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq110553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq210553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq310553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq1answer10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq2answer10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsq3answer10553DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsid10553DataGridViewTextBoxColumn,
            this.tsname10553DataGridViewTextBoxColumn,
            this.tsq110553DataGridViewTextBoxColumn,
            this.tsq210553DataGridViewTextBoxColumn,
            this.tsq310553DataGridViewTextBoxColumn,
            this.tsq1answer10553DataGridViewTextBoxColumn,
            this.tsq2answer10553DataGridViewTextBoxColumn,
            this.tsq3answer10553DataGridViewTextBoxColumn});
            this.dgv1.DataSource = this.testBindingSource;
            this.dgv1.Location = new System.Drawing.Point(12, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(844, 342);
            this.dgv1.TabIndex = 11;
           
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(418, 371);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(286, 371);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(147, 371);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(12, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // testBindingSource
            // 
            this.testBindingSource.DataSource = typeof(FunPro.CW1._10553.DAL.Test);
            // 
            // tsid10553DataGridViewTextBoxColumn
            // 
            this.tsid10553DataGridViewTextBoxColumn.DataPropertyName = "ts_id_10553";
            this.tsid10553DataGridViewTextBoxColumn.HeaderText = "Id";
            this.tsid10553DataGridViewTextBoxColumn.Name = "tsid10553DataGridViewTextBoxColumn";
            this.tsid10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsname10553DataGridViewTextBoxColumn
            // 
            this.tsname10553DataGridViewTextBoxColumn.DataPropertyName = "ts_name_10553";
            this.tsname10553DataGridViewTextBoxColumn.HeaderText = "Test Name";
            this.tsname10553DataGridViewTextBoxColumn.Name = "tsname10553DataGridViewTextBoxColumn";
            this.tsname10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq110553DataGridViewTextBoxColumn
            // 
            this.tsq110553DataGridViewTextBoxColumn.DataPropertyName = "ts_q1_10553";
            this.tsq110553DataGridViewTextBoxColumn.HeaderText = "Question 1";
            this.tsq110553DataGridViewTextBoxColumn.Name = "tsq110553DataGridViewTextBoxColumn";
            this.tsq110553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq210553DataGridViewTextBoxColumn
            // 
            this.tsq210553DataGridViewTextBoxColumn.DataPropertyName = "ts_q2_10553";
            this.tsq210553DataGridViewTextBoxColumn.HeaderText = "Question 2";
            this.tsq210553DataGridViewTextBoxColumn.Name = "tsq210553DataGridViewTextBoxColumn";
            this.tsq210553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq310553DataGridViewTextBoxColumn
            // 
            this.tsq310553DataGridViewTextBoxColumn.DataPropertyName = "ts_q3_10553";
            this.tsq310553DataGridViewTextBoxColumn.HeaderText = "Question 3";
            this.tsq310553DataGridViewTextBoxColumn.Name = "tsq310553DataGridViewTextBoxColumn";
            this.tsq310553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq1answer10553DataGridViewTextBoxColumn
            // 
            this.tsq1answer10553DataGridViewTextBoxColumn.DataPropertyName = "ts_q1_answer_10553";
            this.tsq1answer10553DataGridViewTextBoxColumn.HeaderText = "Answer 1";
            this.tsq1answer10553DataGridViewTextBoxColumn.Name = "tsq1answer10553DataGridViewTextBoxColumn";
            this.tsq1answer10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq2answer10553DataGridViewTextBoxColumn
            // 
            this.tsq2answer10553DataGridViewTextBoxColumn.DataPropertyName = "ts_q2_answer_10553";
            this.tsq2answer10553DataGridViewTextBoxColumn.HeaderText = "Answer 2";
            this.tsq2answer10553DataGridViewTextBoxColumn.Name = "tsq2answer10553DataGridViewTextBoxColumn";
            this.tsq2answer10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsq3answer10553DataGridViewTextBoxColumn
            // 
            this.tsq3answer10553DataGridViewTextBoxColumn.DataPropertyName = "ts_q3_answer_10553";
            this.tsq3answer10553DataGridViewTextBoxColumn.HeaderText = "Answer 3";
            this.tsq3answer10553DataGridViewTextBoxColumn.Name = "tsq3answer10553DataGridViewTextBoxColumn";
            this.tsq3answer10553DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 419);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv1);
            this.Name = "AllTests";
            this.Text = "AllTests";
            this.Load += new System.EventHandler(this.AllTests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource testBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsid10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsname10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq110553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq210553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq310553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq1answer10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq2answer10553DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsq3answer10553DataGridViewTextBoxColumn;
    }
}