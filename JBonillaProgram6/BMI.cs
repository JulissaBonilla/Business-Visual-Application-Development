/*
 * Project: Assignment Set 3- Program 6
 * Date:    September 2022
 * Developed By:    Julissa Bonilla
 * Class Name:  BMI
 * Description: This program calculates the users BMI given 
 * their Name weight and height.
 * 
 * Last modified: 10/3/2022
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram6
{
    public class BMI
    {
        private int userHeight;
        private string userName;
        private int userWeight;

        //Instance Properties with getter and setter accessors
        public string UserName { get; set; }
        public int UserWeight { get; set; }
        public int UserHeight { get; set; }

        
        //Constructors   instantiate the objects
        public BMI(string name, int weight, int height)
        {
            userName = name;
            userWeight = weight;
            userHeight = height;
        }
        
        //Calculate BMI      
        public double CalculateBMI()
        {
            double num = (userWeight * 703);
            double den = Math.Pow(userHeight, 2);
            double UserBMI = num/ den;
            return UserBMI;
        }

    }
}