/*
 * Project:         Assignment Set 6 - Program 15
 * Date:            November 2022
 * Developed By:    LV
 * Class Name:      ScoreCard
 * Assumption:      The scorecard is for a specific tournament and year
 * Last Modified:   11/17/22  Julissab
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CIS605AS6
{
    class ScoreCard
    {
        #region "Constants"

        const string LPGATour = "2022 U.S. Open", CourseName = "Pines Needles Lodge & Golf Club";

        int[] CoursePars = {5,4,3,4,3,4,4,4,4,5,4,4,3,4,5,3,4,4};

        #endregion

        #region "Properties"

        public string PlayerName { get; private set; }
        public int[,] ScoresByRound { get; private set; }

        #endregion

        #region "Constructor"

        public ScoreCard(string name, int[,] scores)
        {
            PlayerName = name;

            ScoresByRound = scores;
        }

        #endregion

        #region "Methods"

        /* Complete this method to calculate and return the player's status after each hole for a given round.
         * 
         * Status after hole 1 =  Score for hole 1 - Par for hole 1
         * 
         * Status after holes 2 through 18 = 
         * 
         *    Status after previous hole + (Score for current hole - Par for current hole)
        */

        public int[] CalcStatusAfterHole(int round)
        {
            int numHoles = ScoresByRound.GetLength(1);
            int[] statusByHole = new int[numHoles];
            
            //get the score status after the first whole (round-1: because the index starts at 0)
            statusByHole[0] = ScoresByRound[round-1,0] - CoursePars[0];
           
            //for loop to loop throught the rest of the holes scores
            for (int col=1; col < numHoles; col++)
            {
                statusByHole[col] = statusByHole[col-1] + (ScoresByRound[round - 1, col] - CoursePars[col]);
            }
            return statusByHole;

        }

        /* Complete this method to calculate and return the player's average score for holes of a specific par (i.e., 3, 4 or 5).
         * 
         * Player's average score for holes of a specific par = 
         * 
         *  Player's total score for holes of a specific par for all 4 rounds / (Total number of holes of a specific par
         *           * number of rounds (i.e., 4))
         *           
         *  Note: Do not use a manual count of the number of holes of a specific par.
         *  
         *  Instead, write code to find the number of holes of a specific par.
        */

        public double CalcAverageScoreByPar(int par)
        {
            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            // declare an array to store the total score 

            double parSum = 0;
            double parRoundCount = 0;

            // loop through the array to calculate the total score

            // for each round

            for  (int col = 0; col < numHoles; ++col)
            {
                if (CoursePars[col]==par)
                {
                    parRoundCount++;
                    for (int row = 0; row < numRounds; ++row)
                    {
                        parSum += ScoresByRound[row, col];
                    }
                }
                
            }
            return parSum / (parRoundCount * numRounds);
        }

        /* A player's score for a given hole is "consistent" if it is the same for all four rounds. 
         * 
         * Complete this method to find and return the number of holes for which the player's score was "consistent".
        */
        public int FindNumberOfHolesWithConsistentScore()
        {
            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);

            //counter for how many consistant holes
            int consistant = 0;
           
            // for each round

            for (int col = 0; col < numHoles; ++col)
            {
                //count howmany with the same score each round as the first score of a given hole
                int same = 1;
                //collects the first score of each hole to compare to 
                int first = ScoresByRound[0, col];
              for (int row = 1; row < numRounds; ++row)
              {
                    //goes through each round score for the hole and adds to the count for same in the colomn
                    if(ScoresByRound[row,col] ==first)
                    {
                        same++;
                    }
              }
              //if all scores of all rounds are consistant then the number "same" in that hole will be equal to the number of rounds
              if (same==numRounds)
                {
                    consistant++;
                }
            }
            return consistant;
            
        }

        /* Complete this method to calculate and return the player's overall performance by score type (i.e., Number of Eagles, Birdies, Pars, Bogeys and Double Bogeys)
         * 
         * Number of Eagles = Count of number of times player's score is two strokes below par
         * 
         * Number of Birdies = Count of number of times player's score is one stroke below par
         * 
         * Number of Pars = Count of number of times player's score is equal to par
         * 
         * Number of Bogeys = Count of number of times player's score is one stroke above par
         * 
         * Number of Double Bogeys = Count of number of times player's score is two strokes above par
        */

        public string CalcPerformanceByScoreType()
        {
            int numEagles = 0;
            int numBirdies = 0;
            int numPars = 0;
            int numBogeys = 0;
            int numDoubleBog = 0;

            int numRounds = ScoresByRound.GetLength(0);
            int numHoles = ScoresByRound.GetLength(1);


            for (int col = 0; col < numHoles; ++col)
            {
                for (int row = 0; row < numRounds; ++row)
                {
                    int score = ScoresByRound[row, col] - CoursePars[col];
                    
                    if (score == 0)             //Number of Pars = Count of number of times player's score is equal to par

                    {
                        numPars++;
                    }
                    else if(score==-2)         //Number of Eagles = Count of number of times player's score is two strokes below par
                    {
                        numEagles++;
                    }
                    else if (score==-1)        //Number of Birdies = Count of number of times player's score is one stroke below par
                    {
                        numBirdies++;
                    }
                    else if (score==1)         //Number of Bogeys = Count of number of times player's score is one stroke above par
                    {
                        numBogeys++;
                    }
                    else if (score==2)         //Number of Double Bogeys = Count of number of times player's score is two strokes above par
                    {
                        numDoubleBog++;
                    }
                                       
                }
            }
            string output = $"Stats:\nNumber of Eagles: {numEagles}\nNumber of Birdies: {numBirdies}\nNumber of Pars: {numPars}\nNumber of Bogeys: {numBogeys}\nNumber of Double Bogeys: {numDoubleBog}";
            return output;

        }
        #endregion
    }
}
