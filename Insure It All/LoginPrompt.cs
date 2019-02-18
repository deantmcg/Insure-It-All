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
    public partial class frmLoginPrompt : Form
    {
        string password = "adP@ssw0rd"; // password for logging into admin section
        public frmLoginPrompt()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                frmAdmin frmAdmin = new frmAdmin();
                frmMainMenu frmMainMenu = new frmMainMenu();
                frmAdmin.Show();
                this.Hide();
                frmMainMenu.Hide();
            } // opens admin form if entered password matches stored

            else
            {
                MessageBox.Show("Incorrect Password. Try again.");
                txtPassword.Text = "";
                txtPassword.Focus();
            } // shows error message - instructs user to try again
        }
    }
}
