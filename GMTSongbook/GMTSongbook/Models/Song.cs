using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMTSongbook.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public int ArtistID { get; set; }
        public Artist Artist { get; set; }

        public string Title { get; set; }
        public DateTime ComposedDate { get; set; }
        public List<Review> Reviews { get; set; }

    }

   
}