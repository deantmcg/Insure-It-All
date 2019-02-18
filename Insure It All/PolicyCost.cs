using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Insure_It_All
{
    internal partial class frmPolicyCost : Form
    {
        Policy policy = new Policy();
        int oldest = 1; // stores age of oldest driver
        int youngest = 999; // stores age of youngest driver

        List<string> namesOldest = new List<string>();
        List<string> namesYoungest = new List<string>();
        // stores names of drivers causing decline of policy

        bool rejectedYoung, rejectedOld, rejectedClaims; // stores true or false value of what conditions the policy has been declined under
        int totalClaims;

        // stores occupations and rates read in from .csv file
        List<string> occupation = new List<string>();
        List<double> rate = new List<double>();

        public frmPolicyCost(Policy policy2)
        {
            InitializeComponent();
            policy = policy2; // // sets policy to policy2 sent from frmAddDrivers
            lblHeader.Text = "Policy ID: " + policy.PolicyID + "\nPolicy Holder: " + policy.HolderTitle + " " + (policy.HolderName).ToUpper();
            policy.Premium = 500; // policy default start value
            OccupationScanner(); // scans input occupations for certain occupations and applies rates
            AgeScanner();
            ClaimScanner();
            WriteTo();
            // scans input ages and claims to determine if policy can go ahead
        }

        public void OccupationScanner()
        {
            //use of csv file allows new occupation comparisons to be added and existing rates can be easily ammended
            StreamReader reader = File.OpenText("Occupation Rates.csv");

            while (!reader.EndOfStream) // until end of file is reached
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');
                // reads in occupation and rate details from .csv

                occupation.Add(values[0]);
                rate.Add(double.Parse(values[1]));
                // stores occupation and corresponding rate in lists
            }

            foreach (Driver driver in policy.Drivers)
            {
                for (int x = 0; x < occupation.Count; x++)
                {
                    if (driver.Occupation.ToUpper() == occupation[x])
                    {
                        policy.Premium = (policy.Premium) * rate[x];
                    }
                } // determines whether any occupations on the policy are in the occupation list
            }
        }

        public void AgeScanner()
        { // Code sourced and adapted from: http://www.c-sharpcorner.com/uploadfile/scottlysle/assessing-dates-of-birth-using-C-Sharp/
            int age;

            foreach (Driver driver in policy.Drivers)
            {
                age = DateTime.Now.Year - driver.DOB.Year;
                if (DateTime.Now.Month < driver.DOB.Month || DateTime.Now.Month == driver.DOB.Month && DateTime.Now.Day < driver.DOB.Day)
                {
                    age = age - 1;
                } // gets drivers age from their input DOB

                if (age < youngest) // if user is younger than current stored youngest driver
                {
                    youngest = age;
                }
                
                else if (age > oldest) // if user is older than current stored oldest driver
                {
                    oldest = age;
                } 

                if (age < 21) // gets and stores users being rejected for being under 21
                {
                    namesYoungest.Add(driver.Name.ToUpper());
                    rejectedYoung = true;
                }

                else if (age > 75) // gets and stores users being rejected for being over 75
                {
                    namesOldest.Add(driver.Name.ToUpper());
                    rejectedOld = true;
                }
            }

            if (youngest >= 21 && youngest <= 25)
            {
                policy.Premium = policy.Premium * 1.2;
            } // increases policy by 20% if youngest between 21 & 22

            else if (youngest >= 26 && youngest <= 75)
            {
                policy.Premium = policy.Premium * 0.9;
            } // decreases policy by 10% if youngest between 26 and 75

            if (rejectedYoung == true && rejectedOld == true) // if there are drivers under 21 AND over 75
            {
                policy.Premium = 0;
                lblPremium.Hide();
                lblHeading.Text = "Your policy request has been declined due to following driver(s) being under 21 years old";
                foreach (string name in namesYoungest)
                {
                    lblHeading.Text = lblHeading.Text + "\n" + name.ToUpper(); ;
                }
                lblHeading.Text = lblHeading.Text + "\nand the following driver(s) being over 75 years old";
                foreach (string name in namesOldest)
                {
                    lblHeading.Text = lblHeading.Text + "\n" + name.ToUpper();
                } // Names read in from lists & message displayed
            } 

            else if (rejectedYoung == true) // if there are drivers under 21
            {
                policy.Premium = 0;
                lblPremium.Hide();
                lblHeading.Text = "Your policy request has been declined due to the following driver(s) being under 21 years old";
                foreach (string name in namesYoungest)
                {
                    lblHeading.Text = lblHeading.Text + "\n" + name;
                } // Name(s) read in from list & message displayed
            }

            else if (rejectedOld == true) // if there are drivers over 75
            {
                policy.Premium = 0;
                lblPremium.Hide();
                lblHeading.Text = "Your policy request has been declined due to the following driver(s) being over 75 years old";
                foreach (string name in namesOldest)
                {
                    lblHeading.Text = lblHeading.Text + "\n" + name;
                } // Name(s) read in from list & message displayed
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            this.Close();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            frmPolicyDetails frmPolicyDetails = new frmPolicyDetails();
            frmPolicyDetails.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string getClaims(Driver driver)
        {
            string delimiter = ",";
            string claimString = "";

           foreach (Claim claim in driver.Claims)
            {
                claimString = claimString + claim.ClaimDate.ToString() + delimiter;
            }

            return claimString;
        }

        public void ClaimScanner()
        {
            foreach (Driver driver in policy.Drivers)
            {
                totalClaims = totalClaims + driver.Claims.Count();
                int difference;
                
                foreach (Claim claim in driver.Claims)
                {
                    difference = policy.PolicyStart.Year - claim.ClaimDate.Year;
                    if (policy.PolicyStart.Month < claim.ClaimDate.Month || policy.PolicyStart.Month == claim.ClaimDate.Month && policy.PolicyStart.Day < claim.ClaimDate.Day)
                    {
                        difference = difference - 1;
                    } // gets the "age of a claim"
                    
                    if (difference < 1)
                    {
                        policy.Premium = policy.Premium * 1.2;
                    }

                    else if (difference >= 1 && difference < 5)
                    {
                        policy.Premium = policy.Premium * 1.1;
                    }
                    // increases policy price depending on age of claim
                }
            }

            if (totalClaims > 3)
            {
                rejectedClaims = true;
                policy.Premium = 0;
                lblPremium.Hide();
                lblHeading.Text = "Policy has more than 3 claims and has therefore been declined";
            } // if more than 3 claims - decline policy
        }

        public void WriteTo()
        {
            lblPremium.Text = policy.Premium.ToString("C", new CultureInfo("en-GB")); // displays policy cost

            string filePath = policy.PolicyID + ".csv"; // generates .csv file name from the policy ID
            string delimiter = ",";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(policy.PolicyID + delimiter + policy.HolderTitle + delimiter + policy.HolderName + delimiter + policy.PolicyStart + delimiter + policy.Premium + delimiter + policy.Drivers.Count + delimiter);
            // writes general policy and holder information in new .csv

            foreach (Driver driver in policy.Drivers)
            {
                sb.AppendLine(driver.Name + delimiter + driver.DOB + delimiter + driver.Occupation + delimiter + getClaims(driver));
            } // writes all driver information in new .csv

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
