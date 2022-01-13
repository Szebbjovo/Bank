namespace Bank.Forms
{
    partial class AccountsManager_employeOnly
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vasbankDataSet = new Bank.vasbankDataSet();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsTableAdapter = new Bank.vasbankDataSetTableAdapters.PostsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egyenlegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szuletesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regisztracioDatumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasbankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.egyenlegDataGridViewTextBoxColumn,
            this.kNevDataGridViewTextBoxColumn,
            this.vNevDataGridViewTextBoxColumn,
            this.szuletesDataGridViewTextBoxColumn,
            this.regisztracioDatumaDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.employeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.postsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // vasbankDataSet
            // 
            this.vasbankDataSet.DataSetName = "vasbankDataSet";
            this.vasbankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.vasbankDataSet;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egyenlegDataGridViewTextBoxColumn
            // 
            this.egyenlegDataGridViewTextBoxColumn.DataPropertyName = "egyenleg";
            this.egyenlegDataGridViewTextBoxColumn.HeaderText = "egyenleg";
            this.egyenlegDataGridViewTextBoxColumn.Name = "egyenlegDataGridViewTextBoxColumn";
            // 
            // kNevDataGridViewTextBoxColumn
            // 
            this.kNevDataGridViewTextBoxColumn.DataPropertyName = "kNev";
            this.kNevDataGridViewTextBoxColumn.HeaderText = "kNev";
            this.kNevDataGridViewTextBoxColumn.Name = "kNevDataGridViewTextBoxColumn";
            // 
            // vNevDataGridViewTextBoxColumn
            // 
            this.vNevDataGridViewTextBoxColumn.DataPropertyName = "vNev";
            this.vNevDataGridViewTextBoxColumn.HeaderText = "vNev";
            this.vNevDataGridViewTextBoxColumn.Name = "vNevDataGridViewTextBoxColumn";
            // 
            // szuletesDataGridViewTextBoxColumn
            // 
            this.szuletesDataGridViewTextBoxColumn.DataPropertyName = "szuletes";
            this.szuletesDataGridViewTextBoxColumn.HeaderText = "szuletes";
            this.szuletesDataGridViewTextBoxColumn.Name = "szuletesDataGridViewTextBoxColumn";
            // 
            // regisztracioDatumaDataGridViewTextBoxColumn
            // 
            this.regisztracioDatumaDataGridViewTextBoxColumn.DataPropertyName = "regisztracioDatuma";
            this.regisztracioDatumaDataGridViewTextBoxColumn.HeaderText = "regisztracioDatuma";
            this.regisztracioDatumaDataGridViewTextBoxColumn.Name = "regisztracioDatumaDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // employeDataGridViewCheckBoxColumn
            // 
            this.employeDataGridViewCheckBoxColumn.DataPropertyName = "employe";
            this.employeDataGridViewCheckBoxColumn.HeaderText = "employe";
            this.employeDataGridViewCheckBoxColumn.Name = "employeDataGridViewCheckBoxColumn";
            // 
            // AccountsManager_employeOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AccountsManager_employeOnly";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AccountsManager_employeOnly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasbankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private vasbankDataSet vasbankDataSet;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private vasbankDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egyenlegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szuletesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisztracioDatumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn employeDataGridViewCheckBoxColumn;
    }
}