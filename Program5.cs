using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    public class MusicalArtist
    {
        public string Name { get; set; }

        public string Genre { get; set; }

        public string LatestHit { get; set; }

        public List<Album> Albums { get; set; }
    }
    public class Album
    {
        public string Name { get; set; }
        public string Year { get; set; }

        public string RecordingLabel { get; set; }
    }
    class Program5
    {
       public static List<MusicalArtist> GetMusicalArtists()
        {
            return new List<MusicalArtist>
            {
                new MusicalArtist
                {
                    Name = "Adele",
                    Genre = "Pop",
                    LatestHit = "Someone Like You",
                    Albums = new List<Album>
                    {
                        new Album { Name = "21", Year = "2011" },
                        new Album { Name = "19", Year = "2008" },
                    }
                },
                new MusicalArtist
                {
                    Name = "Maroon 5",
                    Genre = "Adult Alternative",
                    LatestHit = "Moves Like Jaggar",
                    Albums = new List<Album>
                    {
                        new Album { Name = "Misery", Year = "2010" },
                        new Album { Name = "It Won't Be Soon Before Long", Year = "2008" },
                        new Album { Name = "Wake Up Call", Year = "2007" },
                        new Album { Name = "Songs About Jane", Year = "2006" },
                    }
                },
                new MusicalArtist
                {
                    Name = "Lady Gaga",
                    Genre = "Pop",
                    LatestHit = "You And I",
                    Albums = new List<Album>
                    {
                        new Album { Name = "The Fame", Year = "2008" },
                        new Album { Name = "The Fame Monster", Year = "2009" },
                        new Album { Name = "Born This Way", Year = "2011" },
                    }
                }
            };
        }
    }
}
