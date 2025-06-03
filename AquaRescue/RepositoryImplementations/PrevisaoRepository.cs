using AquaRescue.Data;
using AquaRescue.Models;
using AquaRescue.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AquaRescue.Repository
{
    public class PrevisaoRepository : IPrevisaoRepository
    {
        private readonly AquaRescueDbContext _context;

        public PrevisaoRepository(AquaRescueDbContext context)
        {
            _context = context;
        }

        public void Criar(Previsao previsao)
        {
            _context.Previsoes.Add(previsao);
            _context.SaveChanges();
        }

        public List<Previsao> BuscarPorComunidade(int comunidadeId)
        {
            return _context.Previsoes.Where(p => p.ComunidadeId == comunidadeId).ToList();
        }

        public Previsao? BuscarPorId(int id)
        {
            return _context.Previsoes.FirstOrDefault(p => p.Id == id);
        }

        public void Atualizar(Previsao previsao)
        {
            _context.Previsoes.Update(previsao);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var previsao = _context.Previsoes.FirstOrDefault(p => p.Id == id);
            if (previsao != null)
            {
                _context.Previsoes.Remove(previsao);
                _context.SaveChanges();
            }
        }
    }
}
