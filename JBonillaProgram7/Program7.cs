/*
 * Project: Assignment Set 3- Program 7
 * Date:    October 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Program7
 * Description: This form class that is a presentation layer of the GUI for TruckRental
 * Uses: TruckRental class
 * Last modified: 10/5/2022
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

namespace JBonillaProgram7
{
    public partial class Program7 : Form
    {
        //declare object variable
        private TruckRental aRental;
        public Program7()
        {
            InitializeComponent();
        }

        private void btnTruckRental_Click(object sender, EventArgs e)
        {
            //if statment from example program
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            //declare local variables
            string customerName;
            int endOdometerReading, beginOdometerReading, daysRented;

            //assign inputs to variables 
            customerName = txtName.Text;
            endOdometerReading = Convert.ToInt32(nudEOR.Value);
            beginOdometerReading = Convert.ToInt32(nudBOR.Value);
            daysRented = Convert.ToInt32(nudNumDays.Value);

            //instantiate a TruckRental object
            aRental = new TruckRental(customerName, endOdometerReading, beginOdometerReading, daysRented);
            lblRentalCharge.Text = "$"+String.Format("{0:0.00}",aRental.RentalCharge);
        }

        //resets the input feilds and clears the result
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            nudBOR.Value = nudBOR.Minimum;
            nudEOR.Value = nudEOR.Minimum;
            nudNumDays.Value = nudNumDays.Minimum;

            lblRentalCharge.Text = null;

        }

        //exit button closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudBOR_ValueChanged(object sender, EventArgs e)
        {
            nudEOR.Minimum = nudBOR.Value+1;
        }
    }
}
