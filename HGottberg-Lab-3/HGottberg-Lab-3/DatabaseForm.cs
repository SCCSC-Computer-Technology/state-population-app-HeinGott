using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGottberg_Lab_3
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDatabaseDataSet.StateInfoTable' table. You can move, or remove it, as needed.
            this.stateInfoTableTableAdapter.Fill(this.stateDatabaseDataSet.StateInfoTable);
            
            //fill in the filter combo box
            comboBoxColumns.Items.AddRange(new string[]
            {
                "State_Name",
                "Population",
                "Flag_Description",
                "Flower",
                "Bird",
                "Median_Income",
                "Capitol",
                "Percentage_of_Tech_Jobs"
            });

            comboBoxColumns.SelectedIndex = 0; 
        }

        //search for a state
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string stateName;
            stateName = txtBoxSearch.Text.Trim();
            if (string.IsNullOrEmpty(stateName))
            {
                MessageBox.Show("Enter a state name into the search bar.");
                return;
            }
            stateInfoTableBindingSource.Filter = $"State_Name LIKE '%{stateName.Replace("'", "''")}%'";
        }

        //sort columns ascending
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxColumns.Text))
            {
                MessageBox.Show("Please select a column to sort.");
                return;
            }

            try
            {
                stateInfoTableBindingSource.Sort = "";
                stateInfoTableBindingSource.Sort =  comboBoxColumns.Text + " ASC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sort failed: " + ex.Message);
            }
        }

        //sort columns descending 
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxColumns.Text))
            {
                MessageBox.Show("Please select a column to sort.");
                return;
            }

            try
            {
                stateInfoTableBindingSource.Sort = "";
                stateInfoTableBindingSource.Sort = comboBoxColumns.Text + " DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sort failed: " + ex.Message);
            }
        }

        private void btnExitDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
