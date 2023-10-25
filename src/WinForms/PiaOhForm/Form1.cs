using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiaOhForm
{
    /*
     * Pia-Oh-No!
     * Written By: Matthew Sorensen
     * 10/24/2023
     * GTI Programming 1-2 Class project
     * Winforms Edition
     */
    public partial class PiaOhNo : Form
    {
        
        public PiaOhNo()
        {
            InitializeComponent();
        }

        private void whiteKeysTable(object sender, PaintEventArgs e)
        {
            //Figuring this out took way too long.
            int displayH = ClientRectangle.Height;
            int displayW = ClientRectangle.Width;
            //Want the margin to be 3% of the width of the window.
            //Also want the top of the keyboard to be about down about 60.5% of the way. 
            double[] pianoAnchor = {0.03*displayW, .605*displayH}; // Can't cast to integer inside of the array. It breaks.
            whiteKeys.Location = new Point((int)pianoAnchor[0], (int)pianoAnchor[1]);
            whiteKeys.Size = new Size(displayW - (int)pianoAnchor[0]*2, displayH-50); 
            whiteKeys.BackColor = Color.White;
        }
        //Figure out arrays and button click.. thing... im tired, going to bed.
    }
}
