using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBonillaProgram4
{
    public partial class program4 : Form
    {
        public program4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double loanAmount;
            double loanDuration;
            double annualIntrest;
            double monPayment;
            Loan aLoan;
            
            //variables assined values collected by user input
            
            loanAmount = Convert.ToDouble(nudLoanAmount.Value);
            loanDuration= Convert.ToDouble(nudLoanDuration.Value);
            annualIntrest = Convert.ToDouble(nudAnnualInterest.Value);

            //instantiate a Loan object

            aLoan = new Loan();

            //call method and assign returned value to variable
            
            monPayment = aLoan.CalculateMonthlyPayment(loanAmount,loanDuration,annualIntrest);

            //display the returned value in lblMonPay
           
            lblMonPay.Text = monPayment.ToString("N");
        
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           //reset the user inputs to default zero
            
            nudAnnualInterest.Value = 0;
            nudLoanAmount.Value = 0;
            nudLoanDuration.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes program
            
            this.Close();
        }
    }
}
