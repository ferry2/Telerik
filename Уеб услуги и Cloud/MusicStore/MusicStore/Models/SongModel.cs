using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models
{
    [Table("Songs")]
    public class SongModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }

        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public ArtistModel Artist { get; set; }
    }
}