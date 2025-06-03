using System;

namespace AquaRescue.DTO
{
    public class LogCalculoDTO
    {
        public int ComunidadeId { get; set; }
        public int QtHabitantes { get; set; }
        public double ConsumoPorPessoa { get; set; }
        public double TotalVolume { get; set; }
        public DateTime DataCalculo { get; set; }
    }
}
