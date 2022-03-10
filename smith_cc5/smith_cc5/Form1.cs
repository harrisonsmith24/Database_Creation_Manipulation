using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smith_cc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smithMedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smithMedicalDataSet.patientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.smithMedicalDataSet.patientInfo);

        }

        // Sort the information by height
        private void heightBtn_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByHeight(this.smithMedicalDataSet.patientInfo);
        }
        //Display the patients info that are over 200lbs
        private void largeWeightBtn_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByLargeWeight(this.smithMedicalDataSet.patientInfo);
        }
        // Display the weight of patients info with a weight under 100 pounds
        private void smallWeightBtn_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByLowWeight(this.smithMedicalDataSet.patientInfo);
        }
        // display information of the patients that are over 70 yrs old
        private void ageBtn_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByAge(this.smithMedicalDataSet.patientInfo);
        }
        // display information of the patients that have an a1cvalue greater than 5.7
        private void valueBtn_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByCvalue(this.smithMedicalDataSet.patientInfo);
        }
    }
}
