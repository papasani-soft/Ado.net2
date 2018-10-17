using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    class Program6
    {
        public static void Main(string[] args)
        {
            QueryingCustomTypes();
            Console.Read();
        }
        static void QueryingCustomTypes()
        {
            List<MusicalArtist> artistsDataSource = Program5.GetMusicalArtists();

            IEnumerable<MusicalArtist> artistsResult =
                from artist in artistsDataSource
                select artist;

            Console.WriteLine("\nQuerying Custom Types");
            Console.WriteLine("---------------------\n");

            foreach (MusicalArtist artist in artistsResult)
            {
                Console.WriteLine(
                    "Name: {0}\nGenre: {1}\nLatest Hit: {2}\n",
                    artist.Name,
                    artist.Genre,
                    artist.LatestHit);
              
            }
        }
    }
}
