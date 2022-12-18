/*
 * Project: Assignment Set 2 - Program 5
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  P0rogram5
 * Description: This program is the form class of program5
 * Last modified: 9/21/2022
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

namespace JBonillaProgram5
{
    public partial class Program5 : Form
    {
        public Program5()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //* double loanAmount;
            double sqrFt;
            double gllnPaintCost;
            double jobCost;

            PaintingJob aPaintingJob;

            //variables assined values collected by user input

            sqrFt = Convert.ToDouble(nudSqrFt.Value);
            gllnPaintCost = Convert.ToDouble(nudGllnsOfPaint.Value);

            //instantiate a PaintingJob object

            aPaintingJob = new PaintingJob();

            //call method and assign returned value to variable

            jobCost = aPaintingJob.EstimateCost(sqrFt,gllnPaintCost);

            // prepare message to display

            string message = $" Estimated cost for job: {jobCost.ToString("$0")}";

            // display the result in a message box

            MessageBox.Show(message, "Estimated Cost", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the user inputs to default zero
            nudGllnsOfPaint.Value = 0;
            nudSqrFt.Value = 0;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes program
            
            this.Close();
        }
    }
}
