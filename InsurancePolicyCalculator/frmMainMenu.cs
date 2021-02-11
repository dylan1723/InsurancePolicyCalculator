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
    public partial class frmMainMenu : Form
    {
        List<Policy> policies = new List<Policy>();
        List<Driver> drivers = new List<Driver>();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnInputForm_Click(object sender, EventArgs e)
        {
            frmInput frm1 = new frmInput();
            frm1.ShowDialog();
        }

        private void btnAdminForm_Click(object sender, EventArgs e)
        {
            frmAdminLogin frm2 = new frmAdminLogin();
            frm2.ShowDialog();
        }
    }
}
