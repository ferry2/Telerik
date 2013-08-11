using System.Data.Entity;

namespace MusicStore.Models
{
    public class MusicStoreDb : DbContext
    {
        public MusicStoreDb()
            : base("DefaultConnection")
        {            
        }

        public DbSet<AlbumModel> Albums { get; set; }
        public DbSet<ArtistModel> Artists { get; set; }
        public DbSet<SongModel> Songs { get; set; }
    }
}