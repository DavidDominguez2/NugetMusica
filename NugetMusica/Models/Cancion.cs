using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NugetMusica.Models {
    [Table("cancion")]
    public class Cancion {

        [Key]
        [Column("id_cancion")]
        public int IdCancion { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }

        [Column("duracion")]
        public double Duracion { get; set; }

        [Column("album")]
        public string Album { get; set; }

        [Column("portada")]
        public string Portada { get; set; }

        [Column("id_artista")]
        public int IdArtista { get; set; }

        [Column("id_genero")]
        public int IdGenero { get; set; }


    }
}
