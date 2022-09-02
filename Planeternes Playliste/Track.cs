using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeternes_Playliste
{
    class Track
    {// Track class, could have been a struct, but meh
        private int _trackLength;  // length of the track. not actually important, as it doesnt get printed out, but it oculd easily have been

        public int SongLength
        {
            get { return _trackLength; }
            set { _trackLength = value; }
        } 

        private string _trackCreator;  // the song's creator or publisher, same thing applies here as track length

        public string SongCreator
        {
            get { return _trackCreator ; }
            set { _trackCreator = value; }
        }

        private string _trackname;   // the song name, the only actual important thing

        public string TrackName
        {
            get { return _trackname; }
            set { _trackname = value; }
        }


        public Track(string trackName, int trackLength, string trackCreator)    // defualt constructor, which applies inbound data into its own properties
        {
            _trackname = trackName;
            _trackCreator = trackCreator;
            _trackLength = trackLength;
            
        }

    }
}
