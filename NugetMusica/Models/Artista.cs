using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetMusica.Models {
    [Table("artista")]
    public class Artista
    {

        [Key]
        [Column("id_artista")]
        public int IdArtista{ get; set; }

        [Column("nombre")]
        public string Nombre{ get; set; }

        [Column("nacionalidad")]
        public string Nacionalidad { get; set; }
    }
}
