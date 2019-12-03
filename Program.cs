using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist mtVerArtist = Artists.FirstOrDefault(who => who.Hometown == "Mount Vernon");
            // Console.WriteLine(mtVerArtist.ArtistName + " " + mtVerArtist.Age);


            //Who is the youngest artist in our collection of artists?
            Artist youngest = Artists.FirstOrDefault(young => young.Age == Artists.Min(y => y.Age));
            // Console.WriteLine(youngest.ArtistName);

            //Display all artists with 'William' somewhere in their real name
            List<Artist> williamArtists = Artists.Where(name => name.RealName.Contains("William")).ToList();
            // PrintEach(williamArtists);


            // //Display the 3 oldest artists from Atlanta
            // List<Artist> atlArtists = Artists.Where(loc => loc.Hometown == "Atlanta" && loc.Age.OrderByDecending == ).ToList();
            // PrintEach(atlArtists);

            IEnumerable<Artist> atlArtists = Artists
            .Where(loc => loc.Hometown == "Atlanta")
            .OrderByDescending(a => a.Age)
            .Take(3);
            PrintEach(atlArtists);


            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
	        // Console.WriteLine(Groups.Count);
        }
        public static void PrintEach(IEnumerable<dynamic> items)
        {
            foreach (var item in items) 
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
