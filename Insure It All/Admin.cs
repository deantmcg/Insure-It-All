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
    public partial class frmAdmin : Form
    {
        string[] driverStr = new string[5]; // strings for each driver stored here 
        string overview, holderStr;
        int currentDriver; // stores driver number currently being read from .csv - used in loop and incremented
        int claims; // used to store number of claims

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public frmAdmin()
        {
            InitializeComponent();
            lblMain.Hide();
            grpButtons.Hide();
            btnClear.Hide(); // hides group box and output label until user enters an ID
            lblHeader.Text = "";
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = File.OpenText(txtID.Text.ToUpper() + ".csv"); // opens .csv file with the name typed into the entry field
                string ID = txtID.Text;
                ClearValues(); // clears previous policy values from labels 
                lblMain.Show();
                grpButtons.Show();
                btnClear.Show();
                // makes display fields visible 
                lblHeader.Text = "Details for the policy '" + ID.ToUpper() + "' are shown below";

                string lineHolder = reader.ReadLine();
                string[] holder = lineHolder.Split(',');
                // reads in policy holder details from first line in .csv

                holderStr = holderStr + "Name: " + holder[1] + " " + holder[2] + "\nDate of Birth: " + (Convert.ToDateTime(holder[3])).ToString("dd-MM-yyyy");
                // holderStr string will be displayed in form as Policy Holder details

                overview = overview + "Policy ID: " + holder[0];
                if (int.Parse(holder[4]) == 0)
                {
                    overview = overview + "\nPOLICY REJECTED";
                }

                else
                {
                    overview = overview + "\nPolicy Cost: " + double.Parse(holder[4]).ToString("C", new CultureInfo("en-GB"));
                }

                overview = overview + "\nNumber of Drivers: " + holder[5] + "\n\nDriver Overview";
                // overview string will be displayed in form as a Policy summary

                int drivers = int.Parse(holder[5]);
                ShowButtons(); // displays all buttons
                HideButtons(drivers); // hides unneeded driver radio buttons depending on number of drivers

                while (!reader.EndOfStream)
                { // reads in remaining lines of .csv file
                    for (int d = 0; d < drivers; d++)
                    { // until equals number of drivers on policy
                        currentDriver = currentDriver + 1;
                        string lineDriver = reader.ReadLine();
                        string[] driver = lineDriver.Split(',');
                        // stores and splits line read in from .csv
                        
                        driverStr[d] = "Name: " + driver[0] + "\nDate of Birth: " + (Convert.ToDateTime(driver[1])).ToString("dd-MM-yy") + "\nOccupation: " + driver[2] + "\n\nClaim Details";
                        // stores all driver information in driverStr array
                        if (driver[3] == "") // if claim 1 empty - no claims
                        {
                            driverStr[d] = driverStr[d] + "\nNo Claims";
                            claims = 0;
                        } 

                        else if (driver[3] != "" && driver[4] == "") // if only claim 2 empty - 1 claim
                        {
                            driverStr[d] = driverStr[d] + "\nDate of Claim 1: " + (Convert.ToDateTime(driver[3])).ToString("dd-MM-yy");
                            claims = 1;
                        }

                        else // 2 claims
                        {
                            driverStr[d] = driverStr[d] + "\nDate of Claim 1: " + (Convert.ToDateTime(driver[3])).ToString("dd-MM-yy") + "\nDate of Claim 2: " + (Convert.ToDateTime(driver[4])).ToString("dd-MM-yy");
                            claims = 2;
                        } // Displays claim information depending on number of claims

                        overview = overview + "\n" + driver[0] + " | " + claims + " Claim(s) | DOB: " + (Convert.ToDateTime(driver[1])).ToString("dd-MM-yy");
                        btnOverview.Checked = true; lblMain.Text = overview;
                    }
                }
            }

            catch (Exception FileNotFoundException) // if file "ID".csv not found
            {
                string ID = txtID.Text;
                ClearValues();
                lblHeader.Text = "No policies found matching '" + ID.ToUpper() + "'. Enter another ID";
                txtID.Focus(); // instructs user to try again
                btnClear.Hide(); lblMain.Hide(); grpButtons.Hide();
            }

        }

        public void ClearValues()
        {
            currentDriver = 0;
            lblMain.Text = "";
            holderStr = "";
            overview = "";
            lblHeader.Text = "";
            txtID.Text = "";
        }

        public void ShowButtons()
        {
            btnDriver2.Show(); btnDriver3.Show(); btnDriver4.Show(); btnDriver5.Show();
        }

        public void HideButtons (int drivers)
        {
            if (drivers == 1)
            {
                btnDriver2.Hide(); btnDriver3.Hide(); btnDriver4.Hide(); btnDriver5.Hide();
            }

            else if (drivers == 2)
            {
                btnDriver3.Hide(); btnDriver4.Hide(); btnDriver5.Hide();
            }

            else if (drivers == 3)
            {
                btnDriver4.Hide(); btnDriver5.Hide();
            }

            else if (drivers == 4)
            {
                btnDriver5.Hide();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearValues();
            txtID.Text = "";
            grpButtons.Hide();
            lblMain.Hide();
        }

        // The following displays relevant information in lblMain once a radio button is clicked

        private void btnOverview_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = overview;
        }

        private void btnHolder_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = holderStr;
        }

        private void btnDriver1_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = driverStr[0];
        }

        private void btnDriver2_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = driverStr[1];
        }

        private void btnDriver3_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = driverStr[2];
        }

        private void btnDriver4_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = driverStr[3];
        }

        private void btnDriver5_CheckedChanged(object sender, EventArgs e)
        {
            lblMain.Text = driverStr[4];
        }
    }
}
