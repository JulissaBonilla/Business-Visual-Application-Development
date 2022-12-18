/*
 * Project:         Assignment 7 Program 16
 * Date:            December 2022
 * Developed By:    JulissaB
 * Purpose:         This is the main form of program 16 this form takes user input
 *                  to make and add charter objects into the charter list.
 *                  Selections made by the user create a collection of charter objects
 *                  the information can be used to project informaiton through other 
 *                  forms.
 * Last Modified:   12/10/22
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

namespace JBonillaProgram16
{
    public partial class Program16 : Form
    {
        public Program16()
        {
            InitializeComponent();
        }

        private CharterManager aCharterManager;

        private void allCharters_Click(object sender, EventArgs e)
        {
            //Creates and displays a form to show the collection of all the charters(see class AllChartersForm)
            AllChartersForm aForm = new AllChartersForm();

            aForm.charterManagerBindingSource.DataSource = aCharterManager;

            aForm.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local variables
            string customerName;
            string yachtType;
            int yachtSize;
            decimal charterHours;

            //Checks if a name was inputed and displays error message if not
            if(txtCustomerName.Text==string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomerName.Focus();
                return;
            }

            //check that a yacht type is selected and displays error message if not
            if (cbYachtType.SelectedIndex == -1)
            {
                MessageBox.Show("Yacht Type is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbYachtType.Focus();
                return;
            }
            //check that a size was selected and displays error message if not
            if (cbYachtSize.SelectedIndex == -1)
            {
                MessageBox.Show("Yacht Size is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbYachtSize.Focus();
                return;
            }
            // assign input data to variables

            customerName = txtCustomerName.Text;
            yachtType = cbYachtType.Text;
            yachtSize = Convert.ToInt32(cbYachtSize.Text);
            charterHours = nudHours.Value;

            //instantiate aCharterManager if not already instantiated

            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }

            //instantiate charter object and add to the charter list collection
            aCharterManager.AddCharter(customerName, yachtType, yachtSize, charterHours);

            //display confirmation
            MessageBox.Show("Charter added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //disable Create button
            btnCreate.Enabled = true;

            //enable the display menu items
            allCharters.Enabled = true;
            numberOfChartersForYachtSize.Enabled = true;
            charterSummary.Enabled = true;



        }

        private void numberOfChartersForYachtType_Click(object sender, EventArgs e)
        {
            //check that a size is selected and output error if not
            if(cbYachtSize.SelectedIndex == -1)
            {
                MessageBox.Show("Select Yacht Size", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int aSize = Convert.ToInt32(cbYachtSize.Text);
            int result = aCharterManager.GetCharterCount(aSize);
            //display in message box the result of how many of that size are in the collection
            string message = $"There is/are {result} charter(s) of yachts of size {aSize}.";
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void charterSummary_Click(object sender, EventArgs e)
        {
            //Generates and displays a form for the summary information (see class CharterSummaryForm)
            CharterSummaryForm aForm = new CharterSummaryForm();

            aForm.lblAverageCha.Text = aCharterManager.GetAverageCharterFee().ToString("c");
            aForm.lblLowestCha.Text = aCharterManager.FindLowestCharterFee().ToString("c");
            aForm.lblTotalCha.Text = aCharterManager.GetTotalCharterFee().ToString("c");

            aForm.ShowDialog();
        }

        private void addYachtType_Click(object sender, EventArgs e)
        {
            //iterate through list of yacht types and check if inputed information is in the list,if it is then adding that type would create a duplicate
            //displays error message in case of duplicate
            foreach (string type in (cbYachtType.Items))
            {
                if ( type == cbYachtType.Text)
                {
                    MessageBox.Show("Yacht type not added.", "Duplicate Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbYachtType.Focus();
                    return;
                }
            }
            //duplicate not found so the type is clear to be added
            cbYachtType.Items.Add(cbYachtType.Text);
        }

        private void resetForNextCharter_Click(object sender, EventArgs e)
        {
            //reset inputs to default/starting positions
            txtCustomerName.Text = null;
            cbYachtSize.SelectedIndex = -1;
            cbYachtType.SelectedIndex = -1;
            nudHours.Value = nudHours.Minimum;
        }

        //remove a yacht type form the list
        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbYachtType.Items.Remove(cbYachtType.SelectedItem);
        }
        //adds yacht type to the list (calls the AddYachtType_Click)
        private void addYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addYachtType_Click(sender,e);
        }
        //remove a yacht type using removeYachtTypeToolStripMenuItem_Click
        private void removeYachtTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            removeYachtTypeToolStripMenuItem_Click(sender,e);
        }
    }
}
