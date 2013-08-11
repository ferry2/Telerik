using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicStore.Models
{
    [Table("Artists")]
    public class ArtistModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArtistId { get; set; }

        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}