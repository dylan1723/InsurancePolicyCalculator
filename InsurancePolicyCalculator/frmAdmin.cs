using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InsurancePolicyCalculator
{
    public partial class frmAdmin : Form
    {
        List<Policy> policies = new List<Policy>();
        List<Driver> drivers = new List<Driver>();

        public frmAdmin(List<Policy> policies, List<Driver> drivers)
        {
            this.policies = policies;
            this.drivers = drivers;
            InitializeComponent();
        }

        private void btnAdminPolicy_Click(object sender, EventArgs e)
        {
            txtAdminDisplay.Clear();

            string date = dtpAdminDate.Value.ToString("dd-MM-yy");
            string line, line2;

            try
            {
                StreamReader reader = File.OpenText("Insurance_Policies" + date + ".csv");

                txtAdminDisplay.AppendText("Start Date\rDrivers\r\tAge\r\tVehicle\r\tYears without Claim\r\tVehicle Kept\r\tHolder Occupation\r\tVehicle Usage\r\tVehicle Prem\r\tKept Prem\r\tOccupation Prem\r\tUsage Prem\r\tAge Prem\r\tClaims Prem\r\tTotal Premium\r\tStatus" + "\r\n");

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    line2 = "";

                    string[] values = line.Split(',');

                    foreach (string s in values)
                    {
                        line2 = line2 + s + "\t";
                    }
                    txtAdminDisplay.AppendText(line2 + "\r\n");
                }
                reader.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Policies were created on this day\nChoose a different date");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmAdminM = new frmMainMenu();
            frmAdminM.ShowDialog();
        }
    }
}
