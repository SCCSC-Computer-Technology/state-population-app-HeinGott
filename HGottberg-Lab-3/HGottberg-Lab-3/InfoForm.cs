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
    public partial class InfoForm : Form
    {
        private string _stateName;
        public InfoForm(string stateName)
        {
            InitializeComponent();
            _stateName = stateName;
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateDatabaseDataSet.StateInfoTable' table. You can move, or remove it, as needed.
            this.stateInfoTableTableAdapter.FillByStateName(this.stateDatabaseDataSet.StateInfoTable, _stateName);

        }

        private void stateInfoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateInfoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stateDatabaseDataSet);

        }

        private void btnOpenInfoForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
