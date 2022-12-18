/*
 * Project:         Assignment 5 Program 13
 * Date:            October 2022
 * Developed By:    JulissaB
 * Purpose:         Form class that uses combo boxes to list players to display the number of wins they had.
 *                  Also shows the number of back-to-back Wimbledon Champions.
 * Last Modified:   11/4/22
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

namespace JBonillaProgram13
{
    public partial class Program13 : Form
    {
        public Program13()
        {
            InitializeComponent();
        }

        private void btnWins_Click(object sender, EventArgs e)
        {
            string player = coboTopPlayers.Text;

            int numWins = 0;

            //check if there was a player selected from the list
            if (coboTopPlayers.SelectedIndex < 0)
            {
                MessageBox.Show("Select a player from Top Players list.", "Player Selection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                coboTopPlayers.Focus();
            }
            else
            {
                //check if the selected player is on the champion list

                foreach (string aPlayer in coboChampions.Items)
                {
                    if (player == aPlayer)
                    {
                        ++numWins;
                    }
                }

            }
            //display info
            lblDisplay.Text = $"{player} has won {numWins} Wimbledon Championship(s)";
        }

        private void btnBackToBack_Click(object sender, EventArgs e)
        {
            int backToBack = 0;

            //check how many players have won back to back championships
            for (int x = 1; x < coboChampions.Items.Count; ++x)
            {
                string previousPlayer = coboChampions.Items[x - 1].ToString();
                string currentPlater = coboChampions.Items[x].ToString();

                if (previousPlayer == currentPlater)
                {
                    ++backToBack;
                }
                lblDisplay.Text = $"Players have won back-to-back championships {backToBack} times";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // declare variable of type DialogResult

            DialogResult aResult;

            // assign the return value to the variable

            aResult = MessageBox.Show("Do you wish to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // take action based on the value of aResult

            if (aResult == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                coboTopPlayers.Focus();
            }
        }
    }
}
