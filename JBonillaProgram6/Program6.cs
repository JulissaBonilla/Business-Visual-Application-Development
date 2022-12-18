/*
 * Project: Assignment Set 3- Program 6
 * Date:    October 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Program 6
 * Description: This form class that is a presentation layer of the GUI for BMI
 * Uses: BMI class
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

namespace JBonillaProgram6
{
    public partial class Program6 : Form
    {
        //declare object variable
        private BMI aBMI;
        public Program6()
        {
            InitializeComponent();
        }
        //resets the input feilds and clears the result
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            nudHeight.Value = 1;
            nudWeight.Value = 1;

            lblBMIresult.Text = null;

        }
        //Creates a BMI object and calls the instance method and displays user's BMI in label
        private void btnBMI_Click(object sender, EventArgs e)
        {
            //if statment from example program
            if (txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("User name is required", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }

            //local variables
            string userName;
            int userHeight, userWeight;

            //assign input data to local variables
            userName = txtName.Text;
            userHeight = Convert.ToInt32(nudHeight.Value);
            userWeight = Convert.ToInt32(nudWeight.Value);

            //instantiate a BMI object
            aBMI = new BMI(userName,userWeight, userHeight);

            //access and display results

            lblBMIresult.Text = Convert.ToString(aBMI.CalculateBMI());


        }

        //exit button closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
