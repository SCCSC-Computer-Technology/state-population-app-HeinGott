namespace HGottberg_Lab_3
{
    partial class InfoForm
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
            this.stateDatabaseDataSet = new HGottberg_Lab_3.StateDatabaseDataSet();
            this.stateInfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoTableTableAdapter = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter();
            this.tableAdapterManager = new HGottberg_Lab_3.StateDatabaseDataSetTableAdapters.TableAdapterManager();
            this.lblheader = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblFlagDescription = new System.Windows.Forms.Label();
            this.lblFlower = new System.Windows.Forms.Label();
            this.lblBird = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblLargestCitites = new System.Windows.Forms.Label();
            this.lblCapitol = new System.Windows.Forms.Label();
            this.lblMedianIncome = new System.Windows.Forms.Label();
            this.lblTechJobs = new System.Windows.Forms.Label();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxCapitol = new System.Windows.Forms.TextBox();
            this.txtBoxPopulation = new System.Windows.Forms.TextBox();
            this.txtBoxStateFlower = new System.Windows.Forms.TextBox();
            this.txtBoxStateBird = new System.Windows.Forms.TextBox();
            this.txtBoxPercentofTechJobs = new System.Windows.Forms.TextBox();
            this.txtBoxMedianIncome = new System.Windows.Forms.TextBox();
            this.txtBoxLargestCities = new System.Windows.Forms.TextBox();
            this.txtBoxStateColor = new System.Windows.Forms.TextBox();
            this.txtBoxFlagDescription = new System.Windows.Forms.TextBox();
            this.btnCloseInfoForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(176, 35);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(790, 47);
            this.lblheader.TabIndex = 7;
            this.lblheader.Text = "State Database Detailed Information";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(170, 119);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(76, 23);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "State:";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulation.Location = new System.Drawing.Point(115, 228);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(131, 23);
            this.lblPopulation.TabIndex = 9;
            this.lblPopulation.Text = "Population:";
            // 
            // lblFlagDescription
            // 
            this.lblFlagDescription.AutoSize = true;
            this.lblFlagDescription.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlagDescription.Location = new System.Drawing.Point(508, 277);
            this.lblFlagDescription.Name = "lblFlagDescription";
            this.lblFlagDescription.Size = new System.Drawing.Size(197, 23);
            this.lblFlagDescription.TabIndex = 10;
            this.lblFlagDescription.Text = "Flag Description:";
            // 
            // lblFlower
            // 
            this.lblFlower.AutoSize = true;
            this.lblFlower.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlower.Location = new System.Drawing.Point(551, 117);
            this.lblFlower.Name = "lblFlower";
            this.lblFlower.Size = new System.Drawing.Size(153, 23);
            this.lblFlower.TabIndex = 11;
            this.lblFlower.Text = "State Flower:";
            // 
            // lblBird
            // 
            this.lblBird.AutoSize = true;
            this.lblBird.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBird.Location = new System.Drawing.Point(573, 171);
            this.lblBird.Name = "lblBird";
            this.lblBird.Size = new System.Drawing.Size(131, 23);
            this.lblBird.TabIndex = 12;
            this.lblBird.Text = "State Bird:";
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColors.Location = new System.Drawing.Point(551, 225);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(153, 23);
            this.lblColors.TabIndex = 13;
            this.lblColors.Text = "State Colors:";
            // 
            // lblLargestCitites
            // 
            this.lblLargestCitites.AutoSize = true;
            this.lblLargestCitites.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargestCitites.Location = new System.Drawing.Point(71, 280);
            this.lblLargestCitites.Name = "lblLargestCitites";
            this.lblLargestCitites.Size = new System.Drawing.Size(175, 23);
            this.lblLargestCitites.TabIndex = 14;
            this.lblLargestCitites.Text = "Largest Cities:";
            // 
            // lblCapitol
            // 
            this.lblCapitol.AutoSize = true;
            this.lblCapitol.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapitol.Location = new System.Drawing.Point(148, 174);
            this.lblCapitol.Name = "lblCapitol";
            this.lblCapitol.Size = new System.Drawing.Size(98, 23);
            this.lblCapitol.TabIndex = 15;
            this.lblCapitol.Text = "Capitol:";
            // 
            // lblMedianIncome
            // 
            this.lblMedianIncome.AutoSize = true;
            this.lblMedianIncome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedianIncome.Location = new System.Drawing.Point(82, 332);
            this.lblMedianIncome.Name = "lblMedianIncome";
            this.lblMedianIncome.Size = new System.Drawing.Size(164, 23);
            this.lblMedianIncome.TabIndex = 16;
            this.lblMedianIncome.Text = "Median Income:";
            // 
            // lblTechJobs
            // 
            this.lblTechJobs.AutoSize = true;
            this.lblTechJobs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechJobs.Location = new System.Drawing.Point(71, 383);
            this.lblTechJobs.Name = "lblTechJobs";
            this.lblTechJobs.Size = new System.Drawing.Size(175, 23);
            this.lblTechJobs.TabIndex = 17;
            this.lblTechJobs.Text = "% of Tech Jobs:";
            // 
            // txtBoxState
            // 
            this.txtBoxState.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "State_Name", true));
            this.txtBoxState.Location = new System.Drawing.Point(252, 117);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.ReadOnly = true;
            this.txtBoxState.Size = new System.Drawing.Size(252, 25);
            this.txtBoxState.TabIndex = 18;
            // 
            // txtBoxCapitol
            // 
            this.txtBoxCapitol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxCapitol.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Capitol", true));
            this.txtBoxCapitol.Location = new System.Drawing.Point(252, 172);
            this.txtBoxCapitol.Name = "txtBoxCapitol";
            this.txtBoxCapitol.ReadOnly = true;
            this.txtBoxCapitol.Size = new System.Drawing.Size(252, 25);
            this.txtBoxCapitol.TabIndex = 19;
            // 
            // txtBoxPopulation
            // 
            this.txtBoxPopulation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxPopulation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Population", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtBoxPopulation.Location = new System.Drawing.Point(252, 226);
            this.txtBoxPopulation.Name = "txtBoxPopulation";
            this.txtBoxPopulation.ReadOnly = true;
            this.txtBoxPopulation.Size = new System.Drawing.Size(252, 25);
            this.txtBoxPopulation.TabIndex = 20;
            // 
            // txtBoxStateFlower
            // 
            this.txtBoxStateFlower.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxStateFlower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Flower", true));
            this.txtBoxStateFlower.Location = new System.Drawing.Point(711, 115);
            this.txtBoxStateFlower.Name = "txtBoxStateFlower";
            this.txtBoxStateFlower.ReadOnly = true;
            this.txtBoxStateFlower.Size = new System.Drawing.Size(237, 25);
            this.txtBoxStateFlower.TabIndex = 21;
            // 
            // txtBoxStateBird
            // 
            this.txtBoxStateBird.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxStateBird.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Bird", true));
            this.txtBoxStateBird.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStateBird.Location = new System.Drawing.Point(711, 169);
            this.txtBoxStateBird.Name = "txtBoxStateBird";
            this.txtBoxStateBird.ReadOnly = true;
            this.txtBoxStateBird.Size = new System.Drawing.Size(237, 25);
            this.txtBoxStateBird.TabIndex = 22;
            // 
            // txtBoxPercentofTechJobs
            // 
            this.txtBoxPercentofTechJobs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxPercentofTechJobs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Percentage_of_Tech_Jobs", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtBoxPercentofTechJobs.Location = new System.Drawing.Point(252, 384);
            this.txtBoxPercentofTechJobs.Name = "txtBoxPercentofTechJobs";
            this.txtBoxPercentofTechJobs.ReadOnly = true;
            this.txtBoxPercentofTechJobs.Size = new System.Drawing.Size(252, 25);
            this.txtBoxPercentofTechJobs.TabIndex = 23;
            // 
            // txtBoxMedianIncome
            // 
            this.txtBoxMedianIncome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxMedianIncome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Median_Income", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C0"));
            this.txtBoxMedianIncome.Location = new System.Drawing.Point(252, 330);
            this.txtBoxMedianIncome.Name = "txtBoxMedianIncome";
            this.txtBoxMedianIncome.ReadOnly = true;
            this.txtBoxMedianIncome.Size = new System.Drawing.Size(252, 25);
            this.txtBoxMedianIncome.TabIndex = 24;
            // 
            // txtBoxLargestCities
            // 
            this.txtBoxLargestCities.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxLargestCities.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Largest_Cities", true));
            this.txtBoxLargestCities.Location = new System.Drawing.Point(252, 278);
            this.txtBoxLargestCities.Name = "txtBoxLargestCities";
            this.txtBoxLargestCities.ReadOnly = true;
            this.txtBoxLargestCities.Size = new System.Drawing.Size(252, 25);
            this.txtBoxLargestCities.TabIndex = 25;
            // 
            // txtBoxStateColor
            // 
            this.txtBoxStateColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxStateColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Colors", true));
            this.txtBoxStateColor.Location = new System.Drawing.Point(710, 223);
            this.txtBoxStateColor.Name = "txtBoxStateColor";
            this.txtBoxStateColor.ReadOnly = true;
            this.txtBoxStateColor.Size = new System.Drawing.Size(237, 25);
            this.txtBoxStateColor.TabIndex = 26;
            // 
            // txtBoxFlagDescription
            // 
            this.txtBoxFlagDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stateInfoTableBindingSource, "Flag_Description", true));
            this.txtBoxFlagDescription.Location = new System.Drawing.Point(711, 278);
            this.txtBoxFlagDescription.Multiline = true;
            this.txtBoxFlagDescription.Name = "txtBoxFlagDescription";
            this.txtBoxFlagDescription.Size = new System.Drawing.Size(374, 321);
            this.txtBoxFlagDescription.TabIndex = 27;
            // 
            // btnCloseInfoForm
            // 
            this.btnCloseInfoForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseInfoForm.Location = new System.Drawing.Point(278, 492);
            this.btnCloseInfoForm.Name = "btnCloseInfoForm";
            this.btnCloseInfoForm.Size = new System.Drawing.Size(182, 47);
            this.btnCloseInfoForm.TabIndex = 28;
            this.btnCloseInfoForm.Text = "Close Info &Form";
            this.btnCloseInfoForm.UseVisualStyleBackColor = true;
            this.btnCloseInfoForm.Click += new System.EventHandler(this.btnOpenInfoForm_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnCloseInfoForm;
            this.ClientSize = new System.Drawing.Size(1105, 619);
            this.Controls.Add(this.btnCloseInfoForm);
            this.Controls.Add(this.txtBoxFlagDescription);
            this.Controls.Add(this.txtBoxStateColor);
            this.Controls.Add(this.txtBoxLargestCities);
            this.Controls.Add(this.txtBoxMedianIncome);
            this.Controls.Add(this.txtBoxPercentofTechJobs);
            this.Controls.Add(this.txtBoxStateBird);
            this.Controls.Add(this.txtBoxStateFlower);
            this.Controls.Add(this.txtBoxPopulation);
            this.Controls.Add(this.txtBoxCapitol);
            this.Controls.Add(this.txtBoxState);
            this.Controls.Add(this.lblTechJobs);
            this.Controls.Add(this.lblMedianIncome);
            this.Controls.Add(this.lblCapitol);
            this.Controls.Add(this.lblLargestCitites);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lblBird);
            this.Controls.Add(this.lblFlower);
            this.Controls.Add(this.lblFlagDescription);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblheader);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateDatabaseDataSet stateDatabaseDataSet;
        private System.Windows.Forms.BindingSource stateInfoTableBindingSource;
        private StateDatabaseDataSetTableAdapters.StateInfoTableTableAdapter stateInfoTableTableAdapter;
        private StateDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblFlagDescription;
        private System.Windows.Forms.Label lblFlower;
        private System.Windows.Forms.Label lblBird;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblLargestCitites;
        private System.Windows.Forms.Label lblCapitol;
        private System.Windows.Forms.Label lblMedianIncome;
        private System.Windows.Forms.Label lblTechJobs;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxCapitol;
        private System.Windows.Forms.TextBox txtBoxPopulation;
        private System.Windows.Forms.TextBox txtBoxStateFlower;
        private System.Windows.Forms.TextBox txtBoxStateBird;
        private System.Windows.Forms.TextBox txtBoxPercentofTechJobs;
        private System.Windows.Forms.TextBox txtBoxMedianIncome;
        private System.Windows.Forms.TextBox txtBoxLargestCities;
        private System.Windows.Forms.TextBox txtBoxStateColor;
        private System.Windows.Forms.TextBox txtBoxFlagDescription;
        private System.Windows.Forms.Button btnCloseInfoForm;
    }
}