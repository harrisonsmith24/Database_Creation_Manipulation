using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_cc4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smith_MedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smith_MedicalDataSet1.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter1.Fill(this.smith_MedicalDataSet1.Table);
            // TODO: This line of code loads data into the 'smith_MedicalDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.smith_MedicalDataSet.Table);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
