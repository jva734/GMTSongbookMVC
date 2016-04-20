using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GMTSongbook.Models;
using System.Data.Entity;

namespace GMTSongbook.Models.DataContext
{
    public class GMTSongbookContext :DbContext
    {
        public GMTSongbookContext() : base ("GMTSongbookContext")
        {
        }

        public DbSet<Artist> Artist { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}