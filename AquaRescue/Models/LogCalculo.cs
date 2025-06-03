using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaRescue.Models
{
    [Table("T_AQUA_LOG_CALCULO")]
    public class LogCalculo
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("COMUNIDADE_ID")]
        public int ComunidadeId { get; set; }

        [Column("DATA_CALCULO")]
        public DateTime DataCalculo { get; set; } = DateTime.Now;

        [Column("QT_HABITANTES")]
        public int QtHabitantes { get; set; }

        [Column("CONSUMO_POR_PESSOA")]
        public double ConsumoPorPessoa { get; set; }

        [Column("TOTAL_VOLUME")]
        public double TotalVolume { get; set; }

    }
}
