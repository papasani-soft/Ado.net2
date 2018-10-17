using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    class Program9
    {
        public static void Main(string[] args)
        {
            ProjectingAnonymousTypes();
            Console.Read();
        }
        private static void ProjectingAnonymousTypes()
        {
            List<MusicalArtist> artistsDataSource = Program5.GetMusicalArtists();

            var artistsResult =
                from artist in artistsDataSource
                select new
                {
                    Name = artist.Name,
                    NumberOfAlbums = artist.Albums.Count
                };

            Console.WriteLine("\nProjecting Anonymous Types");
            Console.WriteLine("--------------------------\n");

            foreach (var artist in artistsResult)
            {
                Console.WriteLine(
                    "Artist Name: {0}\nNumber of Albums: {1}\n",
                    artist.Name,
                    artist.NumberOfAlbums);
            }
        }
    }
}
