using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsurancePolicyCalculator
{
    public partial class frmAdminLogin : Form
    {
        List<Policy> policies = new List<Policy>();
        List<Driver> drivers = new List<Driver>();

        int numAttempt = 0;
        int maxAttempt = 3;

        public frmAdminLogin()
        {
            InitializeComponent();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmInput frm2 = new frmInput();
            frm2.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text == "Admin") && (txtPass.Text == "Password1") && (numAttempt <= maxAttempt - 1))//User must enter the correct username and password and be below the maxAttempts to login
            {
                frmAdmin frm1 = new frmAdmin(policies, drivers);
                frm1.ShowDialog();
            }
            else
            {
                numAttempt++;//Increases value of numAttempt 
                MessageBox.Show("Incorrect username or password please try again. " + numAttempt + " Attempts used out of 3");

                if (numAttempt == maxAttempt)
                {
                    DialogResult diaExit = MessageBox.Show("All attempts used. The Application will now close.");
                    if (diaExit == DialogResult.OK)
                    {
                        Application.Exit();//Exit application if numAttempt reaches value of maxAttempt
                    }
                }
            }
        }
    }
}
