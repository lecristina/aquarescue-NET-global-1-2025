using System;

namespace AquaRescue.DTO
{
    public class DadosMeteorologicosDTO
    {
        public int ComunidadeId { get; set; }
        public DateTime DataHora { get; set; }
        public double Temperatura { get; set; }
        public double Umidade { get; set; }
        public double PtoOrvalho { get; set; }
        public double Pressao { get; set; }
        public double VentoVeloc { get; set; }
        public double VentoDirecao { get; set; }
        public double VentoRajada { get; set; }
        public double Radiacao { get; set; }
        public double Chuva { get; set; }
    }
}
