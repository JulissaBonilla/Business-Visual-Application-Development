/*
 * Project: Assignment Set 2 - Program 3
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Program3
 * Description: This program is a window form that displays an advertisemetn for 
 * an organization called sacfood and booze. Also allows the user to select the 
 * color of the slogan and choose to show or hide the organizations name, tagline, 
 * logo.and the developers name.
 * Last modified: 9/19/2022
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

namespace JBonillaProgram3
{
    public partial class program3 : Form
    {
        public program3()
        {
            InitializeComponent();
                        
        }
        //When the Blue radio button is selected, the Slogan/Tagline
        //is changed Blue if selected.
        private void rdbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblSlogan.ForeColor = Color.Blue;
        }
        //When the Green radio button is selected, the Slogan/Tagline
        //is changed Green if selected.
        private void rdbtnGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblSlogan.ForeColor = Color.Green;
        }
        //When the Red radio button is selected, the Slogan/Tagline
        //is changed Red if selected.
        private void rdbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            lblSlogan.ForeColor = Color.Red;
        }
        //When the Pink radio button is selected, the Slogan/Tagline
        //is changed Pink if selected.
        private void rdbtnPink_CheckedChanged(object sender, EventArgs e)
        {
            lblSlogan.ForeColor = Color.Pink;
        }
        //If the check box is checked or unchecked the Name will be visable or hidden
        private void chbxName_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Visible = !lblName.Visible;
        }
        //If the check box is checked or unchecked the Slogan/Tagline will be visable or hidden
        private void chbxTagline_CheckedChanged(object sender, EventArgs e)
        {
            lblSlogan.Visible = !lblSlogan.Visible;
        }
        //If the check box is checked or unchecked the Logo will be visable or hidden
        private void chbxLogo_CheckedChanged(object sender, EventArgs e)
        {
            picLogo.Visible = !picLogo.Visible;
        }
        //If the check box is checked or unchecked the Developer info will be visable or hidden
        private void chbxDev_CheckedChanged(object sender, EventArgs e)
        {
            lblDev.Visible = !lblDev.Visible;
        }
        //This closes the program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
