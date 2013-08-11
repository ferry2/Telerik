using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models
{
    [Table("Albums")]
    public class AlbumModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AlbumId { get; set; }

        public string Title { get; set; }
        public string Year { get; set; }
        public string Producer { get; set; }
        public IEnumerable<ArtistModel> Artists { get; set; }
        public IEnumerable<SongModel> Songs { get; set; }
    }
}