/* 
Josh Bartlett
3Aug2019
Assignment 7.3
Create a form that contains at least five Button objects, each labeled with a color.  
When the user clicks a Button, change the BackColor of the Form appropriately.  
*/

using System;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class FiveColorsForm : Form
    {
        public FiveColorsForm()
        {
            InitializeComponent();
        }
        // When the Red button is clicked change form background to red
        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }
        // When the Blue button is clicked change form background to blue
        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }
        // When the Yellow button is clicked change form background to yellow
        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
        // When the Greem button is clicked change form background to green
        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }
        // When the Purple button is clicked change form background to purple
        private void btnPurple_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Purple;
        }
    }
}
