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
    public partial class frmInput : Form
    {
        List<string> holOccupations = new List<string>(); //Lists to store details
        List<string> occupationPremium = new List<string>();
        List<string> vehicles = new List<string>();
        List<string> vehPremium = new List<string>();
        List<Driver> drivers; 
        List<Policy> policies;

        double jobPrice, vehPrice, jobCost, vehCost, ageCost, claimsCost, noClaims, usageCost, keptCost; //Declare variables
        double totalPrem = 300;
        string status = "Processed";
        int numDrivers = 0;
        int maxDrivers = 5;
        double usageValue = 0;
        double keptValue = 0;
        int age;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMen = new frmMainMenu(); //Open frmMainMenu form
            frmMen.ShowDialog();
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            btnAddPolicy.Enabled = true; //Enable and disable buttons 
            btnAddDriver.Enabled = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnAddPolicy.Enabled = true;
            btnYes.Enabled = false;
        }

        public frmInput()
        {
            InitializeComponent();
            policies = new List<Policy>();
            drivers = new List<Driver>();

            StreamReader jobReader = File.OpenText("JobList.csv");
            while (!jobReader.EndOfStream)
            {
                String jobLine = jobReader.ReadLine();
                String[] jobValue = jobLine.Split(',');
                holOccupations.Add(jobValue[0]);
                occupationPremium.Add(jobValue[1]);
                lstHolderOccupation.Items.Add(jobValue[0]); // Adds a job title to the list box
                lstJobNumber.Items.Add(jobValue[1]);
            }
            jobReader.Close(); // Close the csv file

            StreamReader vehReader = File.OpenText("CarInsuranceCategories.csv");
            while (!vehReader.EndOfStream)
            {
                String vehLine = vehReader.ReadLine();
                String[] vehValue = vehLine.Split(',');
                vehicles.Add(vehValue[0]);
                vehPremium.Add(vehValue[1]);
                lstVehicle.Items.Add(vehValue[0]);
                lstVehNumber.Items.Add(vehValue[1]);
            }
            vehReader.Close();
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (numDrivers >= maxDrivers - 1)
            {
                MessageBox.Show("You cannont add more than 5 drivers to a policy. Please save your Policy.");
                btnAddDriver.Enabled = false;
            }
            var today = DateTime.Today;// Save Today's Date
            age = today.Year - dtpDob.Value.Year;// Calculate the age
            if (dtpDob.Value > today.AddYears(-age)) age--;// Go back to the year the person was born in case of a leap year
            if (age < 21)
            {
                MessageBox.Show("Policy Declined due to age of youngest driver.");
                status = "Held";
            }
            else if (age > 75)
            {
                MessageBox.Show("Policy Declined due to age of Oldest driver.");
                status = "Held";
            }
            else
            {
                numDrivers++;
                MessageBox.Show(numDrivers + " Driver(s) added out of a maximum of: " + maxDrivers);
                drivers.Add(new Driver(txtName.Text, age)); //Add Driver data to list
            }
            txtName.Clear(); //Clear textbox
        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            btnYes.Enabled = true;
            btnAddPolicy.Enabled = false;
            btnFinished.Enabled = false;

            numDrivers = 0;

            var hToday = DateTime.Today;
            int hAge = hToday.Year - dtpHolderDob.Value.Year;
            if (dtpHolderDob.Value > hToday.AddYears(-hAge)) hAge--;

            if (dtpStartDate.Value <= DateTime.Today)//If start date is before today's date
            {
                MessageBox.Show("New policies must not start before today's date.");
            }

            if (hAge < 21)//If holder age is less than 21
            {
                MessageBox.Show("Policy Declined due to age of youngest driver.");
                status = "Held";
                policies.Add(new Policy(dtpStartDate.Value.ToString("dd-MM-yy"), txtHolderName.Text, hAge.ToString(), lstVehicle.Text, int.Parse(txtHolderClaim.Text), cmbKept.Text, lstHolderOccupation.Text, cmbUsage.Text, vehCost, keptCost, jobCost, ageCost, usageCost, claimsCost, totalPrem, status));
            }
            else if (hAge > 75)//If holder age is more than 75
            {
                MessageBox.Show("Policy Declined due to age of Oldest driver.");
                status = "Held";
                policies.Add(new Policy(dtpStartDate.Value.ToString("dd-MM-yy"), txtHolderName.Text, hAge.ToString(), lstVehicle.Text, int.Parse(txtHolderClaim.Text), cmbKept.Text, lstHolderOccupation.Text, cmbUsage.Text, vehCost, keptCost, jobCost, ageCost, usageCost, claimsCost, totalPrem, status));
            }

            if (int.Parse(txtHolderClaim.Text) > 6)//If number of years without claim is more than 6
            {
                MessageBox.Show("Maximum of 6 years without claim allowed.");
                noClaims = 6;//Set noClaims value equal to 6
            }
            else if (int.Parse(txtHolderClaim.Text) <= 6 && dtpStartDate.Value >= DateTime.Today)//If years without a claim is less than or equal to 6 and the start date for the policy isn't before today's date
            {
                noClaims = int.Parse(txtHolderClaim.Text);//Set noClaims equal to value user enters into Holder Claim textbox
                double agePrice20 = 20.0;
                double agePrice10 = 10.0;

                vehPrice = int.Parse(lstVehNumber.Text);
                vehCost = vehPrice / 100.0 * totalPrem;
                totalPrem = totalPrem + vehCost;

                if (cmbKept.Text == "Public Road") //Use combobox value to find value needed
                {
                    keptValue = 10;
                    keptCost = keptValue / 100.0 * totalPrem;
                    totalPrem = totalPrem + keptCost;
                }
                else if (cmbKept.Text == "Private Drive")
                {
                    keptValue = 5;
                    keptCost = keptValue / 100.0 * totalPrem;
                    totalPrem = totalPrem + keptCost;
                }

                jobPrice = int.Parse(lstJobNumber.Text);
                jobCost = jobPrice / 100.0 * totalPrem;
                totalPrem = totalPrem + jobCost;

                if (cmbUsage.Text == "Social and Commuting")
                {
                    usageValue = 5;
                    usageCost = usageValue / 100.0 * totalPrem;
                    totalPrem = totalPrem + usageCost;
                }
                else if (cmbUsage.Text == "Business")
                {
                    usageValue = 10;
                    usageCost = usageValue / 100.0 * totalPrem;
                    totalPrem = totalPrem + usageCost;
                }

                if (hAge >= 21 && hAge <= 25 || age >= 21 && age <= 25) //If holder age and driver age is between 21 and 25
                {
                    ageCost = agePrice20 / 100.0 * totalPrem;
                    totalPrem = totalPrem + ageCost;

                }
                else if (hAge > 25 && hAge <= 75 || age > 25 && age <= 75)//If holder age and driver age is between 25 and 75
                {
                    ageCost = agePrice10 / 100.0 * totalPrem;
                    totalPrem = totalPrem - ageCost;
                }
                claimsCost = noClaims / 100.0 * totalPrem;
                totalPrem = totalPrem - claimsCost; //Calculate total prem

                vehCost = Math.Round(vehCost, 2); //Round value to decimal places
                jobCost = Math.Round(jobCost, 2);
                keptCost = Math.Round(keptCost, 2);
                usageCost = Math.Round(usageCost, 2);
                ageCost = Math.Round(ageCost, 2);
                claimsCost = Math.Round(claimsCost, 2);
                totalPrem = Math.Round(totalPrem, 2);

                policies.Add(new Policy(dtpStartDate.Value.ToString("dd-MM-yy"), txtHolderName.Text, hAge.ToString(), lstVehicle.Text, int.Parse(txtHolderClaim.Text), cmbKept.Text, lstHolderOccupation.Text, cmbUsage.Text, vehCost, keptCost, jobCost, usageCost, ageCost, claimsCost, totalPrem, status));
                policies[policies.Count - 1].DriverList = drivers; //Add policy details to policy list and add drivers to the policy also

                MessageBox.Show("Please go to File and then save your policy to our system.");
            }
            else
            {
                MessageBox.Show("You must fill out all the required fields to continue!");
            }
            txtHolderName.Clear();
            txtHolderClaim.Clear();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            btnAddDriver.Enabled = true; // Enabled Add Driver button
            btnFinished.Enabled = true;
        }

        private void lstHolderOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstJobNumber.SelectedIndex = lstHolderOccupation.SelectedIndex; //Select value at same position as list next to it
        }

        private void lstVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstVehNumber.SelectedIndex = lstVehicle.SelectedIndex;
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            frmQuote f1 = new frmQuote(policies, drivers); //Open frmQuote form
            f1.ShowDialog();
        }

        private void savePolicyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fbdInput.ShowDialog() == DialogResult.OK)
            {

                string name = fbdInput.SelectedPath + "\\" + "Insurance_Policies" + dtpStartDate.Value.ToString("dd-MM-yy") + ".csv"; //Create file path called Insurance_Policies then add the chosen date

            StringBuilder sb = new StringBuilder();
            foreach (Policy policy in policies)
                {
                    sb.AppendLine(policy.StartDate + "," + policy.HolName + "," + policy.HolDob + "," + policy.Vehicle + "," + policy.HolClaim + "," + policy.Kept + "," + policy.HolOccupation + "," + policy.Usage + "," + policy.VehPremium + "," +policy.KeptPremium + "," + policy.OccupationPremium + "," + policy.UsagePremium + "," + policy.AgeCost + "," + policy.ClaimsCost + "," + policy.TotalPremium + "," + policy.Status);//Add values to csv file
                    foreach (Driver driver in policy.DriverList)
                    {
                        sb.AppendLine("," + driver.DriverName + "," + driver.DriverAge);
                     
                    }
                }
                File.AppendAllText(name, sb.ToString());
                MessageBox.Show("Policy saved.");

                policies.Clear(); //Clear List
                drivers.Clear();
            }
        }
    }
}
