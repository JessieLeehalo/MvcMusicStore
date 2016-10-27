using System;
using System.Data.Entity;
//using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    // The MusicDBContect class handles the task of connecting to the database and mapping Album objects to database records.
    public class MusicDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}