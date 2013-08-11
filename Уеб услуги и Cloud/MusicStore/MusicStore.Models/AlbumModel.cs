namespace MusicStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Albums")]
    public class AlbumModel
    {
        public AlbumModel()
        {
            this.Artists = new HashSet<ArtistModel>();
            this.Songs = new HashSet<SongModel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }

        public string Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Producer { get; set; }
        public IEnumerable<ArtistModel> Artists { get; set; }
        public IEnumerable<SongModel> Songs { get; set; }
    }
}