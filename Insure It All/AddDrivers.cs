using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insure_It_All
{
    internal partial class frmAddDrivers : Form //https://stackoverflow.com/questions/6229504/inconsistent-accessibility-parameter-type-is-less-accessible-than-method
    {
        int drivers = frmPolicyDetails.drivers;
        int count = 0;
        int claims;
        Policy policy = new Policy();

        public frmAddDrivers(Policy policy2)
        {
            InitializeComponent();
            policy = policy2; // sets policy to policy2 sent from frmPolicyDetails
            lstPolicyDetails.Items.Add("Policy ID: " + policy.PolicyID);
            lstPolicyDetails.Items.Add("Policy Holder: " + policy.HolderTitle + " " + policy.HolderName.ToUpper());
            var dateMinus16 = DateTime.Now.AddYears(-16);
            dtpDrverDOB.MaxDate = dateMinus16; // prevents user selecting an age younger than 16 years old
        }

        public void ClearFields() // used to clear the entry fields when a driver is added
        {
            txtDriverFirstn.Text = ""; txtDriverSurn.Text = ""; txtOcc.Text = "";
            dtpDrverDOB.Value = dtpDrverDOB.MaxDate;
            numClaims.Value = 0; dtpClaim1.Value = DateTime.Today; dtpClaim2.Value = DateTime.Today;
            numClaims.Value = 0;
            lblClaim1.Hide(); lblClaim2.Hide(); dtpClaim1.Hide(); dtpClaim2.Hide();
        }

        private void btnNextDriver_Click(object sender, EventArgs e)
        {
            if (txtDriverFirstn.Text.Length < 2)
            {
                MessageBox.Show("Firstname must be 2 characters");
                txtDriverFirstn.Text = "";
                txtDriverFirstn.Focus();
            } // ensures name entered is over 2 characters long

            else if (txtDriverSurn.Text.Length < 3)
            {
                MessageBox.Show("Surname must be at least 3 characters");
                txtDriverSurn.Text = "";
                txtDriverSurn.Focus();
            } // ensures surname is over 2 characters long

            else if ((!(txtDriverFirstn.Text.Any(char.IsLetter)) || !(txtDriverSurn.Text.Any(char.IsLetter))) || ((txtDriverFirstn.Text.Any(char.IsDigit) || (txtDriverSurn.Text.Any(char.IsDigit))))) // ensures names contain only letters
            {
                MessageBox.Show("Name must only contain letters.");
                if (!(txtDriverFirstn.Text.Any(char.IsLetter)) && !(txtDriverSurn.Text.Any(char.IsLetter)))
                {
                    txtDriverFirstn.Text = "";
                    txtDriverSurn.Text = "";
                    txtDriverFirstn.Focus();
                }

                else if (!(txtDriverFirstn.Text.Any(char.IsLetter)))
                {
                    txtDriverFirstn.Text = "";
                    txtDriverFirstn.Focus();
                }

                else if (!(txtDriverSurn.Text.Any(char.IsLetter)))
                {
                    txtDriverSurn.Text = "";
                    txtDriverSurn.Focus();
                } // these statements allows focus to be set on the exact fields with an error showing

                else if ((txtDriverFirstn.Text.Any(char.IsDigit) && (txtDriverSurn.Text.Any(char.IsDigit))))
                {
                    txtDriverFirstn.Text = "";
                    txtDriverSurn.Text = "";
                    txtDriverFirstn.Focus();
                }

                else if (txtDriverFirstn.Text.Any(char.IsDigit))
                {
                    txtDriverFirstn.Text = "";
                    txtDriverFirstn.Focus();
                }

                else if (txtDriverSurn.Text.Any(char.IsDigit))
                {
                    txtDriverSurn.Text = "";
                    txtDriverSurn.Focus();
                }
            }

            else if ((!(txtOcc.Text.Any(char.IsLetter))) || ((txtOcc.Text.Any(char.IsDigit))))
            {
                MessageBox.Show("Occupation must contain only letters.");
                txtOcc.Text = "";
                txtOcc.Focus();
            } // ensures occupation contains only letters

            else
            {
                policy.Drivers.Add(new Driver()); // creates new driver object

                if (claims == 1)
                {
                    Claim claim1 = new Claim();
                    claim1.ClaimDate = dtpClaim1.Value;
                    policy.Drivers[count].Claims.Add(claim1);
                } // if user selects 1 claim - add 1 claim object to Claims list in Driver and assign value

                else if (claims == 2)
                {
                    Claim claim1 = new Claim();
                    Claim claim2 = new Claim();
                    claim1.ClaimDate = dtpClaim1.Value;
                    claim2.ClaimDate = dtpClaim2.Value;
                    policy.Drivers[count].Claims.Add(claim1);
                    policy.Drivers[count].Claims.Add(claim2);
                } // if user selects 2 claims - add 2 claim objects to Claims list in Driver and assign value

                policy.Drivers[count].Name = txtDriverFirstn.Text + " " + txtDriverSurn.Text;
                policy.Drivers[count].Occupation = txtOcc.Text;
                policy.Drivers[count].DOB = dtpDrverDOB.Value;
                // assigns text from the input fields into corresponding Driver variables

                lstPolicyDetails.Items.Add("Driver " + (count + 1) + ": " + policy.Drivers[count].Name); // displays policy and driver information as it is entered

                ClearFields();
                count = count + 1;

                if (count == drivers)
                {
                    frmPolicyCost frmPolicyCost = new frmPolicyCost(policy);
                    frmPolicyCost.Show();
                    this.Hide();
                }
            }
        }

        private void numClaims_ValueChanged(object sender, EventArgs e)
        {
            if (numClaims.Value == 1)
            {
                claims = 1;
                lblClaim1.Show(); dtpClaim1.Show();
                lblClaim2.Hide(); dtpClaim2.Hide();
            }

            else if (numClaims.Value == 2)
            {
                claims = 2;
                lblClaim1.Show(); dtpClaim1.Show();
                lblClaim2.Show(); dtpClaim2.Show();
            }

            else
            {
                claims = 0;
                lblClaim1.Hide(); dtpClaim1.Hide();
                lblClaim2.Hide(); dtpClaim2.Hide();
            }
        } // updates the date time pickers visible for entering claims depending on the number selected in NumericUpDown tool
    }
}
