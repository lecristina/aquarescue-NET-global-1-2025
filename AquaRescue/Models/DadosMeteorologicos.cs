using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaRescue.Models
{
    [Table("T_AQUA_DADOS_METEOROLOGICOS")]
    public class DadosMeteorologicos
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("COMUNIDADE_ID")]
        public int ComunidadeId { get; set; }

        [Column("DATA_HORA")]
        public DateTime DataHora { get; set; }

        [Column("TEMPERATURA")]
        public double Temperatura { get; set; }

        [Column("UMIDADE")]
        public double Umidade { get; set; }

        [Column("PTO_ORVALHO")]
        public double PtoOrvalho { get; set; }

        [Column("PRESSAO")]
        public double Pressao { get; set; }

        [Column("VENTO_VELOC")]
        public double VentoVeloc { get; set; }

        [Column("VENTO_DIRECAO")]
        public double VentoDirecao { get; set; }

        [Column("VENTO_RAJADA")]
        public double VentoRajada { get; set; }

        [Column("RADIACAO")]
        public double Radiacao { get; set; }

        [Column("CHUVA")]
        public double Chuva { get; set; }

    }
}
