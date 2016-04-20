using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GMTSongbook.Models
{
    public class Artist
    {
 
        public int ArtistID { get; set; }
        public string StageName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Song> Songs { get; set; }

    }
}