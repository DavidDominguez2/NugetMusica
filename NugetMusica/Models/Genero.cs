using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetMusica.Models {
    [Table("genero")]
    public class Genero {
        [Key]
        [Column("id_genero")]
        public int IdGenero {get; set;}

        [Column("nombre")]
        public string Nombre {get; set;}
    }
}
