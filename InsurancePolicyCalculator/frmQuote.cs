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
    public partial class frmQuote : Form
    {
        List<Policy> policies = new List<Policy>();
        List<Driver> drivers = new List<Driver>();

        public frmQuote(List<Policy> policies, List<Driver> drivers)
        {
            this.policies = policies;
            this.drivers = drivers;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtDisPolicy.Clear();

            //Get date and convert it to correct string format
            string date = dtpPolicyDate.Value.ToString("dd-MM-yy");
            string line, line2;

            if (dtpPolicyDate.Value <= DateTime.Today)//If user chooses date before today's date
            {
                MessageBox.Show("Only Admins can view policies made before today's date. Please choose another date.");//Ensures non admin users can't view policies made before today's date by checking if chosen date is before todays date
            }

            try
            {
                StreamReader reader = File.OpenText("Insurance_Policies" + date + ".csv");//Opens a csv file with the date selected by the user

                txtDisPolicy.AppendText("Start Date\r Drivers\tAge\tVehicle\t\tYears without Claim\tVehicle Kept\tHolder Occupation\tVehicle Usage\tVehicle Prem\r Kept Prem\r Occu Prem\r Usage Prem\r Age Prem\r Claims Prem\r Total Premium\tStatus" + "\r\n");//Display these headings in the textbox related to the data in the csv file that I have created

                while (!reader.EndOfStream)//Load data from csv into an array and remove the commas
                {
                    line = reader.ReadLine();//Read line of data from the csv file
                    line2 = "";//Initialise an empty string which will hold the line of data to be output on the form

                    string[] values = line.Split(',');//Array holds each item from the current row in csv file

                    foreach (string s in values)
                    {
                        line2 = line2 + s + "\t";//Use the array data to create one string with spacing between each value
                    }
                    txtDisPolicy.AppendText(line2 + "\r\n");//Display therow from csv file in a new line in the textbox
                }
                reader.Close();              
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Policies were created on this day\nChoose a different date");//Display this message if a date with no created policies is chosen
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmInput fInputF = new frmInput();//Open frmInput form
            fInputF.ShowDialog();
        }
    }
}
