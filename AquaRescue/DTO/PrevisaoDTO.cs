using System;

namespace AquaRescue.DTO
{
    public class PrevisaoDTO
    {
        public int ComunidadeId { get; set; }
        public double Temperatura { get; set; }
        public double Umidade { get; set; }
        public double VolumePrevisto { get; set; }
        public DateTime DataPrevisao { get; set; }
    }
}
