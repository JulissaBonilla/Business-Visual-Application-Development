/*
 * Project:         Assignment 7 Program 16
 * Date:            December 2022
 * Developed By:    JulissaB
 * Purpose:         This is the charter class that connects with the food manager class.
 *                  Creates charter objects and calculates charter rate based on yacht size.
 * Last Modified:   12/10/22
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram16
{
    public class Charter
    {
        public decimal CharterFee { get; set; }
        public decimal CharterHours { get; set; }
        public string CustomerName { get; set; }
        public int YachtSize { get; set; }
        public string YachtType { get; set; }

        //istantiate object
        public Charter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            CustomerName = customerName;
            YachtType = yachtType;  
            YachtSize = yachtSize;
            CharterHours = charterHours;
            CharterFee = CalculateCharterFee();
        }
        //charter fee based on the yacht size (derived form chart provided)
        public Decimal CalculateCharterFee()
        {
            decimal rate = 0;
            switch (YachtSize)
            {
                case 22:
                    rate = 235;
                    break;
                case 24:
                    rate = 301;
                    break;
                case 30:
                    rate = 355;
                    break;
                case 32:
                    rate = 417;
                    break;
                case 36:
                    rate = 563;
                    break;
                case 38:
                    rate = 599;
                    break;
                case 45:
                    rate = 697;
                    break;
            }
            return rate;
        }
    }
}