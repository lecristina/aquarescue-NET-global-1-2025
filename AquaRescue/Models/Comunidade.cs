using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaRescue.Models
{
    [Table("T_AQUA_COMUNIDADE")]
    public class Comunidade
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NOME")]
        public string Nome { get; set; } = string.Empty;

        [Column("LATITUDE")]
        public double Latitude { get; set; }

        [Column("LONGITUDE")]
        public double Longitude { get; set; }

        [Column("QT_HABITANTES")]
        public int QtHabitantes { get; set; }

    }
}
