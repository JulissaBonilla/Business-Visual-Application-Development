/*
 * Project:         Assignment 4 Program 9
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         Form to collect input from user
 * Last Modified:   10/21/22
 * Uses:            Conference Class
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBonillaProgram9
{    
    public partial class Program9 : Form
    {
        Conference aConference;
        string confName;
        int numAttendees, numNights;
        AccommodationType accommodation;
        bool internet, recCenter;
        public Program9()
        {
            InitializeComponent();
        }

        private void btnCreateConference_Click(object sender, EventArgs e)
        {
            //verify that a name was inputed
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("A name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            AssignInputs();

            lblConferenceSummary.Text = aConference.ToString();

            //Disable and enable
            txtName.Enabled = false;
            btnCreateConference.Enabled = false;

            btnModify.Enabled = true;

            txtName.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            nudAttendees.Value = nudAttendees.Minimum;
            nudNights.Value = nudNights.Minimum;
            radSingle.Checked = true;
            cbInternet.Checked = false;
            cbRecCenter.Checked = false;
            lblConferenceSummary.Text = string.Empty;
            btnCreateConference.Enabled = true;
            txtName.Enabled = true;
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // assign the return value to the variable

            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                txtName.Focus();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            AssignInputs();
            lblConferenceSummary.Text = aConference.ToString();
        }
        
        //assigned the input variables to the respected varibles used in the class
        private void AssignInputs()
        {
           
            //get inputs
            confName = txtName.Text;
            numAttendees = Convert.ToInt32(nudAttendees.Value);
            numNights = Convert.ToInt32(nudNights.Value);
            if (radSingle.Checked)
            {
                accommodation = AccommodationType.Single;
            }
            else if (radDouble.Checked)
            {
                accommodation = AccommodationType.Double;
            }
            else
            {
                accommodation = AccommodationType.Suite;

            }
            //If the item is checked then item will be set to true and vise versa
            internet = cbInternet.Checked;
            recCenter = cbRecCenter.Checked;

            //Instantiate Object

            aConference = new Conference(confName, numAttendees, numNights, accommodation, internet, recCenter);

        }
    }
}
