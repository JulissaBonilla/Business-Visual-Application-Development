/*
 * Project:         Assignment 5 Program 11
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         WaterTank uses the information inputed into the form and performs desired calculations using the given informaiton.
 * Last Modified:   11/4/22
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram11
{
    class WaterTank
    {
        public int TankCapacity { get; private set; }
        public int TankDepth { get; private set; }
        public int TankRadius { get; private set; }
        public int WaterLevel { get; private set; }

        //Constructor, instantiates object and sets radius and depth using parameters

        public WaterTank(int tankRadius, int tankDepth)
        {
            TankRadius = tankRadius;
            TankDepth = tankDepth;
            TankCapacity = CalcTankCapacity();
        }

        //Calculates the maximum water capacity of a tank
        private int CalcTankCapacity()
        {
            double maxCapacity = Math.PI*Math.Pow(TankRadius,2)*TankDepth*1000;

            //convert to int
            return Convert.ToInt32(Math.Floor(maxCapacity));
        }


        //Adds water amount to the current amount of water in tank
        public string AddWater(int litersToAdd)
        {
            int currentToMax = TankCapacity - WaterLevel;

            string message = string.Empty;

            //If the number of liters to be added will not caue the tank to overflow
            if(litersToAdd<=currentToMax)
            {
                WaterLevel += litersToAdd;

                //confirm the liters of water added
                message = litersToAdd.ToString("n0")+ " liters of water added \n";
            }
            else 
            {
                //overflow message
                message = $"Tank will overflow - water not added\n";
            }

            //update/no change the current water level
            return message+ $"Current water level of tank: " + WaterLevel.ToString("n0");
        }

        //decreases water amount to the current amount of water in tank
        public string WithdrawWater(int litersToWithdraw)
        {
            int newWaterLevel = WaterLevel - litersToWithdraw;

            string message = string.Empty;


            //will withdraw water amount only if the number of liters to be withdrawn isn't more than the amount of water in the tank

            if (newWaterLevel >= 0)
            {
                WaterLevel -= litersToWithdraw;

                //confirm water has been withdrawn
                message = litersToWithdraw.ToString("n0") + " liters of water withdrawn \n";
            }
            else
            {
                //overempty  message
                message = $"Not enough water - water not withdrawn\n";
            }

            //update/no change the current water level
            return message + $"Current water level of tank: "+ WaterLevel.ToString("n0");
        }

        //Drain tank by a given rate
        public bool DrainTank(int litersPerSecond)
        {
            int newWaterLevel = WaterLevel - litersPerSecond;

            bool result = false;
            
            //check that waterlevel is not empty
            if (newWaterLevel >= 0)
            {
                //devcrease water level by the rate provided
                WaterLevel -= litersPerSecond;
                result = true;
            }

            return result;
               
        }

        public bool FillTank(int litersPerSecond)
        {
            int currentToMax = TankCapacity - WaterLevel;
            bool result = false;

            //as long as water level isn't to the top of the tanks capasity water will fill
            if (litersPerSecond <= currentToMax)
            {
                //increase waterlevel  by the rate provided
                WaterLevel += litersPerSecond;
                result = true;
            }

            return result;
        }

       
    }
}
