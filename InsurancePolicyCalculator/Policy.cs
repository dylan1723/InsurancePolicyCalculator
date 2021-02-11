using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePolicyCalculator
{
    public class Policy
    {
        string startDate;
        string holName;
        string holDob;
        string vehicle;
        int holClaim;
        string kept;
        string holOccupation;
        string usage;
        double vehPremium;
        double keptPremium;
        double occupationPremium;
        double usagePremium;
        double ageCost;
        double claimsCost;
        double totalPremium;
        string status;
        List<Driver> driverList;

        public Policy(string startDate, string holName, string holDob, string vehicle, int holClaim, string kept, string holOccupation, string usage, double vehPremium, double keptPremium, double occupationPremium, double usagePremium, double ageCost, double claimsCost, double totalPremium, string status)
        {
            this.startDate = startDate;
            this.holName = holName;
            this.holDob = holDob;
            this.vehicle = vehicle;
            this.holClaim = holClaim;
            this.kept = kept;
            this.holOccupation = holOccupation;
            this.usage = usage;
            this.vehPremium = vehPremium;
            this.keptPremium = keptPremium;
            this.occupationPremium = occupationPremium;
            this.usagePremium = usagePremium;
            this.ageCost = ageCost;
            this.claimsCost = claimsCost;
            this.totalPremium = totalPremium;
            this.status = status;
        }

        public Policy()
        {
            this.startDate = "";
            this.holName = "";
            this.holDob = "";
            this.vehicle = "";
            this.holClaim = 0;
            this.kept = "";
            this.holOccupation = "";
            this.usage = "";
            this.vehPremium = 0;
            this.keptPremium = 0;
            this.occupationPremium = 0;
            this.usagePremium = 0;
            this.ageCost = 0;
            this.claimsCost = 0;
            this.totalPremium = 0;
            this.status = "";
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string HolName
        {
            get { return holName; }
            set { holName = value; }
        }
        public string HolDob
        {
            get { return holDob; }
            set { holDob = value; }
        }
        public string Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }
        public int HolClaim
        {
            get { return holClaim; }
            set { holClaim = value; }
        }
        public string Kept
        {
            get { return kept; }
            set { kept = value; }
        }
        public string HolOccupation
        {
            get { return holOccupation; }
            set { holOccupation = value; }
        }
        public string Usage
        {
            get { return usage; }
            set { usage = value; }
        }
        public double VehPremium
        {
            get { return vehPremium; }
            set { vehPremium = value; }
        }
        public double KeptPremium
        {
            get { return keptPremium; }
            set { keptPremium = value; }
        }
        public double OccupationPremium
        {
            get { return occupationPremium; }
            set { occupationPremium = value; }
        }
        public double UsagePremium
        {
            get { return usagePremium; }
            set { usagePremium = value; }
        }
        public double AgeCost
        {
            get { return ageCost; }
            set { ageCost = value; }
        }
        public double ClaimsCost
        {
            get { return claimsCost; }
            set { claimsCost = value; }
        }
        public double TotalPremium
        {
            get { return totalPremium; }
            set { totalPremium = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public List <Driver> DriverList
        {
            get { return driverList; }
            set { driverList = value; }
        }
    }
}