using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBonillaProgram2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }
        //Collect inputs and convert to integers call CaluclateArea and display result in result label
        private void btnArea_Click(object sender, EventArgs e)
        {
            lblResult.Text = Cone.CalculateArea(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString("N2");
        }
        //Collect inputs and convert to integers call CaluclateVolume and display result in result label
        private void btnVolume_Click(object sender, EventArgs e)
        {
            lblResult.Text = Cone.CalculateVolume(Convert.ToInt32(txtRadius.Text), Convert.ToInt32(txtHeight.Text)).ToString("N2");
        }
        //Program exits upon click of exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
