namespace HGottberg_Lab_3
{
    partial class DatabaseForm
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
            this.stateDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateDatabaseDataSet = new HGottberg_Lab_3.StateDatabaseDataSet();
            this.stateInfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoTableTableAdapter = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter();
            this.tableAdapterManager = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.TableAdapterManager();
            this.stateInfoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxColumns = new System.Windows.Forms.ComboBox();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.stateInfoTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSort = new System.Windows.Forms.Label();
            this.btnExitDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // stateDatabaseDataSetBindingSource
            // 
            this.stateDatabaseDataSetBindingSource.DataSource = this.stateDatabaseDataSet;
            this.stateDatabaseDataSetBindingSource.Position = 0;
            // 
            // stateDatabaseDataSet
            // 
            this.stateDatabaseDataSet.DataSetName = "StateDatabaseDataSet";
            this.stateDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stateInfoTableBindingSource
            // 
            this.stateInfoTableBindingSource.DataMember = "StateInfoTable";
            this.stateInfoTableBindingSource.DataSource = this.stateDatabaseDataSet;
            // 
            // stateInfoTableTableAdapter
            // 
            this.stateInfoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StateInfoTableTableAdapter = this.stateInfoTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateInfoTableDataGridView
            // 
            this.stateInfoTableDataGridView.AllowUserToAddRows = false;
            this.stateInfoTableDataGridView.AllowUserToDeleteRows = false;
            this.stateInfoTableDataGridView.AutoGenerateColumns = false;
            this.stateInfoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateInfoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.stateInfoTableDataGridView.DataSource = this.stateInfoTableBindingSource;
            this.stateInfoTableDataGridView.Location = new System.Drawing.Point(12, 98);
            this.stateInfoTableDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stateInfoTableDataGridView.Name = "stateInfoTableDataGridView";
            this.stateInfoTableDataGridView.RowHeadersWidth = 51;
            this.stateInfoTableDataGridView.RowTemplate.Height = 24;
            this.stateInfoTableDataGridView.Size = new System.Drawing.Size(1358, 642);
            this.stateInfoTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "State_Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "State";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Flag_Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Flag Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Flower";
            this.dataGridViewTextBoxColumn4.HeaderText = "Flower";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Bird";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bird";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Colors";
            this.dataGridViewTextBoxColumn6.HeaderText = "Colors";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Largest_Cities";
            this.dataGridViewTextBoxColumn7.HeaderText = "Largest Cities";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 135;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Capitol";
            this.dataGridViewTextBoxColumn8.HeaderText = "Capitol";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Median_Income";
            this.dataGridViewTextBoxColumn9.HeaderText = "Median Income";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Percentage_of_Tech_Jobs";
            this.dataGridViewTextBoxColumn10.HeaderText = "Percent of Tech Jobs";
            this.dataGridViewTextBoxColumn10.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(334, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search:";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(412, 19);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(175, 25);
            this.txtBoxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(447, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxColumns
            // 
            this.comboBoxColumns.FormattingEnabled = true;
            this.comboBoxColumns.Location = new System.Drawing.Point(781, 19);
            this.comboBoxColumns.Name = "comboBoxColumns";
            this.comboBoxColumns.Size = new System.Drawing.Size(199, 26);
            this.comboBoxColumns.TabIndex = 4;
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Location = new System.Drawing.Point(781, 49);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(93, 27);
            this.btnSortAsc.TabIndex = 5;
            this.btnSortAsc.Text = "Sort &Asc";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Location = new System.Drawing.Point(889, 49);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(91, 27);
            this.btnSortDesc.TabIndex = 6;
            this.btnSortDesc.Text = "Sort &Desc";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // stateInfoTableBindingSource1
            // 
            this.stateInfoTableBindingSource1.DataMember = "StateInfoTable";
            this.stateInfoTableBindingSource1.DataSource = this.stateDatabaseDataSetBindingSource;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(721, 20);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(54, 20);
            this.lblSort.TabIndex = 7;
            this.lblSort.Text = "Sort:";
            // 
            // btnExitDatabase
            // 
            this.btnExitDatabase.Location = new System.Drawing.Point(1212, 36);
            this.btnExitDatabase.Name = "btnExitDatabase";
            this.btnExitDatabase.Size = new System.Drawing.Size(96, 27);
            this.btnExitDatabase.TabIndex = 8;
            this.btnExitDatabase.Text = "&Exit";
            this.btnExitDatabase.UseVisualStyleBackColor = true;
            this.btnExitDatabase.Click += new System.EventHandler(this.btnExitDatabase_Click);
            // 
            // DatabaseForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExitDatabase;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.btnExitDatabase);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.comboBoxColumns);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.stateInfoTableDataGridView);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseForm";
            this.Load += new System.EventHandler(this.DatabaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource stateDatabaseDataSetBindingSource;
        private StateDatabaseDataSet stateDatabaseDataSet;
        private System.Windows.Forms.BindingSource stateInfoTableBindingSource;
        private StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter stateInfoTableTableAdapter;
        private StateDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView stateInfoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxColumns;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
        private System.Windows.Forms.BindingSource stateInfoTableBindingSource1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnExitDatabase;
    }
}