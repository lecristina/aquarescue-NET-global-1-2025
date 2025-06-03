using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaRescue.Models
{
    [Table("T_AQUA_PREVISAO")]
    public class Previsao
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("COMUNIDADE_ID")]
        public int ComunidadeId { get; set; }

        [Column("TEMPERATURA")]
        public double Temperatura { get; set; }

        [Column("UMIDADE")]
        public double Umidade { get; set; }

        [Column("VOLUME_PREVISTO")]
        public double VolumePrevisto { get; set; }

        [Column("DATA_PREVISAO")]
        public DateTime DataPrevisao { get; set; } = DateTime.Now;

    }
}
