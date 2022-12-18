/*
 * Project:         Assignment 5 Program 12
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         Form class, allows user to input the initial height in feet and 
 *                  inital velocity in feet/second to create a projectile.
 *                  User is able to select to calculate the maximum height and landing  time.
 * Last Modified:   11/4/22
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

namespace JBonillaProgram12
{
    public partial class Program12 : Form
    {
        Projectile aProjectile;
        public Program12()
        {
            InitializeComponent();

            //keeps projectile motion info inacessible until the projectile object is created 
            grpInfo.Enabled = false;
        }


        //creates projectile object
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //gather inputs
            int initialHeight = Convert.ToInt32(nudInitialHeight.Value);
            int initialVelocity = Convert.ToInt32(nudInitialVelocity.Value);

            //create object using inputs
            aProjectile = new Projectile(initialHeight, initialVelocity);

            //set the projectile motion info available and make the data inaccessible to change
            grpData.Enabled = false;
            grpInfo.Enabled = true;

        }


        //Maximum height requested
        private void btnMax_Click(object sender, EventArgs e)
        {
            //calling MaxHeight property from Projectile class
            lblMax.Text = (aProjectile.MaxHeight).ToString("0.00")+" feet";
        }

        //land time requested
        private void btnLand_Click(object sender, EventArgs e)
        {
            //calling LandTime property from Projectile class
            lblLand.Text = (aProjectile.LandTime).ToString("0.00")+ " seconds";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset inputs
            nudInitialHeight.Value = nudInitialHeight.Minimum;
            nudInitialVelocity.Value = nudInitialVelocity.Minimum;

            //reset lables
            lblLand.Text = string.Empty;
            lblMax.Text = string.Empty;

            //enable/disable groups
            grpInfo.Enabled = false;
            grpData.Enabled = true;
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
            
        }
    }
}
