/*
 * Project: Assignment Set 3- Program 8
 * Date:    October 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Program8
 * Description: This form class that is a presentation layer of the GUI for PaySlip
 * Uses: PaySlip class
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

namespace JBonillaProgram8
{
    public partial class Program8 : Form
    {
        //declare object variable
        private PaySlip aPaySlip;
        public Program8()
        {
            InitializeComponent();
        }

        private void btnPaySlip_Click(object sender, EventArgs e)
        {
            //if statment from example program
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Employee name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            //declare local variables
            string employeeName;
            decimal hoursWorked, payRate;
            //assign inputs to variables 
            employeeName = txtName.Text;
            hoursWorked = Convert.ToDecimal(nudHoursWrkd.Value);
            payRate = Convert.ToDecimal(nudPayRate.Value);
            
            //instantiate a BMI object
            aPaySlip = new PaySlip(employeeName, hoursWorked, payRate);
            lblNetPay.Text = "$" + String.Format("{0:0.00}", aPaySlip.NetPay);
            btnSummary.Enabled = true;
            grpBxlInfo.Enabled = false;
        }

        //y Summary button to display the total number of pay slips, total gross pay, total net pay, and the average net pay

        private void btnSummary_Click(object sender, EventArgs e)
        {
            //declare local variables
            decimal grossPay, totalNetPay, avgNetPay, numPaySlips;

            //assign inputs to variables 
            grossPay = PaySlip.TotalGrossPay;
            totalNetPay = PaySlip.TotalNetPay;
            numPaySlips = PaySlip.TotalPaySlips;
            avgNetPay = aPaySlip.CalculateAverageNetPay();

            //display summary in a message box
            string message = $"Number Of Play Slips: {numPaySlips}\n Total Gross Pay: { grossPay.ToString("c")}\n Total Net Pay: {totalNetPay.ToString("c")}\n Average Net Pay: {avgNetPay.ToString("c")}";

            MessageBox.Show(message, "Summary Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //resets the input feilds and clears the result
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            nudHoursWrkd.Value = nudHoursWrkd.Minimum;
            nudPayRate.Value = nudPayRate.Minimum;
            lblNetPay.Text = null;
            //lets the new info to be entered
            grpBxlInfo.Enabled = true;
            //doesnt allow the summary to be requested until there is a new submission
            btnSummary.Enabled = false;
        }
        //exit button closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
