/*
 * Project:         Assignment Set 6 - Program 14
 * Date:            November 2022
 * Developed By:    LV
 * Class Name:      StockAnalyzer
 * Last modified:   11/17/22 Julissab
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CIS605AS6
{
    class StockAnalyzer
    {
        #region "Property"

        public string TickerSymbol { get; private set; }
        public decimal[] StockPrices { get; private set; }

        #endregion

        #region "Constructor"

        public StockAnalyzer(string symbol, decimal[] prices)
        {
            TickerSymbol = symbol;

            StockPrices = prices;
        }

        #endregion

        #region "Methods"

         /* Complete this method to find and return the smallest percentage gain in price between any two consecutive trading days.
         * 
         *  The return value should be formatted to display with a % sign and 6 decimal places.
         *  
         *  Percentage change in price between two consecutive trading days (e.g., Days 1 and 2) =
         *  
         *        (Day 2 Price - Day 1 Price) / Day 1 Price
        */

        public string FindSmallestPercentageGainInPrice()
        {
            decimal currentMin = decimal.MaxValue;
            string output = "No gain in price";

            for(int x=0; x<StockPrices.Length-1;++x)
            {
                decimal currentDiff = (decimal.Subtract(StockPrices[x + 1], StockPrices[x]) / StockPrices[x]);
                if (currentDiff >0 && currentDiff< currentMin)
                {
                    currentMin = currentDiff;
                }
            }

            if (currentMin != decimal.MaxValue)
            {
                output = $"{currentMin.ToString("p6")}";
            }
            return output;
        }

        /* Complete this method to find and return the largest price change (either up or down) between any two consecutive trading days. 
         * 
         * Price change (either up or down) between two consecutive trading days (e.g., Days 1 and 2) =
         * 
         *        Absolute value of (Day 2 Price - Day 1 Price) 
        */

        public decimal FindLargestAbsolutePriceChange()
        {
            decimal currentMaxChange = 0;
            

            for (int x = 0; x < StockPrices.Length - 2; ++x)
            {
                decimal currentDiff = Math.Abs(decimal.Subtract(StockPrices[x + 1], StockPrices[x]));
                if (currentDiff > currentMaxChange)
                {
                    currentMaxChange = currentDiff;
                }
            }

            return Math.Abs(currentMaxChange);

        }

        /* Complete this method to find and return the number of times there is a negative change in price between any two consecutive trading days.
         * 
         * There is a negative change in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price < 0
        */

        public int FindNumTimesNegativePriceChange()
        {
            int negChangeCount = 0;


            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                
                if (StockPrices[x + 1] < StockPrices[x])
                {
                    negChangeCount++;
                }
            }

            return negChangeCount;


        }

        /* Complete this method to find and return the longest period (in days) of continuous price gain.
         * 
         * There is a gain in price between two consecutive trading days (e.g., Days 1 and 2), if Day 2 Price - Day 1 Price > 0
        */

        public int FindLongestPriceGainStreak()
        {
            int gainStreak = 0;
            int longest = 0;


            for (int x = 0; x < StockPrices.Length - 1; ++x)
            {
                
                if (StockPrices[x + 1] > StockPrices[x])
                {
                    gainStreak++;
                    
                }
                else
                {
                    if (gainStreak>longest)
                    {
                        longest = gainStreak;
                    }
                }

            }

            return gainStreak;


        }

        #endregion
    }
}
