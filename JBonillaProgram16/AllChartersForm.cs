/*
 * Project:         Assignment 7 Program 16
 * Date:            December 2022
 * Developed By:    JulissaB
 * Purpose:         This is a form to show the collection of charter objects.
 *                  This provides the user with a visual representation of the data they have added.
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
    public partial class AllChartersForm : Form
    {
        public AllChartersForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
