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

namespace Insure_It_All
{
    public partial class frmPolicyDetails : Form
    {
        Policy policy = new Policy();
        public static int drivers;
        int ID;

        public frmPolicyDetails()
        {
            InitializeComponent();
            dtpPolicyStart.MinDate = DateTime.Today;
            StreamReader reader = File.OpenText("ID.txt");
            ID = int.Parse(reader.ReadLine())+1;
            // reads ID in from .txt file and increments it by 1
            reader.Close();
        }


        private void picNext_Click(object sender, EventArgs e)
        {
            // ALL DATA ENTRY VALIDATION
            if (cboTitle.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields before progressing");
                cboTitle.Focus();
            }

            else if (txtHolderFirstn.Text == "")
            {
                MessageBox.Show("Please complete all fields before progressing");
                txtHolderFirstn.Focus();
            }

            else if (txtHolderSurname.Text == "")
            {
                MessageBox.Show("Please complete all fields before progressing");
                txtHolderSurname.Focus();
            }

            else if (!(txtHolderFirstn.Text.Any(char.IsLetter)) || !(txtHolderSurname.Text.Any(char.IsLetter))  || ((txtHolderFirstn.Text.Any(char.IsDigit) || (txtHolderSurname.Text.Any(char.IsDigit)))))
            {
                MessageBox.Show("Name must only contain letters.");
                if (!(txtHolderFirstn.Text.Any(char.IsLetter)) && !(txtHolderSurname.Text.Any(char.IsLetter)))
                {
                    txtHolderFirstn.Text = "";
                    txtHolderSurname.Text = "";
                    txtHolderFirstn.Focus();
                }

                else if (!(txtHolderSurname.Text.Any(char.IsLetter)))
                {
                    txtHolderSurname.Text = "";
                    txtHolderSurname.Focus();
                }

                else if (!(txtHolderFirstn.Text.Any(char.IsLetter)))
                {
                    txtHolderFirstn.Text = "";
                    txtHolderFirstn.Focus();
                }
            
                else if ((txtHolderFirstn.Text.Any(char.IsDigit) && (txtHolderSurname.Text.Any(char.IsDigit))))
                {
                    txtHolderFirstn.Text = "";
                    txtHolderSurname.Text = "";
                    txtHolderFirstn.Focus();
                }

                else if (txtHolderFirstn.Text.Any(char.IsDigit))
                {
                    txtHolderFirstn.Text = "";
                    txtHolderFirstn.Focus();
                }

                else if (txtHolderSurname.Text.Any(char.IsDigit))
                {
                    txtHolderSurname.Text = "";
                    txtHolderSurname.Focus();
                }
            }

            else if (txtHolderFirstn.Text.Length < 2)
            {
                MessageBox.Show("First name must be at least 2 characters");
                txtHolderFirstn.Focus();
            }

            else if (cboDrivers.SelectedItem == null)
            {
                MessageBox.Show("Please complete all fields before progressing");
            }
            // ENTRY VALIDATION OVER

            else
            {
                try
                {
                    drivers = (cboDrivers.SelectedIndex) + 1; // sets number of drivers from combo box

                    policy.PolicyID = txtHolderSurname.Text.Substring(0, 3).ToUpper();
                    // sourced and adapted from: https://stackoverflow.com/questions/15941985/how-to-get-the-first-five-character-of-a-string
                    // Username: TechDo
                    // gets the first 3 characters from surname

                    policy.PolicyID = policy.PolicyID + (ID.ToString("D6"));
                    // sourced from https://stackoverflow.com/questions/5418324/how-can-i-format-a-number-into-a-string-with-leading-zeros
                    // turns the ID into a 6 digit number by adding leading 0s. Adds ID to first 3 characters of surname

                    policy.HolderTitle = cboTitle.SelectedItem.ToString();
                    policy.HolderName = txtHolderFirstn.Text + " " + txtHolderSurname.Text;
                    policy.PolicyStart = dtpPolicyStart.Value;
                    // assigns holder information to policy object;

                    frmAddDrivers frmAddDrivers = new frmAddDrivers(policy);
                    frmAddDrivers.Show();
                    this.Hide();
                    File.WriteAllText("ID.txt", ID.ToString()); // writes incremented ID to txt file for next policy
                }

                catch (Exception ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Surname must be 3 characters in length");
                    txtHolderSurname.Text = "";
                    txtHolderSurname.Focus();
                }
            }
        }
    }
}
