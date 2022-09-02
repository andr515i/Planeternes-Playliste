using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeternes_Playliste
{
    class Program
    {
        static void Main(string[] args)
        {

            // playlist using linkedlists and linkedlistnodes 


            Console.WriteLine("which songs would you like to add to your playlist?\n1. name \n2. song length in seconds\n3.song creator"); // give minimal instructions
            string name = Console.ReadLine();  // inputs for song name, length and their creator
            int length = Convert.ToInt32(Console.ReadLine());
            string creator = Console.ReadLine();

            Playlist pl = new Playlist();  // actual playlist class, with linkedlist inside
            pl.addToPlaylist(name, length, creator);   // adds information to a track (class and therefore datatype) which then goes into the playlist linkedlist

            string name2 = Console.ReadLine(); // input for a second song, jsut for good measure
            int length2 = Convert.ToInt32(Console.ReadLine());
            string creator2 = Console.ReadLine();

            pl.addToPlaylist(name2, length2, creator2); // add second song

            pl.ShowPlaylist();  // prints out all songnames from palylist
            
            Console.ReadLine(); //stops console from killing itself instantly

        }
    }
}
