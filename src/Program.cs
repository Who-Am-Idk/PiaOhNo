using System;

namespace PianoApp
{
    public struct playlistEntry
    {
        public string name;
        public string song;
    };
    internal class Piano
    {
        static string[] preMadeSongs =
        {
        "Happy Birthday::d5E d5s e5q d5q g5q F5h d5S d5s e5q d5q a5q g5h d5E d5s d6q b5q g5q F5q e5q c5E c5s b5q g5q a5q g5h",
        "Shave & a Haircut::c6q g5e g5e G5q g5q r1q b5q c6q r1q",
        "Drunken Sailor::a5q a5e a5e a5q a5e a5e a5q d5q f5q a5q g5q g5e g5e g5q g5e g5e g5q c5q e5q g5q a5q a5e a5e a5q a5e a5e a5q b5q c6q d6q c6q a5q g5Q e5Q d5h d5h",
        "Star Spangled Banner::g5E e5s c5q e5q g5q c6H e6E d6q c6q e5q F5q g5q g5e g5e e6Q d6e c6q b5q a5e b5e c6q c6q g5q e5q c5q g5E e5s c5q e5q g5q c6H e6E d6q c6q e5q F5q g5q g5e g5e e6Q d6e c6q b5q a5e b5e c6q c6q g5q e5q c5q g5E e5s e5q c5q e6e e6e f6q g6q g6h f6e e6e d6q e6q f6q f6h f6q e6Q d6e c6q b5b a5e b5e c6q e5q F5q g5h g5q c6q c6q c6e b5e a5q a5q a5q d6q f6e e6e d6e c6e c6q b5q g5e g5e c6Q d6e e6e f6e g6h c6e d6e e6Q f6e d6q c6h",
        "Viva la Vida::g4q e5q e5q e5e d5e e5e d5q a4q b4q c5q d5q d5q d5e b4e d5q b4q e4q F4q g4q e5q e5q e5e d5e e5q F5q F5q F5h d5q d5q d5q d5e c5e c5e b4e r1q b4e b4e b4q",
    };

        //Playlist entry thingy.
        static List<playlistEntry> playlist = new List<playlistEntry>();

        //Base playlist of some songs made by Mr. McCarl
        static string fileLocation = "D:\\base playlist.txt";

        //Octave 0 frequencies.
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

        /// <summary>
        /// Takes a frequency and duration, and plays a beep if the frequency is valid.
        /// </summary>
        /// <param name="freq"></param>
        /// <param name="dur"></param>
        static void playNote(int freq, int dur)
        {
            if (freq > 37 && freq < 32767 && OperatingSystem.IsWindows())
            {
                Console.Beep(freq, dur);
            }
            else
            {
                Thread.Sleep(dur);
            }
        }

        /// <summary>
        /// Takes a string of notes, seperated by spaces.
        /// Uppercase notes = sharps.
        /// Note, Octave, Duration
        /// </summary>
        /// <param name="song"></param>
        static void playSong(String song, int tempo)
        {
            double freq;
            int dur;

            //Iterator traverses the string by four (note, octave, duration, space)
            for (int i = 0; i < song.Length; i += 4)
            {
                //Find the duration.
                switch (song[i + 2])
                {
                    case 's': dur = tempo / 16; break; // s = Sixteenth
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

                //Checking if the note is lowercase so it will play a natural note.
                if (song[i] >= 'a' && song[i] <= 'g')
                {
                    freq = notes[song[i] - 'a'] * Math.Pow(2, song[i + 1] - '0'); // Single line statements to make whoever is reading this suffer.
                }
                //Else if the note is uppercase, play sharp note.
                else if (song[i] >= 'A' && song[i] <= 'G')
                {
                    freq = notes[song[i] - 'A'] * Math.Pow(2, song[i + 1] - '0') * Math.Pow(2, 1.0 / 12.0); //POW!!
                }
                else
                {
                    freq = 0;
                }
                Console.WriteLine($"Note:{song[i]}\nFrequency :{freq}\nDuration :{dur}");
                playNote((int)freq, dur);
            }
        }

        static void Main(String[] args)
        {
            int tempo = 1000;
            string? test;
            ConsoleKeyInfo key;
            ConsoleKey cKey = ConsoleKey.E;
            playlistEntry ple = new playlistEntry();

            //Putting the premade songs into the playlist.
            foreach (string s in preMadeSongs)
            {
                string[] temp = s.Split("::");
                //playlistEntry ple = new playlistEntry();
                ple.name = temp[0];
                ple.song = temp[1];
                playlist.Add(ple);
            }

            //Do-While loop to keep the user in the main program loop. Exit by pressing escape.
            do
            {
                Console.Clear();
                for (int i = 0; i < playlist.Count; i++)
                {
                    Console.WriteLine($"{i}.....{playlist[i].name}");
                }
                if (playlist.Count > 0)
                {
                    Console.WriteLine($"Press A to add a song, D to delete a song, S to save the playlist to a file, or L to load a playlist from a file");
                    //stupid key thing. - Don't remove. It works right now.
                    key = Console.ReadKey();
                    cKey = key.Key;
                    Console.Clear();
                    switch (key.KeyChar)
                    {
                        //Add a song in the playlist
                        case 'a':
                        case 'A':
                            if (playlist.Count < 10)
                            {

                                Console.WriteLine("What is the name of the song?");
                                string? s;
                                do { s = Console.ReadLine(); } while (s == string.Empty);
                                ple.name = s;
                                do { s = Console.ReadLine(); } while (s == null || s.Length < 3);
                                ple.song = s;
                                playlist.Add(ple);
                            }
                            else
                            {
                                Console.WriteLine("Sorry, can't do that - lack of space.");
                            }
                            break;
                        //Delete a song in the playlist
                        case 'd':
                        case 'D':
                            if (playlist.Count > 0)
                            {
                                for (int i = 0; i < playlist.Count; i++)
                                {
                                    //Write out the playlist
                                    Console.WriteLine($"{i}.....{playlist[i].name}");
                                }
                                Console.WriteLine($"press 0 - {playlist.Count - 1} to delete song or ESC to cancel");
                                int deleteSongNumber = -1;
                                //Put the user into a loop until they enter a vaild index
                                do
                                {
                                    ConsoleKeyInfo key2 = Console.ReadKey();
                                    if (key2.Key == ConsoleKey.Escape) break;
                                    deleteSongNumber = key2.KeyChar - '0';
                                    Console.WriteLine(deleteSongNumber);
                                } while (deleteSongNumber < 0 || deleteSongNumber > playlist.Count - 1);
                                //Remove the song at the user's index
                                if (deleteSongNumber >= 0) playlist.RemoveAt(deleteSongNumber);
                            }
                            break;
                        //Save playlist to a file
                        case 's':
                        case 'S':
                            Console.WriteLine("Save Playlist Here\ne.g. D\\\\file.txt");
                            do { fileLocation = Console.ReadLine(); } while (fileLocation == "" || fileLocation == null); // Make sure the file location is not null
                            using (StreamWriter writer = new StreamWriter(fileLocation))
                            {
                                foreach (playlistEntry thingy in playlist)
                                {
                                    writer.WriteLine($"{thingy.name}::{thingy.song}");
                                }
                            }
                            Console.ReadLine();
                            break;
                        //Write to a playlist from a file
                        case 'l':
                        case 'L':
                            playlist.Clear();
                            Console.WriteLine("Load playlist here\ne.g. D\\\\file.txt");
                            do { fileLocation = Console.ReadLine(); } while (fileLocation == "" || fileLocation == null); // Make sure the file location is not null
                            string[] lines;
                            lines = File.ReadAllLines(fileLocation);
                            foreach (string line in lines)
                            {
                                if (line != null)
                                {
                                    string[] temp = line.Split("::");
                                    ple.name = temp[0];
                                    ple.song = temp[1];
                                    playlist.Add(ple);
                                }
                            }
                            break;

                        //Playing individual songs.
                        default:
                            int songNumber = key.KeyChar - '0';
                            if (songNumber < playlist.Count)
                            {
                                Console.Write("Write the speed. (defaults to 1000): ");
                                test = Console.ReadLine();
                                //Parse string into an integer.
                                Int32.TryParse(test, out tempo);
                                //If tempo = 0, default to 1000
                                if (tempo == 0) tempo = 1000;
                                playSong(playlist[key.KeyChar - '0'].song, tempo);
                                Console.WriteLine($"Playing song #{songNumber} {playlist[songNumber].name}");
                            }
                            break;
                    }
                }
            } while (cKey != ConsoleKey.Escape);
        }
    }
}