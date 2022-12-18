﻿/*
 * Project:         Assignment 7 Program 16
 * Date:            December 2022
 * Developed By:    JulissaB
 * Purpose:         The charter manager connects withthe charter class by creating a list of charter objects.
 *                  Other calculations occure to find the lowest fee the average fee and generates a count of 
 *                  how many charter items are in the list generated by the user.
 * Last Modified:   12/10/22
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace JBonillaProgram16
{
    public class CharterManager
    {
        public List<Charter> CharterList { get; private set; }
        public CharterManager()
        {
            CharterList=new List<Charter>();
        }
        //add a charter object and add to list of charters to manage
        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, charterHours);

            CharterList.Add(aCharter);

        }
        //calculates lowest charter fee in the charter list
        public decimal FindLowestCharterFee()
        {
            decimal currentLowest = (decimal)CharterList[0].CharterFee;
            
            foreach (Charter aCharter in CharterList)
            {
                if(aCharter.CharterFee < currentLowest)
                {
                    currentLowest = aCharter.CharterFee;
                }
            }
            return currentLowest;
        }
        
        //get the average charter fee
        public decimal GetAverageCharterFee()
        {
            return GetTotalCharterFee() / (decimal)CharterList.Count;
        }

        //Calculate the total charter fee of all charters
        public decimal GetTotalCharterFee()
        {
            decimal total = 0;

            foreach (Charter aCharter in CharterList)
            {
                total += aCharter.CharterFee;
            }
            return total;
        }

        //calculates the count of howmany charters are in the list
        public int GetCharterCount(int yachtSize)
        {
            int count = 0;

            foreach(Charter aCharter in CharterList)
            {
                if (aCharter.YachtSize==yachtSize)
                {
                    count++;
                }
            }
            return count;
        }
    }
}