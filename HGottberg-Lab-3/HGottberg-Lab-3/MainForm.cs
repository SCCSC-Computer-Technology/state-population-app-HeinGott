using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateLibrary;

namespace HGottberg_Lab_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            DatabaseForm frm = new DatabaseForm();
            frm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDatabaseDataSet.StateInfoTable' table. You can move, or remove it, as needed.
            this.stateInfoTableTableAdapter.Fill(this.stateDatabaseDataSet.StateInfoTable);                      
        }              

        private void btnOpenInfoForm_Click(object sender, EventArgs e)
        {
            string selectedState = comboBoxStates.Text.Trim();

            InfoForm frm = new InfoForm(selectedState);
            frm.ShowDialog();
        }

        private void btnCloseApplication_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
