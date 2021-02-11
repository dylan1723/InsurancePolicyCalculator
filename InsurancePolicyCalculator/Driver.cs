using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyCalculator
{
    public class Driver
    {
        string driverName;
        int driverAge;

        public Driver(string driverName, int driverAge)
        {
            this.driverName = driverName;
            this.driverAge = driverAge;
        }
        
        public Driver()
        {
            this.driverName = "";
            this.driverAge = 0;
        }
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }
        public int DriverAge
        {
            get { return driverAge; }
            set { driverAge = value; }
        }
    }
}
    
