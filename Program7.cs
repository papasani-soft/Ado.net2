using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    class Program7
    {
        public static void Main(string[] args)
        {
            CreatingCustomProjectionsWithTheDataSourceType();
            Console.Read();
        }
        static void CreatingCustomProjectionsWithTheDataSourceType()
        {
            List<MusicalArtist> artistsDataSource = Program5.GetMusicalArtists();

            IEnumerable<MusicalArtist> artistsResult =
                from artist in artistsDataSource
                select new MusicalArtist
                {
                    Name = artist.Name,
                    LatestHit = artist.LatestHit
                };

            Console.WriteLine("\nCustom Projection With Data Source Type");
            Console.WriteLine("---------------------------------------\n");

            foreach (MusicalArtist artist in artistsResult)
            {
                Console.WriteLine(
                    "Name: {0}\nLatest Hit: {1}\n",
                    artist.Name,
                    artist.LatestHit);
            }
        }
    }
}
