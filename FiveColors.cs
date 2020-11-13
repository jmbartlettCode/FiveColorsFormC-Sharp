/* 
Josh Bartlett
3Aug2019
Assignment 7.3
Create a form that contains at least five Button objects, each labeled with a color.  
When the user clicks a Button, change the BackColor of the Form appropriately.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    static class FiveColors
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FiveColorsForm());
        }
    }
}
