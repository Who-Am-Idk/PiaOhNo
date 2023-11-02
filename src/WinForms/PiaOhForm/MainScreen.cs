using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PiaOhForm
{
    /*
     * Pia-Oh-No!
     * Written By: Matthew Sorensen
     * 10/24/2023
     * GTI Programming 1-2 Class project
     * Winforms Edition
     * Release 0 Stage 1 Step 1
     * v0.1.1
     */
    public partial class PiaOhNo : Form
    {
        //Dictionary<string, string> keyValues = new Dictionary<string, string>();
        //SoundPlayer sp;
        static double[] notes =
       {
        27.50,//a0
        30.87,//b0
        16.35,//c0
        18.35,//d0
        20.60,//e0
        21.83,//f0
        24.50 //g0
       };
        public PiaOhNo()
        {
            InitializeComponent();
            Button[] wKeys = ListAllWhiteKeys();
            //songTextBox.PlaceholderText = "";
        }

        private void WhiteKeysTable(object sender, PaintEventArgs e)
        {
            //Figuring this out took way too long.
            int displayH = ClientRectangle.Height;
            int displayW = ClientRectangle.Width;
            //Want the margin to be 3% of the width of the window.
            //Also want the top of the keyboard to be about down about 60.5% of the way. 
            double[] pianoAnchor = {0.03*displayW, .605*displayH}; // Can't cast to integer inside of the array. It breaks.
            whiteKeys.Location = new Point((int)pianoAnchor[0], (int)pianoAnchor[1]);
            whiteKeys.Size = new Size(displayW - (int)(pianoAnchor[0]*2), displayH - (int)pianoAnchor[1]); 
        }
        private void SongTable_Paint(object sender, PaintEventArgs e)
        {
            int displayH = ClientRectangle.Height;
            int displayW = ClientRectangle.Width;
            //Want the margin to be 3% of the width of the window.
            double[] tableAnchor = { 0.03 * displayW, .2 * displayH };
            songTable.Location = new Point((int)tableAnchor[0], (int)tableAnchor[1]);
            songTable.Size = new Size(displayW - (int)(tableAnchor[0] * 2), (int)tableAnchor[1]*2);
        }
        private void PlayNote(string note) { 

        }
        private void PlayKey(object sender, EventArgs e) {
            Button play = sender as Button;
            //Take the first letter of the name of the button
            
            //Clear the textbox if it has the default text.
            if (songTextBox.Text == "(Write your song here!)") songTextBox.Clear(); //Ik this is stupid, deal. 
            //I'll need to get input for which octave, for v.0.1.1, im just locking at octave 5.
            char temp = play.Name[0];
            char octave = '5'; //GetOctave();
            //Need to get input for length aswell, will just lock at quarter.
            char dur = 'q'; //GetDuration
            songTextBox.Text += $"{temp}{octave}{dur} "; //space afterwards in order to seperate notes.
            PlayNote($"{temp}{octave}{dur} ");
        }
        private Button[] ListAllWhiteKeys() {
            List<Button> b = new List<Button>();
            foreach (Control control in whiteKeys.Controls)
            {
                if (control is Button button)
                {
                    b.Add(button);
                    button.Click += PlayKey;
                }
            }
            return b.ToArray();
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
        }
        private void PiaOhNo_Resize(object sender, EventArgs e)
        {
            WhiteKeysTable(null, null);
            SongTable_Paint(null, null);
        }
    }
}
