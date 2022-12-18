/*
 * Project: Assignment Set 2 - Program 4
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  Loan
 * Description: Calculates monthly loan payment amount.
 * Last modified: 9/19/2022
 */using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram4
{
    class Loan
    {
        public double CalculateMonthlyPayment(double loanAmount,double loanDuration,double annualIntrest)
        {
            //calculate monthly intrest from the annual intrest and assign to a variable
            
            double monInterest = annualIntrest / (100 * 12);

            //Calculate monthly payment and assign to variable
            
            double monPayment = loanAmount * (monInterest * Math.Pow((1 + monInterest), loanDuration) / (Math.Pow((1 + monInterest), loanDuration)-1));
            
            //return monthly payment amount
            
            return monPayment;
        }
        
    }
}
