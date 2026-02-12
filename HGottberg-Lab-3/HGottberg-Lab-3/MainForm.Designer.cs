namespace HGottberg_Lab_3
{
    partial class MainForm
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
            this.btnViewDatabase = new System.Windows.Forms.Button();
            this.stateDatabaseDataSet = new HGottberg_Lab_3.StateDatabaseDataSet();
            this.stateInfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoTableTableAdapter = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter();
            this.tableAdapterManager = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.TableAdapterManager();
            this.comboBoxStates = new System.Windows.Forms.ComboBox();
            this.btnOpenInfoForm = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblheader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewDatabase
            // 
            this.btnViewDatabase.Location = new System.Drawing.Point(253, 561);
            this.btnViewDatabase.Name = "btnViewDatabase";
            this.btnViewDatabase.Size = new System.Drawing.Size(182, 47);
            this.btnViewDatabase.TabIndex = 0;
            this.btnViewDatabase.Text = "&View Database";
            this.btnViewDatabase.UseVisualStyleBackColor = true;
            this.btnViewDatabase.Click += new System.EventHandler(this.btnViewDatabase_Click);
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
            // comboBoxStates
            // 
            this.comboBoxStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxStates.DataSource = this.stateInfoTableBindingSource;
            this.comboBoxStates.DisplayMember = "State_Name";
            this.comboBoxStates.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStates.FormattingEnabled = true;
            this.comboBoxStates.Location = new System.Drawing.Point(253, 70);
            this.comboBoxStates.Name = "comboBoxStates";
            this.comboBoxStates.Size = new System.Drawing.Size(182, 28);
            this.comboBoxStates.TabIndex = 2;
            this.comboBoxStates.ValueMember = "State_Name";
            // 
            // btnOpenInfoForm
            // 
            this.btnOpenInfoForm.Location = new System.Drawing.Point(15, 561);
            this.btnOpenInfoForm.Name = "btnOpenInfoForm";
            this.btnOpenInfoForm.Size = new System.Drawing.Size(182, 47);
            this.btnOpenInfoForm.TabIndex = 3;
            this.btnOpenInfoForm.Text = "&State Information";
            this.btnOpenInfoForm.UseVisualStyleBackColor = true;
            this.btnOpenInfoForm.Click += new System.EventHandler(this.btnOpenInfoForm_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.Location = new System.Drawing.Point(495, 561);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(182, 47);
            this.btnCloseApplication.TabIndex = 4;
            this.btnCloseApplication.Text = "&Close Application";
            this.btnCloseApplication.UseVisualStyleBackColor = true;
            this.btnCloseApplication.Click += new System.EventHandler(this.btnCloseApplication_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 498);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(234, 60);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Select a state from the\r\ndropdown menu and\r\nselect State Information.\r\n";
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(71, 9);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(592, 47);
            this.lblheader.TabIndex = 6;
            this.lblheader.Text = "State Database Information";
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnOpenInfoForm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseApplication;
            this.ClientSize = new System.Drawing.Size(683, 620);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.btnOpenInfoForm);
            this.Controls.Add(this.comboBoxStates);
            this.Controls.Add(this.btnViewDatabase);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm HGottberg Lab 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewDatabase;
        private StateDatabaseDataSet stateDatabaseDataSet;
        private System.Windows.Forms.BindingSource stateInfoTableBindingSource;
        private StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter stateInfoTableTableAdapter;
        private StateDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBoxStates;
        private System.Windows.Forms.Button btnOpenInfoForm;
        private System.Windows.Forms.Button btnCloseApplication;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblheader;
    }
}

