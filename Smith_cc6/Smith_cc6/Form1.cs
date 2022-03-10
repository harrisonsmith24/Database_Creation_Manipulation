using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smith_cc6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smithMedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smithMedicalDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.smithMedicalDataSet.Patients);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchDescription(this.smithMedicalDataSet.Patients, txtSearch.Text);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.Fill(this.smithMedicalDataSet.Patients);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchAddress(this.smithMedicalDataSet.Patients, txtSearch.Text);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchPhone(this.smithMedicalDataSet.Patients, txtSearch.Text);
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            this.patientsTableAdapter.SearchEmail(this.smithMedicalDataSet.Patients, txtSearch.Text);
        }

        private void btnDeduct_Click(object sender, EventArgs e)
        {
            decimal priceToSearch;
            Decimal.TryParse(txtSearch.Text, out priceToSearch);

            this.patientsTableAdapter.SearchDeduct(this.smithMedicalDataSet.Patients, priceToSearch);
        }
    }
}
