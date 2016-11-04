using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

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