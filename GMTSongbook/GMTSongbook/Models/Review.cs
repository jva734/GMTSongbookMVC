using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GMTSongbook.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Comment { get; set; }
        public string ReviewdBy { get; set; }
    }
}