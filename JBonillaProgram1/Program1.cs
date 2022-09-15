using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JBonillaProgram1
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }
        private void btnAnimal_Click_1(object sender, EventArgs e)
        {
            // call DisplayFavoriteAnimal method and display
            // returned value in lblResult
            lblResult.Text = MyFavorites.DisplayFavoriteAnimal();
        }

        private void btnSeason_Click(object sender, EventArgs e)
        {
            // call DisplayFavoriteSeason method and display
            // returned value in lblResult
            lblResult.Text = MyFavorites.DisplayFavoriteSeason();
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            // call DisplayFavoriteHoliday method and display
            // returned value in lblResult
            lblResult.Text = MyFavorites.DisplayFavoriteHoliday();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
