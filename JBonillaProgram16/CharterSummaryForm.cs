/*
 * Project:         Assignment 7 Program 16
 * Date:            December 2022
 * Developed By:    JulissaB
 * Purpose:         This form is displayed when the user selects to view a summary of
 *                  the lowest charter fee, the total fees from all charters, and the average fee of all the charters
 * Last Modified:   12/10/22
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JBonillaProgram16
{
    public partial class CharterSummaryForm : Form
    {
        public CharterSummaryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
