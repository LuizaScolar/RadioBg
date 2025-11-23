using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadioBG.Models
{
    [Table("tbMusica")] 
    public class Musica
    {
        [Key]
        public int MusicaId { get; set; } 

        public string? MusicaNome { get; set; }

        public string? MusicaCantor { get; set; }

    }
}