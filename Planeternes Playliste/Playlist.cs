using System.Collections.Generic;
using System;

namespace Planeternes_Playliste
{
    class Playlist
    {

        public LinkedList<Track> plist = new LinkedList<Track>();  //playlist linkedlist
        public LinkedListNode<Track> t = new LinkedListNode<Track>(new Track("goofy goober rock", 174, "Spongebob Squarepants")); // this just adds the best song to the first playlist
        public Playlist()  // default constructor
        {
            plist.AddFirst(t);    //auto adds goofy goober rock to playlist
        }
        public void addToPlaylist(string _name, int _length, string _creator)   // adds new songs to playlist, usign their names, lengths, and their creator
        {
            t = new LinkedListNode<Track>(new Track(_name, _length, _creator));  //adds to linkedlist playlist
            plist.AddLast(t);
        }
        public void ShowPlaylist()  // prints out all song names in playlist
        {
            LinkedListNode<Track> current = plist.First;   // first we have to get the node in the playlist, so we can target the next 
            for (int i = 0; i < plist.Count; i++)  // we get the length of the playlist, and loop that many times,
            {
                Console.WriteLine(current.Value.TrackName);   // we print out the current trackname
                current = current.Next;  //then we target the next track, and we loop back or get out of the loop in case the loop is done
                 
            }
        }
    }

}

