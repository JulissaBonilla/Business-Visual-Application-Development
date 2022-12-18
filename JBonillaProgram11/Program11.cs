/*
 * Project:         Assignment 5 Program 11
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         Form class for Water tank. User can input the dimentions of a cylinderical water tank. 
 *                  The user can then view current water levels and maximum water the tank can hold. 
 *                  The user can add water or with drawwater of their desired amount.
 *                  They can also fill and drain the tanks by a custom rate.
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

namespace JBonillaProgram11
{
    public partial class Program11 : Form
    {
        private WaterTank aWaterTank;
        public Program11()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare method-level variables and assign input to variable
            int radius = Convert.ToInt32(nudRadius.Value);
            int depth = Convert.ToInt32(nudDepth.Value);

            // instantiate object
            aWaterTank = new WaterTank(radius,depth);

            // disable/enable controls
            grpDimensions.Enabled = false;
            grpData.Enabled = true;
            grpAddWithdraw.Enabled = true;
            grpFillDrain.Enabled = true;
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            //call the waterlevel property of watertank 
            lblCurrent.Text = $"{aWaterTank.WaterLevel.ToString("n0")} liters";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //call the tank capacity property of water tank 
            lblMax.Text = $"{aWaterTank.TankCapacity.ToString("n0")} liters";
        }

        private void btnAddWithdraw_Click(object sender, EventArgs e)
        {
            int liters = Convert.ToInt32(nudLiters.Value);

            //using the input provided and checking the add or withdraw radio selection, calls repected action from watertank
            lblSummary.Text = (radAdd.Checked) ? aWaterTank.AddWater(liters) : aWaterTank.WithdrawWater(liters);
            
            btnCurrent_Click(sender,e);
        }

        private void btnFillDrain_Click(object sender, EventArgs e)
        {
            int litersPerSec = Convert.ToInt32(nudLitersPerSecond.Value);
            string output = string.Empty;

            //using the input provided and checking the fill or drain radio selection, calls repected action from watertank

            if (radFill.Checked)
            {
                //as long as water level isn't to the top of the tanks capasity water will fill

                while (aWaterTank.FillTank(litersPerSec))
                {
                    output += aWaterTank.WaterLevel.ToString("n0") + " liters\r\n";
                    txtFillDrainResult.Text = output;
                }
                txtFillDrainResult.Text = output += "\nFull";
            }
            else
            {
                //as long as there is water in the tank to drain, it will drain

                while (aWaterTank.DrainTank(litersPerSec))
                {
                    output += aWaterTank.WaterLevel.ToString("n0") + " liters\r\n";
                    txtFillDrainResult.Text = output;
                }
                txtFillDrainResult.Text = output += "\nEmpty";
            }

            btnCurrent_Click(sender, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset input values
            nudLiters.Value = nudLiters.Minimum;
            nudLitersPerSecond.Value = nudLitersPerSecond.Minimum;
            nudRadius.Value = nudRadius.Minimum;
            nudDepth.Value = nudDepth.Minimum;

            //reset radio buttons
            radAdd.Checked = true;
            radFill.Checked = true;

            //reset labels
            lblCurrent.Text = null;
            lblMax.Text = null;
            txtFillDrainResult.Clear();
            lblSummary.Text = null;

            //enable/disable controls

            grpData.Enabled = false;
            grpDimensions.Enabled = true;
            grpAddWithdraw.Enabled = false;
            grpFillDrain.Enabled = false;

            //set focus
            nudRadius.Focus();
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
                nudRadius.Focus();
            }
        }
    }
}
