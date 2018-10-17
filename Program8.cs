using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    class ArtistViewModel
    {
        public string ArtistName { get; set; }

        public string Song { get; set; }
    }
    class Program8
    {
        public static void Main(string[] args)
        {
            CreatingCustomProjectionsOnDifferentType();
            Console.Read();
        }
        static void CreatingCustomProjectionsOnDifferentType()
        {
            List<MusicalArtist> artistsDataSource = Program5.GetMusicalArtists();

            IEnumerable<ArtistViewModel> artistsResult =
                from artist in artistsDataSource
                select new ArtistViewModel
                {
                    ArtistName = artist.Name,
                    Song = artist.LatestHit
                };

            Console.WriteLine("\nCustom Projection On a Different Type");
            Console.WriteLine("-------------------------------------\n");

            foreach (ArtistViewModel artist in artistsResult)
            {
                Console.WriteLine(
                    "Artist Name: {0}\nSong: {1}\n",
                    artist.ArtistName,
                    artist.Song);
            }
        }
    }
}
