using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
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
     * Release 0 Stage 1 Step 2
     * v0.1.2
     */
    //Next Step: Finish user keyboard functionality (Add button for rests & allow user to change octave and whatnot)
    public partial class PiaOhNo : Form
    {
        System.Timers.Timer delayTimer;
        static bool playWhenPress = true;
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
        static int octave = 5;
        static int duration;
        
        public PiaOhNo()
        {
            InitializeComponent();
            Button[] wKeys = ListAllWhiteKeys();
            KeyDown += PiaOhNo_KeyDown;
        }

        private void PiaOhNo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: octave += 1;
                    break;
                case Keys.Down: octave -= 1;
                    break;
                case Keys.Right: duration += 1;
                    break;
                case Keys.Left: duration -= 1;
                    break;
            }
        }

        private void WhiteKeysTable(object sender, PaintEventArgs e)
        {
            //Figuring this out took way too long.
            int displayH = ClientRectangle.Height;
            int displayW = ClientRectangle.Width;
            //Want the margin to be 3% of the width of the window.
            //Also want the top of the keyboard to be about down about 60.5% of the way. 
            double[] pianoAnchor = { 0.03 * displayW, .605 * displayH }; // Can't cast to integer inside of the array. It breaks.
            whiteKeys.Location = new Point((int)pianoAnchor[0], (int)pianoAnchor[1]);
            whiteKeys.Size = new Size(displayW - (int)(pianoAnchor[0] * 2), displayH - (int)pianoAnchor[1]);
        }
        private void SongTable_Paint(object sender, PaintEventArgs e)
        {
            int displayH = ClientRectangle.Height;
            int displayW = ClientRectangle.Width;
            //Want the margin to be 3% of the width of the window.
            double[] tableAnchor = { 0.03 * displayW, .2 * displayH };
            songTable.Location = new Point((int)tableAnchor[0], (int)tableAnchor[1]);
            songTable.Size = new Size(displayW - (int)(tableAnchor[0] * 2), (int)tableAnchor[1] * 2);
        }
        private void PlayNote(double freq, char oct, int dur)
        {
            //Check for a valid frequency
            if (freq > 37 && freq < 32767)
            {
                Console.Beep((int)freq, dur);
            }
            else
            {
                //rest.
                delayTimer = new System.Timers.Timer(dur);
                delayTimer.Elapsed += (sender, s) => { delayTimer.Stop(); };
            }
        }
        private double GetFrequency(char freqChar, char oct)
        {
            if (freqChar >= 'a' && freqChar <= 'g')
            {
                return notes[freqChar - 'a'] * Math.Pow(2, oct - '0'); // Single line statements to make whoever is reading this suffer.
            }
            //Else if the note is uppercase, play sharp note.
            else if (freqChar >= 'A' && freqChar <= 'G')
            {
                return notes[freqChar - 'A'] * Math.Pow(2, oct - '0') * Math.Pow(2, 1.0 / 12.0); //POW!!
            }
            else
            {
                //Return 0 in order to play rests.
                return 0;
            }
        }
        private int GetDuration(char d)
        {
            int dur;
            //Temporarily setting tempo to a fixed 1000
            int tempo = 1000;
            switch (d)
            {
                case 's': dur = tempo / 16; break;// s = Sixteenth
                case 'e': dur = tempo / 8; break; // e = Eighth
                case 'q': dur = tempo / 4; break; // q = Quarter
                case 'h': dur = tempo / 2; break; // h = Half
                case 'S': dur = tempo / 16 + (tempo / 32); break; // capitalized notes represent dotted note
                case 'E': dur = tempo / 8 + (tempo / 16); break; // by adding 50% of the duration to a note,
                case 'Q': dur = tempo / 4 + (tempo / 8); break; // it becomes a standard dotted note
                case 'H': dur = tempo / 2 + (tempo / 4); break;
                case 'W': dur = tempo + (tempo / 2); break;
                default: dur = tempo; break; // Regular whole notes
            }
            return dur;
        }
        private void PlayKey(object sender, EventArgs e)
        {
            Button play = sender as Button;
            //Clear the textbox if it has the default text.
            if (songTextBox.Text == "(Write your song here!)") songTextBox.Clear(); //Ik this is stupid, deal. 
            //I'll need to get input for which octave, for v.0.1.1, im just locking at octave 5.
            char octave = '5';
            //If the user is holding down the shift key, capitalize the note name to make it sharp
            char freqChar = Control.ModifierKeys != Keys.Shift ? play.Name[0] : char.ToUpper(play.Name[0]);
            double freq = GetFrequency(freqChar, octave);
            //Need to get input for length aswell, will just lock at quarter.
            int dur = GetDuration('q'); //GetDuration();
            songTextBox.Text += $"{freqChar}{octave}{'q'} "; //space afterwards in order to seperate notes.
            if (playWhenPress) PlayNote(freq, octave, dur);
        }
        private Button[] ListAllWhiteKeys()
        {
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
