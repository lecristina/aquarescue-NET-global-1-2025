using AquaRescue.Data;
using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AquaRescue.Repository
{
    public class LogCalculoRepository : ILogCalculoRepository
    {
        private readonly AquaRescueDbContext _context;

        public LogCalculoRepository(AquaRescueDbContext context)
        {
            _context = context;
        }

        public void Criar(LogCalculo log)
        {
            _context.LogsCalculo.Add(log);
            _context.SaveChanges();
        }

        public List<LogCalculo> BuscarPorComunidade(int comunidadeId)
        {
            return _context.LogsCalculo.Where(l => l.ComunidadeId == comunidadeId).ToList();
        }

        public LogCalculo? BuscarPorId(int id)
        {
            return _context.LogsCalculo.FirstOrDefault(l => l.Id == id);
        }

        public void Atualizar(LogCalculo log)
        {
            _context.LogsCalculo.Update(log);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var log = _context.LogsCalculo.FirstOrDefault(l => l.Id == id);
            if (log != null)
            {
                _context.LogsCalculo.Remove(log);
                _context.SaveChanges();
            }
        }
    }
}
