/*
 * Project: Assignment Set 3- Program 8
 * Date:    October 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  PaySlip
 * Description: This program calculates the net pay given the gross pay and 
 * takes out the charges for different tax requirements given pay rate and the
 * hours worked. Also gives a summary of total gross pay and total netpay.
 * 
 * Last modified: 10/5/2022
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram8
{
    class PaySlip
    {
        //Instance Properties read only feilds
        public readonly string EmployeeName;
        public readonly decimal HoursWorked;
        public readonly decimal NetPay;
        public readonly decimal PayRate;

        //Instance Properties with getter and setter accessors
        public static decimal TotalGrossPay { get; private set; }

        public static decimal TotalNetPay { get; private set; }

        public static int TotalPaySlips { get; private set; }
        //Constructor: instantiates object, sets employee name, hours worked,
        //and pay rate - using parameters,
        public PaySlip(string employeeName, decimal hoursWorked, decimal payRate)
        {
            EmployeeName = employeeName;
            HoursWorked = hoursWorked;
            PayRate = payRate;
            //sets the net pay property by calling the instance method
            //that calculates net pay
            NetPay =CalculateNetPay();

        }

        public decimal CalculateNetPay()
        {
            decimal net, gross, fedTax, stateTax, SSTax, MedTax;
            gross = HoursWorked * PayRate;
            fedTax = gross * Convert.ToDecimal(.1219);
            stateTax = gross * Convert.ToDecimal(.0451);
            SSTax = gross * Convert.ToDecimal(.0623);
            MedTax = gross * Convert.ToDecimal(.0147);

            net = gross - fedTax - stateTax - SSTax - MedTax;

            TotalGrossPay = TotalGrossPay + gross;
            TotalNetPay = TotalNetPay + net;
            TotalPaySlips++;

            return net;

        }

        public decimal CalculateAverageNetPay()
        {
            return TotalNetPay/TotalPaySlips;
        }

        

       
    }
}
